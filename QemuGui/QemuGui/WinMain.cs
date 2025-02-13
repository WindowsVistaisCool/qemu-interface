namespace QEMUInterface
{
    public partial class WinMain : Form
    {
        private int currentlySelectedMachine = -1;
        private int currentlySelectedMachineID = -1;

        private List<VirtualMachine> machines = [];

        public WinMain()
        {
            InitializeComponent();

            machines.Add(new VirtualMachine("Test"));
            machines.Add(new VirtualMachine("Test2"));

            for (int i = 0; i < machines.Count; i++)
            {
                machines[i].VerboseRunning = true;
                machines[i].ModifyCondition = () => currentlySelectedMachine == currentlySelectedMachineID;
                machines[i].EditControlOnExit(l_machineState, (c) =>
                {
                    c.Text = "STOPPED";
                    c.ForeColor = Color.FromArgb(192, 0, 0);
                });
                machines[i].EditControlOnExit(b_startMachine, (c) => c.Enabled = true);
            }

            currentlySelectedMachine = 0;
            DisplayVM(machines[currentlySelectedMachine]);
        }

        private void DisplayVM(VirtualMachine vm)
        {
            currentlySelectedMachineID = vm.ID;
            bool isRunning = vm.IsRunning();
            b_startMachine.Enabled = !isRunning;
            l_machineState.Text = isRunning ? "RUN" : "STOPPED";
            l_machineState.ForeColor = isRunning ? Color.FromArgb(0, 192, 0) : Color.FromArgb(192, 0, 0);

            l_machineName.Text = vm.Name;
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
            new WIN_NewMachine().ShowDialog();
        }

        private void b_startMachine_Click(object sender, EventArgs e)
        {
            VirtualMachine vm = machines[currentlySelectedMachine];

            vm.Run();
            DisplayVM(vm);
        }

        private void lv_vmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_vmList.SelectedIndices.Count == 0) return;
            currentlySelectedMachine = lv_vmList.SelectedIndices[0];
            DisplayVM(machines[currentlySelectedMachine]);
        }
    }
}
