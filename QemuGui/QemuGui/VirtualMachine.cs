using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace QEMUInterface
{

    public class VirtualMachine
    {
        private static int defaultID = 0;

        private string filePath;

        public string Name { get; set; }
        public int ID { get; private set; }
        internal PC_TYPE PCType { get; set; }
        internal OperatingSystem OperatingSystem { get; set; }
        internal string OSSubversion { get; set; } = "";
        internal string Machine { get; set; }

        internal int CPUCoreCount { get; set; } = 1;
        internal int MemorySize { get; set; } = 1024;

        public bool VerboseRunning { get; set; } = false;

        public Func<int, bool> ControlModifyCondition { get; set; } = (id) => true;

        public string ProcessName { get; set; }  = "cmd.exe";
        public string ProcessArgs { get; set; } = "/k echo running";

        private Process? process;

        private EventHandler? exitEvent;
        private Action? abortEvent;

        public VirtualMachine(string path, string name, int id)
        {
            filePath = path;
            Name = name;
            ID = id;
        }
        public VirtualMachine() : this("", "", defaultID++) { }
        public VirtualMachine(string path, string name) : this(path, name, defaultID++) { }

        public void Run()
        {
            DisposeProcess();
            CreateProcess();
        }

        public void AddExitEvent(EventHandler e)
        {
            exitEvent += e;
        }

        public void EditControlOnExit(Control c, Action<Control> rawModification)
        {
            AddExitEvent((_, _) =>
            {
                if (!ControlModifyCondition(ID))
                {
                    return;
                }
                SafeModifyControl(c, rawModification);
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
            } catch (Exception e)
            {
                MessageBox.Show("Failed to check run state:\n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CreateProcess()
        {
            process = new System.Diagnostics.Process();
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
            } catch (Exception e)
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
                } catch (Exception e)
                {
                    MessageBox.Show("Failed to kill process <X>:\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                process.Dispose();
                process = null;
            }
        }

        private void SafeModifyControl(Control c, Action<Control> rawModification)
        {
            if (c.InvokeRequired)
            {
                c.Invoke(delegate { SafeModifyControl(c, rawModification); });
            }
            else
            {
                rawModification.Invoke(c);
            }
        }
    }
}
