using System.CodeDom;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace QEMUInterface
{
    public class VirtualMachine
    {
        public readonly bool needsRecovery = false;

        public string Name = "";
        public string VMDirectory { get; set; } = "";
        public string UUID { get; set; }

        public PC_TYPE PCType = PC_TYPE.IA_32;
        public OperatingSystem OS = OperatingSystems.get("Windows 7");
        public string OSSubversion = "";
        public string Machine = "";
        public int CPUCoreCount = 1;
        public int Memory = 1024;
        public GRAPHICS_TYPE Graphics = GRAPHICS_TYPE.STD;
        public string Audio = "None";

        public bool VerboseRunning = false;

        public Func<string, bool> ControlModifyCondition = (id) => true;

        public string ProcessName = "cmd.exe";
        public string ProcessArgs = "";

        private Process? process;

        private EventHandler? exitEvent;
        private Action? abortEvent;

        public VirtualMachine(bool recovery) : this()
        {
            needsRecovery = recovery;
        }
        public VirtualMachine()
        {
            UUID = Guid.NewGuid().ToString();
        }

        public static Dictionary<string, object> MinimumDataRequired()
        {
            // 0 is a placeholder value
            return new Dictionary<string, object>
            {
                ["Name"] = 0,
                ["UUID"] = 0,
                ["Specs"] = new Dictionary<string, object>
                {
                    ["OS"] = 0,
                    ["OSSubversion"] = 0,
                    ["PCType"] = 0,
                    ["Machine"] = 0,
                    ["CPU"] = new Dictionary<string, object>
                    {
                        ["Cores"] = 0,
                    },
                    ["Memory"] = 0,
                    ["Graphics"] = 0,
                    ["Audio"] = 0,
                },
                ["ProcessDetails"] = new Dictionary<string, object>
                {
                    ["ProcessName"] = 0,
                    ["ProcessArgs"] = 0,
                },
            };
        }

        public Dictionary<string, object> ToJson()
        {
            var dataConstruct = MinimumDataRequired();
            dataConstruct["Name"] = Name;
            dataConstruct["UUID"] = UUID;
            var specs = (Dictionary<string, object>)dataConstruct["Specs"];
            specs["OS"] = OS.Name;
            specs["OSSubversion"] = OSSubversion;
            specs["PCType"] = PCType.ToString();
            specs["Machine"] = Machine;
            specs["CPU"] = new Dictionary<string, object>
            {
                ["Cores"] = CPUCoreCount,
            };
            specs["Memory"] = Memory;
            specs["Graphics"] = Graphics.ToString();
            specs["Audio"] = Audio;
            var processDetails = (Dictionary<string, object>)dataConstruct["ProcessDetails"];
            processDetails["ProcessName"] = ProcessName;
            processDetails["ProcessArgs"] = ProcessArgs;
            return dataConstruct;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(ToJson(), new JsonSerializerOptions { WriteIndented = true }); // extremely real code
        }

        public bool SetVarString(string varName, object value)
        {

            if (GetType().GetFields(BindingFlags.Public | BindingFlags.Instance).ToList().Select(i => i.Name).Contains(varName))
            {

                var fieldReflect = GetType().GetField(varName);
                if (fieldReflect == null) return false;

                var field = fieldReflect.GetValue(this)!;

                if (field == null) return false;


                if (field.GetType() == value.GetType())
                {
                    fieldReflect.SetValue(this, value);

                    return true;
                }
                else if (field.GetType() == typeof(PC_TYPE) && value.GetType() == typeof(string))
                {
                    try
                    {
                        _ = Enum.TryParse(value.ToString(), out PCType);
                        return true;
                    }
                    catch (Exception)
                    {
                        {
                            return false;
                        }
                    }
                }
                else if (field.GetType() == typeof(OperatingSystem))
                {
                    try
                    {
                        OperatingSystem? sys = OperatingSystems.get(value.ToString()!);
                        if (sys != null)
                        {
                            OS = (OperatingSystem)sys;
                            return true;
                        }
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else if (field.GetType() == typeof(GRAPHICS_TYPE) && value.GetType() == typeof(string))
                {
                    try
                    {
                        _ = Enum.TryParse(value.ToString(), out Graphics);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public void GenerateProcessArgs()
        {
            ProcessName = QemuMachines.getQemuCmd(PCType);
            ProcessArgs = "";

        }
        public void Run()
        {
            DisposeProcess();
            CreateProcess();
        }

        public void AddExitEvent(EventHandler e)
        {
            exitEvent += e;
        }

        public void EditControlOnExit(Action modification)
        {
            AddExitEvent((_, _) =>
            {
                if (!ControlModifyCondition(UUID))
                {
                    return;
                }
                modification();
            });
        }

        public void EditControlOnAbort(Action modification)
        {
            abortEvent = modification;
        }

        public bool IsRunning()
        {
            if (process == null)
            {
                return false;
            }

            try
            {
                return !process.HasExited;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to check run state:\n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CreateProcess()
        {
            process = new Process();
            process.StartInfo.FileName = ProcessName;
            process.StartInfo.Arguments = ProcessArgs;

            if (!VerboseRunning)
            {
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
            }

            process.EnableRaisingEvents = true;
            process.Exited += exitEvent;

            try
            {
                process.Start();
            }
            catch (Exception e)
            {
                abortEvent?.Invoke();
                MessageBox.Show("Failed to start process:\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisposeProcess()
        {
            if (process != null)
            {
                try
                {
                    process.Kill();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Failed to kill process:\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                process.Dispose();
                process = null;
            }
        }
    }
}
