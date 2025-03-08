using DarkModeForms;
using QEMUInterface.Properties;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace QEMUInterface
{
    internal enum MACHINE_STATE
    {
        RUN,
        STOP,
        FAIL,
        NONE
    }


    public partial class WIN_MAIN : Form
    {
        private Loader loader;

        private int currentlySelectedMachine = -1;
        private int currentlySelectedMachineID = -9999;

        private List<VirtualMachine> machines = [];

        private DarkModeCS dm = null;
        private bool isDarkMode = false;

        public WIN_MAIN()
        {
            InitializeComponent();

            CheckDarkMode();

            loader = new Loader();

            machines = loader.populate();

            UpdateVMList();
        }

        private void CheckDarkMode()
        {
            if (Settings.Default.darkMode)
            {
                dm = new DarkModeCS(this)
                {
                    ColorMode = DarkModeCS.DisplayMode.DarkMode
                };
                isDarkMode = true;
            }
            else
            {
                isDarkMode = false;
            }
        }

        private void DisplayVM(VirtualMachine? vm)
        {
            if (vm == null)
            {
                b_machineSettings.Enabled = true;
                SetMachineState(MACHINE_STATE.NONE);
                return;
            }

            currentlySelectedMachineID = vm.ID;
            bool isRunning = vm.IsRunning();
            SetMachineState(isRunning ? MACHINE_STATE.RUN : MACHINE_STATE.STOP);
            
            t_machineName.Text = " " + vm.Name;
            t_machineOS.Text = " " + vm.OperatingSystem.FriendlyName;
            t_machineType.Text = " " + OperatingSystems.getFriendlyPCName(vm.PCType);
            l_machineSubversion.Visible = vm.OSSubversion != "";
            t_machineSubversion.Visible = vm.OSSubversion != "";
            t_machineSubversion.Text = " " + vm.OSSubversion;

            t_cpuCores.Text = " " + vm.CPUCoreCount.ToString();
            t_ram.Text = " " + vm.MemorySize.ToString() + "MB";

        }

        private void SetMachineState(MACHINE_STATE state)
        {
            switch (state)
            {
                case MACHINE_STATE.RUN:
                    b_startMachine.Visible = true;
                    b_machineSettings.Visible = true;
                    gb_machineState.Visible = true;

                    b_startMachine.Enabled = false;
                    b_machineSettings.Enabled = false;

                    b_startMachine.BackColor = Color.FromKnownColor(KnownColor.Control);
                    l_machineState.Text = "RUNNING";
                    l_machineState.ForeColor = Color.FromArgb(0, 192, 0);
                    break;
                case MACHINE_STATE.STOP:
                    b_startMachine.Visible = true;
                    b_machineSettings.Visible = true;
                    gb_machineState.Visible = true;

                    b_startMachine.Enabled = true;
                    b_machineSettings.Enabled = true;

                    b_startMachine.BackColor = Color.FromArgb(isDarkMode ? 64 : 128, isDarkMode ? 128 : 255, isDarkMode ? 64 : 128);
                    l_machineState.Text = "STOPPED";
                    l_machineState.ForeColor = Color.FromArgb(isDarkMode ? 255 : 192, 0, 0);
                    break;
                case MACHINE_STATE.NONE:
                    b_startMachine.Visible = false;
                    b_machineSettings.Visible = false;
                    gb_machineState.Visible = false;

                    b_startMachine.Enabled = false;
                    b_machineSettings.Enabled = false;

                    l_machineState.Text = "NONE";
                    l_machineState.ForeColor = Color.FromArgb(192, 192, 192);
                    break;
                default:
                    l_machineState.Text = "UNKNOWN";
                    l_machineState.ForeColor = Color.FromArgb(192, 192, 192);
                    break;
            }
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
                machines[i].EditControlOnExit(() =>
                {
                    SetMachineState(MACHINE_STATE.STOP);
                });
                machines[i].EditControlOnAbort(() =>
                {
                    SetMachineState(MACHINE_STATE.FAIL);
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
                DisplayVM(null);
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
