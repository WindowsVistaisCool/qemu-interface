using System.Security.AccessControl;

namespace QEMUInterface
{

    internal class VirtualMachine
    {
        private static int defaultID = 0;

        public string Name { get; set; }
        public int ID { get; private set; }

        public bool VerboseRunning { get; set; } = false;

        public Func<bool> ModifyCondition { get; set; } = () => true; // condition to apply Control modifications (used mainly to ensure we only modify the window if the VM is selected)

        private string qemuPcName = "cmd.exe";//"qemu-system-ppc.exe";
        private string arguments = "/k echo yoink";//"-L pc-bios -boot c -M mac99 -m 512 -drive file=C:\\Users\\windo\\macstuff\\Puma.img,format=raw,media=disk";

        private System.Diagnostics.Process? process;

        private EventHandler? exitEvent;

        public VirtualMachine(string name)
        {
            Name = name;
            ID = defaultID++;
        }
        public VirtualMachine() : this("Default") { }

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
                if (!ModifyCondition())
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
