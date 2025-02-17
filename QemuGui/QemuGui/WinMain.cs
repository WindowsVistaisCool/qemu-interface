using System.Collections.ObjectModel;

namespace QEMUInterface
{
    public partial class WIN_MAIN : Form
    {
        private int currentlySelectedMachine = -1;
        private int currentlySelectedMachineID = -9999;

        private List<VirtualMachine> machines = [];

        public WIN_MAIN()
        {
            InitializeComponent();

            VirtualMachine vm1 = new VirtualMachine("Windows 10 Pro", 20);
            VirtualMachine vm2 = new VirtualMachine("Windows Vista Ultimate", 21);
            VirtualMachine ppc = new VirtualMachine("PUMA!!!", 22);

            vm1.OSFriendlyName = "Windows 10";
            vm2.OSFriendlyName = "Windows Vista";
            ppc.OSFriendlyName = "Mac OS X 10.1";

            vm1.VerboseRunning = true;
            vm2.VerboseRunning = true;

            ppc.SetPCType("qemu-system-ppc.exe");
            ppc.SetRunArguments("-L pc-bios -boot c -M mac99 -m 512 -drive file=C:\\Users\\windo\\macstuff\\Puma.img,format=raw,media=disk");

            machines.Add(vm1);
            machines.Add(vm2);
            machines.Add(ppc);

            for (int i = 0; i < machines.Count; i++)
            {
                machines[i].ControlModifyCondition = (id) => currentlySelectedMachineID == id;
                machines[i].EditControlOnExit(l_machineState, (c) =>
                {
                    c.Text = "STOPPED";
                    c.ForeColor = Color.FromArgb(192, 0, 0);
                });
                machines[i].EditControlOnExit(b_startMachine, (c) =>
                {
                    c.BackColor = Color.FromArgb(128, 255, 128);
                    c.Enabled = true;
                });
            }

            LoadVMList();
            currentlySelectedMachine = 0;
            DisplayVM(machines[currentlySelectedMachine]);
        }

        private void DisplayVM(VirtualMachine? vm)
        {

            if (vm == null)
            {
                b_machineSettings.Enabled = true;
                return;
            }

            currentlySelectedMachineID = vm.ID;
            bool isRunning = vm.IsRunning();
            b_startMachine.Enabled = !isRunning;
            b_machineSettings.Enabled = !isRunning;
            b_startMachine.BackColor = isRunning ? Color.FromKnownColor(KnownColor.Control) : Color.FromArgb(128, 255, 128);
            l_machineState.Text = isRunning ? "RUNNING" : "STOPPED";
            l_machineState.ForeColor = isRunning ? Color.FromArgb(0, 192, 0) : Color.FromArgb(192, 0, 0);

            t_machineName.Text = " " + vm.Name;
            t_machineOS.Text = " " + vm.OSFriendlyName;
        }

        private void LoadVMList()
        {
            for (int i = 0; i < machines.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(machines[i].Name);
                lvi.ImageIndex = 0;
                lvi.SubItems.Add(machines[i].OSFriendlyName);
                lvi.SubItems.Add(machines[i].ID.ToString());
                lv_vmList.Items.Add(lvi);
            }
        }

        private void ts_help_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Kyle Rush\nFebruary 2025", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ts_file_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ts_file_prefs_Click(object sender, EventArgs e)
        {
            new WIN_Prefs().ShowDialog();
        }

        private void b_newMachine_Click(object sender, EventArgs e)
        {
            new WIN_NewMachine((vm) => { }).ShowDialog();
        }

        private void b_startMachine_Click(object sender, EventArgs e)
        {
            VirtualMachine vm = machines[currentlySelectedMachine];

            vm.Run();
            DisplayVM(vm);
        }

        private void b_machineSettings_Click(object sender, EventArgs e)
        {
            new WIN_MachineSettings(machines[currentlySelectedMachine]).ShowDialog();
        }

        private void lv_vmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_vmList.SelectedIndices.Count == 0) return;
            currentlySelectedMachine = lv_vmList.SelectedIndices[0];
            DisplayVM(machines[currentlySelectedMachine]);

        }
    }
}
