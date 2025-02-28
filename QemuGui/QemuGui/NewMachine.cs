using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QEMUInterface
{
    public partial class WIN_NewMachine : Form
    {
        private readonly Action<VirtualMachine> actionCallback;

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
            actionCallback = newVMCallback;

            InitializeComponent();

            osRadioButtons = new Dictionary<RadioButton, OS_FAMILY>
            {
                { rb_p1_os_win, OS_FAMILY.WINDOWS },
                { rb_p1_os_mac, OS_FAMILY.MACOS },
                { rb_p1_os_linux, OS_FAMILY.LINUX }
            };

            updatePanel();
            loadOSVersions(null, null);
            onLoadPageEvents();
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
                    lv_p2_type.Items.Clear();
                    machineListPopulated = null;

                    string param = "$ex = '" + OperatingSystems.getQemuCmd(selectedMachineType) + " -machine help';";
                    string regex = @"^\s*(?<Name>[^\s]+)\s+(?<Desc>.+)$";
                    string script = param + @"
                        $f = $false;
                        $(Invoke-Expression $ex) -split '\r?\n' | Select-Object -Skip 1 | ForEach-Object {
                            if ($_ -match 'Recognized CPUID flags:') {
                                $f = $true;
                            }
                            if ($f -eq $false -and $_ -match 'REGEX_GOES_HERE') {
                                Write-Host $Matches['Name']','$Matches['Desc'];
                            }
                        }
                    ".Replace("REGEX_GOES_HERE", regex);
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "powershell.exe",
                        Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{script}\"",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    Process process = new Process { StartInfo = psi };

                    process.Start();
                    process.EnableRaisingEvents = true;
                    while (!process.StandardOutput.EndOfStream)
                    {
                        try
                        {
                            string[] line = process.StandardOutput.ReadLine().Split(" , ");
                            ListViewItem lvi = new(line[0]);
                            lvi.SubItems.Add(line[1]);
                            lv_p2_type.Items.Add(lvi);
                        } catch (Exception e)
                        {
                            MessageBox.Show("ERR: " + e);
                        }
                    }

                    if (lv_p2_type.Items.Count > 0)
                    {
                        machineListPopulated = selectedMachineType;
                    }

                    lv_p2_type_machine.Width = -2;
                    lv_p2_type_machine.Width += 2;
                    lv_p2_type_desc.Width = -2;
                    break;
                case 3:
                    // store from page 2 if needed
                    if (l_pfin_machine.Text != lv_p2_type.SelectedItems[0].Text)
                    {
                        l_pfin_machine.Text = lv_p2_type.SelectedItems[0].Text;
                    }

                    cb_p3_cpuType.Text = "CPU TYPE 1";
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
            p1.Visible = currentTabPage == 1;
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

            actionCallback(null);
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
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
                rb_p0_emType_PPC.Checked = false;
                rb_p0_emType_x86.Checked = false;
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

        private void tb_p3_cores_Scroll(object sender, EventArgs e)
        {
            num_p3_cores.Value = slider_p3_cores.Value;
        }

        private void num_p3_cores_ValueChanged(object sender, EventArgs e)
        {
            slider_p3_cores.Value = (int)num_p3_cores.Value;
        }

        private void rb_p0_emType_m68k_CheckedChanged(object sender, EventArgs e)
        {
            selectedMachineType = PC_TYPE.M68K;
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
