using System.Collections.ObjectModel;
using System.Diagnostics;

namespace QEMUInterface
{
    public partial class WIN_MAIN : Form
    {
        private Loader loader;

        private int currentlySelectedMachine = -1;
        private int currentlySelectedMachineID = -9999;

        private List<VirtualMachine> machines = [];

        public WIN_MAIN()
        {
            InitializeComponent();

            loader = new Loader();

            machines = loader.populate();

            UpdateVMList();
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
            t_machineOS.Text = " " + vm.OperatingSystem.FriendlyName;
            t_machineType.Text = " " + vm.PCType.ToString();
            l_machineSubversion.Visible = vm.OSSubversion != "";
            t_machineSubversion.Visible = vm.OSSubversion != "";
            t_machineSubversion.Text = " " + vm.OSSubversion;

            t_cpuCores.Text = " " + vm.CPUCoreCount.ToString();
            t_ram.Text = " " + vm.MemorySize.ToString() + "MB";

        }

        private void LoadVMList()
        {
            for (int i = 0; i < machines.Count; i++)
            {
                ListViewItem lvi = new(machines[i].Name)
                {
                    ImageIndex = machines[i].OperatingSystem.ImageIndex
                };
                lvi.SubItems.Add(machines[i].OperatingSystem.FriendlyName);
                lvi.SubItems.Add(machines[i].ID.ToString());
                lv_vmList.Items.Add(lvi);
            }
        }

        private void UpdateVMList()
        {
            lv_vmList.Items.Clear();
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
                machines[i].EditControlOnAbort(() =>
                {
                    l_machineState.Text = "FAILED";
                    l_machineState.ForeColor = Color.FromArgb(96, 0, 0);
                    b_startMachine.Enabled = true;
                    b_startMachine.BackColor = Color.FromArgb(128, 255, 128);
                });
            }

            LoadVMList();
            if (machines.Count > 0)
            {
                currentlySelectedMachine = 0;
                currentlySelectedMachineID = machines[0].ID;
                DisplayVM(machines[currentlySelectedMachine]);
            }
            else
            {
                currentlySelectedMachine = -1;
                currentlySelectedMachineID = -9999;
                DisplayVM(new VirtualMachine());
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
            new WIN_NewMachine((vm) =>
            {
                //loader.storeVM(vm);
                machines.Add(vm);
                UpdateVMList();
            }).ShowDialog();
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

        private void ts_file_refresh_Click(object sender, EventArgs e)
        {
            machines = loader.populate();
            UpdateVMList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new WIN_MEDIA(machines[currentlySelectedMachine]).ShowDialog();
        }
    }
}
