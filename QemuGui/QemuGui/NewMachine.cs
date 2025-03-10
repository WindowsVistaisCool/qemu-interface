using DarkModeForms;
using System.Diagnostics;

namespace QEMUInterface
{
    public partial class WIN_NewMachine : Form
    {
        private readonly Action<VirtualMachine> vmReturner;

        private int currentTabPage = 0;
        private readonly int maxTabPage = 4;
        private bool isOnFinishTab = false;
        private bool closeInvokedByFinishButton = false;

        private readonly Dictionary<RadioButton, OS_FAMILY> osRadioButtons;

        private PC_TYPE selectedMachineType = PC_TYPE.X86_64;
        private PC_TYPE? machineListPopulated = null;
        private OS_FAMILY selectedFamily = OS_FAMILY.WINDOWS;
        private OperatingSystem selectedOS = OperatingSystems.get("Windows 11");

        public WIN_NewMachine(Action<VirtualMachine> newVMCallback)
        {
            vmReturner = newVMCallback;

            InitializeComponent();

            if (Properties.Settings.Default.darkMode)
            {
                _ = new DarkModeCS(this)
                {
                    ColorMode = DarkModeCS.DisplayMode.DarkMode,
                };
                //MessageBox.Show("This window is not well optimized for dark mode!\n\nUse the preferences menu to switch back to light if you experience issues.", "Dark Mode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            osRadioButtons = new Dictionary<RadioButton, OS_FAMILY>
            {
                { rb_p1_os_win, OS_FAMILY.WINDOWS },
                { rb_p1_os_mac, OS_FAMILY.MACOS },
                { rb_p1_os_linux, OS_FAMILY.LINUX }
            };

            updatePanel();
            loadOSVersions(null, null);
            onLoadPageEvents();

            // find max cpu cores
            int maxCores = Environment.ProcessorCount;
            slider_p3_cores.Maximum = maxCores;
            num_p3_cores.Maximum = maxCores;
            
            // find ram of the system
            ulong ramMB = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024);
            l_p3_ramBoundaryRight.Text = (ramMB / 1024).ToString() + " GB";
            slider_p3_ram.Maximum = (int)ramMB;
            num_p3_ram.Maximum = (int)ramMB;

            //checkNextButtonEnabled(null, null);
        }

        private void onLoadPageEvents()
        {
            switch (currentTabPage)
            {
                case 0:
                    break;
                case 1:
                    // store from page 0 if needed
                    if (l_pfin_name.Text != t_p0_name.Text)
                    {
                        l_pfin_name.Text = t_p0_name.Text;
                    }
                    if (l_pfin_emType.Text != selectedMachineType.ToString())
                    {
                        l_pfin_emType.Text = selectedMachineType.ToString();
                    }


                    // load page events
                    bool selectedFirstRadio = false;
                    foreach (KeyValuePair<RadioButton, OS_FAMILY> entry in osRadioButtons)
                    {
                        entry.Key.Enabled = OperatingSystems.anyInFamilyCompatability(entry.Value, selectedMachineType);
                        if (entry.Key.Enabled && !selectedFirstRadio)
                        {
                            entry.Key.Checked = true;
                            selectedFirstRadio = true;
                        }
                    }
                    flp_p1_bitness.Enabled = selectedMachineType == PC_TYPE.X86_64;
                    l_p1_bitness.Enabled = selectedMachineType == PC_TYPE.X86_64;
                    rb_p1_bitness_64.Checked = selectedMachineType == PC_TYPE.X86_64;
                    if (selectedMachineType != PC_TYPE.X86_64)
                    {
                        rb_p1_bitness_32.Checked = false;
                        rb_p1_bitness_64.Checked = false;
                    }
                    loadOSVersions(null, null);
                    loadOSMinorVersions(null, null);
                    break;
                case 2:
                    // store from page 1 if needed
                    if (l_pfin_os.Text != selectedOS.FriendlyName)
                    {
                        l_pfin_os.Text = selectedOS.FriendlyName;
                    }

                    // load page events
                    if (machineListPopulated == selectedMachineType)
                    {
                        break;
                    }

                    // clear listview
                    lv_p2_type.Visible = false;
                    lv_p2_type.Items.Clear();
                    machineListPopulated = null;

                    // start asnyc load
                    progressBarGeneric.Visible = true;
                    progressBarGeneric.Value = 1;

                    QemuMachines.getPCTypesAsync(selectedMachineType, (machines) =>
                    {
                        List<ListViewItem> items = [];
                        foreach (string[] output in machines)
                        {
                            ListViewItem lvi = new(output[0]);
                            lvi.SubItems.Add(output[1]);
                            items.Add(lvi);
                        }


                        new ThreadSafeModification<ListView>(lv_p2_type, (c) =>
                        {
                            c.Visible = true;
                            items.ForEach(item => c.Items.Add(item));

                            lv_p2_type_machine.Width = -2;
                            lv_p2_type_machine.Width += 2;
                            lv_p2_type_desc.Width = -2;
                        }).Apply();
                        TSMPresets.SetVisible(progressBarGeneric, false).Apply();

                        machineListPopulated = lv_p2_type.Items.Count > 0 ? selectedMachineType : null;
                    });
                    break;
                case 3:
                    // store from page 2 if needed
                    if (l_pfin_machine.Text != lv_p2_type.SelectedItems[0].Text)
                    {
                        l_pfin_machine.Text = lv_p2_type.SelectedItems[0].Text;
                    }

                    // load graphics options
                    cb_p3_graphics.Items.Clear();
                    foreach (GRAPHICS_TYPE gType in Enum.GetValues(typeof(GRAPHICS_TYPE)))
                    {
                        cb_p3_graphics.Items.Add(gType.ToString());
                        cb_p3_graphics.Text = GRAPHICS_TYPE.STD.ToString();
                    }

                    cb_p3_audio.Text = "";
                    cb_p3_audio.Items.Clear();
                    progressBarGeneric.Visible = true;
                    cb_p3_audio.Enabled = false;
                    // load audio options
                    QemuMachines.getAudioTypesAsync(selectedMachineType, (audioTypes) =>
                    {
                        new ThreadSafeModification<ComboBox>(cb_p3_audio, (c) =>
                        {
                            audioTypes.ForEach((i) => c.Items.Add(i));
                            c.Text = audioTypes.Count > 0 ? audioTypes[0] : "";
                            c.Enabled = true;
                        }).Apply();
                        TSMPresets.SetVisible(progressBarGeneric, false).Apply();
                    });

                    //cb_p3_cpuType.Text = "CPU TYPE 1";
                    break;
                case 4:
                    // store from page 3 if needed
                    if (l_pfin_cpu.Text != num_p3_cores.Value.ToString())
                    {
                        l_pfin_cpu.Text = num_p3_cores.Value.ToString();
                    }
                    if (l_pfin_ram.Text != num_p3_ram.Value.ToString() + " MB")
                    {
                        l_pfin_ram.Text = num_p3_ram.Value.ToString() + " MB";
                    }
                    break;
                default:
                    break;
            }
            checkNextButtonEnabled(null, null);
        }

