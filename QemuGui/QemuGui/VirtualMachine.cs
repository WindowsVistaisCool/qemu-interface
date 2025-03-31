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
        private static int defaultID = 0;
        public readonly bool needsRecovery = false;

        public string Name { get; set; } = "";
        public string FilePath { get; set; } = "";
        public int ID { get; private set; }

        internal PC_TYPE PCType { get; set; }
        internal OperatingSystem OperatingSystem { get; set; }
        internal string OSSubversion { get; set; } = "";
        internal string Machine { get; set; } = "";

        internal int CPUCoreCount { get; set; } = 1;
        internal int Memory { get; set; } = 1024;

        internal GRAPHICS_TYPE Graphics { get; set; } = GRAPHICS_TYPE.STD;
        internal string Audio { get; set; } = "none";

        public bool VerboseRunning { get; set; } = false;

        public Func<int, bool> ControlModifyCondition { get; set; } = (id) => true;

        public string ProcessName { get; set; } = "cmd.exe";
        public string? ProcessArgs { get; set; }

        private Process? process;

        private EventHandler? exitEvent;
        private Action? abortEvent;

        public VirtualMachine(bool recovery) : this() {
            needsRecovery = recovery;
        }
        public VirtualMachine()
        {
            ID = defaultID++;
        }

        public static Dictionary<string, object> MinimumDataRequired()
        {
            // 0 is a placeholder value
            return new Dictionary<string, object>
            {
                ["Name"] = 0,
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
                    //["Graphics"] = 0,
                    //["Audio"] = 0,
                }
                ["ProcessDetails"] = new Dictionary<string, object>
                {
                    ["ProcessName"] = 0,
                    ["ProcessArgs"] = 0
                }
            };
        }

        public Dictionary<string, object> ToJson()
        {
            var minData = MinimumDataRequired();
            minData["Name"] = Name;
            var specs = (Dictionary<string, object>)minData["Specs"];
            specs["OS"] = OperatingSystem.Name;
            specs["OSSubversion"] = OSSubversion;
            specs["PCType"] = PCType;
            specs["Machine"] = Machine;
            specs["CPU"] = new Dictionary<string, object>
            {
                ["Cores"] = CPUCoreCount,
            };
            specs["Memory"] = Memory;
            specs["Graphics"] = Graphics;
            specs["Audio"] = Audio;
            var processDetails = (Dictionary<string, object>)minData["ProcessDetails"];
            processDetails["ProcessName"] = ProcessName;
            processDetails["ProcessArgs"] = ProcessArgs;
            return minData;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(ToJson()); // extremely real code
        }

        public bool SetVarString(string varName, object value)
        {

            if (GetType().GetFields(BindingFlags.Public | BindingFlags.Instance).ToList().Select(i => i.Name).Contains(varName))
            {
                var field = GetType().GetProperty(varName)!;
                if (field.GetType() == value.GetType())
                {
                    field.SetValue(this, value);
                    return true;
                }
            }

            return false;
        }

        public void GenerateProcessArgs()
        {
            ProcessName = QemuMachines.getQemuCmd(PCType);
            ProcessArgs ??= "";

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

        /*
         * dont ask me what this code is idek
         * 
         * parameter explanation - pass in the SafeModifyControl function that modifies
         * the control
         * the parent action can call SafeModifyControl to modify the control
         */
        public void EditControlOnExit(Action modification)
        {
            AddExitEvent((_, _) =>
            {
                if (!ControlModifyCondition(ID))
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
                if (abortEvent != null)
                {
                    abortEvent();
                }
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
