using DarkModeForms;
using QEMUInterface.Properties;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace QEMUInterface
{
    public enum MACHINE_STATE
    {
        RUN,
        STOP,
        FAIL,
        NONE
    }

    public partial class WIN_MAIN : Form
    {
        private readonly Loader loader;

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
            t_machineType.Text = " " + QemuMachines.getFriendlyPCName(vm.PCType);
            l_machineSubversion.Visible = vm.OSSubversion != "";
            t_machineSubversion.Visible = vm.OSSubversion != "";
            t_machineSubversion.Text = " " + vm.OSSubversion;

            t_cpuCores.Text = " " + vm.CPUCoreCount.ToString();
            t_ram.Text = " " + vm.MemorySize.ToString() + "MB";

        }

        private TSMCollection SetMachineState(MACHINE_STATE state, bool isSafe)
        {
            List<IThreadSafeModification> modifications = [];
            switch (state)
            {
                case MACHINE_STATE.RUN:
                    modifications = [
                        new ThreadSafeModification<Button>(b_startMachine, (c) =>
                        {
                            c.Visible = true;
                            c.Enabled = false;
                            c.BackColor = Color.FromKnownColor(KnownColor.Control);
                        }),
                        new ThreadSafeModification<Button>(b_machineSettings, (c) =>
                        {
                            c.Visible = true;
                            c.Enabled = false;
                        }),
                        TSMPresets.SetVisible(gb_machineDetails, true),
                        new ThreadSafeModification<Label>(l_machineState, (c) => {
                            c.Text = "RUNNING";
                            c.ForeColor = Color.FromArgb(0, 192, 0);
                        }),
                    ];
                    break;
                case MACHINE_STATE.STOP:
                    modifications = [
                        new ThreadSafeModification<Button>(b_startMachine, (c) =>
                        {
                            c.Visible = true;
                            c.Enabled = true;
                            c.BackColor = Color.FromArgb(isDarkMode ? 64 : 128, isDarkMode ? 128 : 255, isDarkMode ? 64 : 128);;
                        }),
                        new ThreadSafeModification<Button>(b_machineSettings, (c) =>
                        {
                            c.Visible = true;
                            c.Enabled = true;
                        }),
                        TSMPresets.SetVisible(gb_machineDetails, true),
                        new ThreadSafeModification<Label>(l_machineState, (c) => {
                            c.Text = "STOPPED";
                            c.ForeColor = Color.FromArgb(isDarkMode ? 255 : 192, 0, 0);
                        }),
                    ];
                    break;
                case MACHINE_STATE.FAIL:
                    modifications = [
                        new ThreadSafeModification<Button>(b_startMachine, (c) =>
                        {
                            c.Visible = true;
                            c.Enabled = true;
                            c.BackColor = Color.FromArgb(isDarkMode ? 64 : 128, isDarkMode ? 128 : 255, isDarkMode ? 64 : 128);;
                        }),
                        new ThreadSafeModification<Button>(b_machineSettings, (c) =>
                        {
                            c.Visible = true;
                            c.Enabled = true;
                        }),
                        TSMPresets.SetVisible(gb_machineDetails, true),
                        new ThreadSafeModification<Label>(l_machineState, (c) => {
                            c.Text = "FAILED";
                            c.ForeColor = Color.FromArgb(isDarkMode ? 255 : 192, 0, 0);
                        }),
                    ];
                    break;
                case MACHINE_STATE.NONE:
                    modifications = [
                        new ThreadSafeModification<Button>(b_startMachine, (c) =>
                        {
                            c.Visible = false;
                            c.Enabled = false;
                            c.BackColor = Color.FromArgb(isDarkMode ? 64 : 128, isDarkMode ? 128 : 255, isDarkMode ? 64 : 128);;
                        }),
                        new ThreadSafeModification<Button>(b_machineSettings, (c) =>
                        {
                            c.Visible = false;
                            c.Enabled = false;
                        }),
                        TSMPresets.SetVisible(gb_machineDetails, false),
                        new ThreadSafeModification<Label>(l_machineState, (c) => {
                            c.Text = "NONE";
                            c.ForeColor = Color.FromArgb(192, 192, 192);
                        }),
                    ];
                    break;
                default:
                    modifications.Add(new ThreadSafeModification<Label>(l_machineState, (c) =>
                    {
                        c.Text = "UNKNOWN";
                        c.ForeColor = Color.FromArgb(192, 192, 192);
                    }));
                    break;
            }
            return new TSMCollection(modifications);
        }
        private void SetMachineState(MACHINE_STATE state)
        {
            // main thread, no safety needed so we just run the modifer without checking invocation
            SetMachineState(state, true).ApplyUnsafe();
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
                machines[i].EditControlOnExit(() => SetMachineState(MACHINE_STATE.STOP, true).Apply());
                machines[i].EditControlOnAbort(() => SetMachineState(MACHINE_STATE.FAIL, true).Apply());
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
            new WIN_ABOUT().ShowDialog();
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
            VirtualMachine? newVm = null;
            new WIN_NewMachine((vm) =>
            {
                //loader.storeVM(vm);
                newVm = vm;
                machines.Add(vm);
                UpdateVMList();
            }).ShowDialog();
            if (newVm != null)
            {
                new WIN_MEDIA(newVm!).ShowDialog();
            }
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