        private void loadOSVersions(object? sender, EventArgs? e)
        {
            foreach (RadioButton rb in osRadioButtons.Keys)
            {
                if (rb.Checked)
                {
                    _ = Enum.TryParse(rb.Text.ToUpper(), out OS_FAMILY family);
                    selectedFamily = family;
                    selectedOS = OperatingSystems.getFamily(selectedFamily)[0];
                    break;
                }
            }

            cb_p1_version.Items.Clear();
            cb_p1_version.Items.AddRange(OperatingSystems.getFriendlyNamesFromFamilyWithCompatability(selectedFamily, selectedMachineType));
            if (cb_p1_version.Items.Count > 0)
            {
                cb_p1_version.Text = cb_p1_version.Items[0]!.ToString();
            }
        }

        private void loadOSMinorVersions(object? sender, EventArgs? e)
        {
            cb_p1_subversion.Text = "";
            cb_p1_subversion.Items.Clear();
            cb_p1_subversion.Enabled = false;
            l_p1_subversion.Enabled = false;

            try
            {
                selectedOS = OperatingSystems.getByFriendlyName(cb_p1_version.Text);
            }
            catch (InvalidOperationException)
            {
                return;
            }

            if (selectedMachineType == PC_TYPE.X86_64)
            {
                rb_p1_bitness_32.Enabled = selectedOS.Bitness[0];
                rb_p1_bitness_64.Enabled = selectedOS.Bitness[1];
                if (selectedOS.Bitness[1])
                {
                    rb_p1_bitness_32.Checked = false;
                    rb_p1_bitness_64.Checked = selectedOS.Bitness[1]; // Should always be true
                }
                else
                {
                    rb_p1_bitness_32.Checked = selectedOS.Bitness[0]; // Should always be true
                    rb_p1_bitness_64.Checked = false;
                }
            }
            else if (selectedMachineType == PC_TYPE.IA_32)
            {
                rb_p1_bitness_32.Checked = true;
                rb_p1_bitness_64.Checked = false;
            }

            if (selectedOS.MinorVers.Length > 0)
            {
                cb_p1_subversion.Items.AddRange(selectedOS.MinorVers);
                cb_p1_subversion.Text = selectedOS.MinorVers[0];
                cb_p1_subversion.Enabled = true;
                l_p1_subversion.Enabled = true;
            }
        }

        private void updatePanel()
        {
            p0.Visible = currentTabPage == 0;
            p1_os.Visible = currentTabPage == 1;
            p2_pcType.Visible = currentTabPage == 2;
            p3_hardware.Visible = currentTabPage == 3;
            pfin.Visible = currentTabPage == maxTabPage;
        }

