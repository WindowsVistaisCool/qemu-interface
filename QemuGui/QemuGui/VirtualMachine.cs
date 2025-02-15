namespace QEMUInterface
{

    public class VirtualMachine
    {
        private static int defaultID = 0;

        public string Name { get; set; }
        public int ID { get; private set; }
        public string OSFriendlyName { get; set; } = "Unknown";

        public bool VerboseRunning { get; set; } = false;

        public Func<int, bool> ControlModifyCondition { get; set; } = (id) => true;

        private string qemuPcName = "cmd.exe";
        private string arguments = "/k echo WE NEED TO COOK!!";

        private System.Diagnostics.Process? process;

        private EventHandler? exitEvent;

        public VirtualMachine(string name, int id)
        {
            Name = name;
            ID = id;
        }
        public VirtualMachine() : this("Default", defaultID++) { }
        public VirtualMachine(string name) : this(name, defaultID++) { }

        public void Run()
        {
            DisposeProcess();
            CreateProcess();
        }

        public void SetPCType(string pcType)
        {
            qemuPcName = pcType;
        }

        public void SetRunArguments(string args)
        {
            arguments = args;
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

        public bool IsRunning()
        {
            if (process == null)
            {
                return false;
            }

            return !process.HasExited;
        }

        private void CreateProcess()
        {
            process = new System.Diagnostics.Process();
            process.StartInfo.FileName = qemuPcName;
            process.StartInfo.Arguments = arguments;

            if (!VerboseRunning)
            {
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
            }

            process.EnableRaisingEvents = true;
            process.Exited += exitEvent;

            process.Start();
        }

        private void DisposeProcess()
        {
            if (process != null)
            {
                process.Kill();
                process.Dispose();
                process = null;
            }
        }

        private static void SafeModifyControl(Control c, Action<Control> rawModification)
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