        private void checkNextButtonEnabled(object? sender, EventArgs? e)
        {
            bool isEnabled = false;
            switch (currentTabPage)
            {
                case 0:
                    isEnabled = t_p0_name.Text.Length > 0;

                    if (rb_p0_emType_other.Checked && isEnabled)
                    {
                        isEnabled = cb_p0_otherEm.Text.Length > 0;
                    }
                    break;
                case 1:
                    isEnabled = true;

                    //if (selectedMachineType == PC_TYPE.X86_64)
                    //{
                    //    // radiobutton validation events
                    //    if ((!rb_p1_bitness_32.Checked && !rb_p1_bitness_64.Checked) || (rb_p1_bitness_32.Checked && !selectedOS.Bitness[0]) || (rb_p1_bitness_64.Checked && !selectedOS.Bitness[1]))
                    //    {
                    //        isEnabled = false;
                    //    }
                    //}

                    //if (cb_p1_version.Text.Length == 0)
                    //{
                    //    isEnabled = false;
                    //}

                    break;
                case 2:
                    isEnabled = lv_p2_type.SelectedItems.Count == 1;
                    break;
                case 3:
                    isEnabled = true;
                    break;
                case 4:
                    isEnabled = true;
                    break;
                default:
                    break;
            }
            b_next.Enabled = isEnabled;
        }

        private void WIN_NewMachine_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOnFinishTab && closeInvokedByFinishButton)
            {
                e.Cancel = true;
                closeInvokedByFinishButton = false;
                return;
            }

            if (isOnFinishTab && closeInvokedByFinishButton)
            {
                closeInvokedByFinishButton = false;
                VirtualMachine vm = new()
                {
                    Name = t_p0_name.Text,
                    PCType = selectedMachineType,
                    OperatingSystem = selectedOS,
                    Machine = lv_p2_type.SelectedItems[0].Text,
                    OSSubversion = cb_p1_subversion.Text,
                    CPUCoreCount = (int)num_p3_cores.Value,
                    MemorySize = (int)num_p3_ram.Value,
                    GraphicsType = (GRAPHICS_TYPE)Enum.Parse(typeof(GRAPHICS_TYPE), cb_p3_graphics.Text),
                    AudioType = cb_p3_audio.Text,
                };

                vmReturner(vm);
            }

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            if (currentTabPage > 0)
            {
                DialogResult r = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.No)
                {
                    closeInvokedByFinishButton = true;
                    return;
                }
            }
            Close();
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            if (currentTabPage <= 0)
            {
                return;
            }

            currentTabPage--;
            updatePanel();

            if (isOnFinishTab)
            {
                isOnFinishTab = false;
                b_next.Text = "Next >";
            }


            if (currentTabPage == 0)
            {
                b_back.Enabled = false;
            }

            b_next.Enabled = false;

            onLoadPageEvents();
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            if (isOnFinishTab)
            {
                closeInvokedByFinishButton = true;
                Close();
                return;
            }
            currentTabPage++;
            b_back.Enabled = true;
            updatePanel();

            if (currentTabPage >= maxTabPage)
            {
                isOnFinishTab = true;
                b_next.Text = "Finish";
            }

            b_next.Enabled = false;

            onLoadPageEvents();
        }


        private void rb_p0_emType_other_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_p0_emType_other.Checked)
            {
                rb_p0_emType_x86.Checked = false;
                rb_p0_emType_i386.Checked = false;
                rb_p0_emType_PPC.Checked = false;
                rb_p0_emType_m68k.Checked = false;
                selectedMachineType = PC_TYPE.OTHER;
            }
        }

        private void cb_p0_otherEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = Enum.TryParse(cb_p0_otherEm.Text.ToUpper(), out PC_TYPE type);
            selectedMachineType = type;
            checkNextButtonEnabled(sender, e);
        }

        private void rb_p0_emType_x86_CheckedChanged(object sender, EventArgs e)
        {
            selectedMachineType = PC_TYPE.X86_64;
        }

        private void rb_p0_emType_PPC_CheckedChanged(object sender, EventArgs e)
        {
            selectedMachineType = PC_TYPE.PPC;
        }
        private void rb_p0_emType_m68k_CheckedChanged(object sender, EventArgs e)
        {
            selectedMachineType = PC_TYPE.M68K;
        }
        private void rb_p0_emType_i386_CheckedChanged(object sender, EventArgs e)
        {
            selectedMachineType = PC_TYPE.IA_32;
        }

        private void tb_p3_cores_Scroll(object sender, EventArgs e)
        {
            num_p3_cores.Value = slider_p3_cores.Value;
        }

        private void num_p3_cores_ValueChanged(object sender, EventArgs e)
        {
            slider_p3_cores.Value = (int)num_p3_cores.Value;
        }

        private void num_p3_ram_ValueChanged(object sender, EventArgs e)
        {
            slider_p3_ram.Value = (int)num_p3_ram.Value;
        }

        private void slider_p3_ram_Scroll(object sender, EventArgs e)
        {
            num_p3_ram.Value = slider_p3_ram.Value;
        }

    }
}
