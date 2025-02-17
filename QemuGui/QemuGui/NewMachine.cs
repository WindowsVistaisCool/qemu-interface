using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QEMUInterface
{
    public partial class WIN_NewMachine : Form
    {
        private readonly Action<VirtualMachine> actionCallback;

        private int currentTabPage = 0;
        private readonly int maxTabPage = 3;
        private bool isOnFinishTab = false;
        private bool closeInvokedByFinishButton = false;

        private readonly Dictionary<RadioButton, OS_FAMILY> osRadioButtons;

        private PC_TYPE selectedMachineType = PC_TYPE.X86_64;
        private OS_FAMILY selectedFamily = OS_FAMILY.WINDOWS;
        private OperatingSystem selectedOS = OperatingSystems.WINDOWS_11;

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
            checkNextButtonEnabled(null, null);
        }

        private void onLoadPageEvents()
        {
            switch (currentTabPage)
            {
                case 0:
                    break;
                case 1:
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
                    break;
            }
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
            cb_p1_version.Items.AddRange(OperatingSystems.getFriendlyNamesFromFamily(selectedFamily));
            cb_p1_version.Text = selectedOS.Name;
        }

        private void loadOSMinorVersions(object? sender, EventArgs? e)
        {
            cb_p1_subversion.Text = "";
            cb_p1_subversion.Items.Clear();
            cb_p1_subversion.Enabled = false;

            try
            {
                selectedOS = OperatingSystems.get(cb_p1_version.Text);
            } catch (InvalidOperationException)
            {
                return;
            }

            if (selectedOS.MinorVers.Length > 0)
            {
                cb_p1_subversion.Items.AddRange(selectedOS.MinorVers);
                cb_p1_subversion.Text = selectedOS.MinorVers[0];
                cb_p1_subversion.Enabled = true;
            }
        }

        private void updatePanel()
        {
            p0.Visible = currentTabPage == 0;
            p1.Visible = currentTabPage == 1;
            p_diskPage.Visible = currentTabPage == 2;
            p_finishPage.Visible = currentTabPage == 3;
        }

        private void checkNextButtonEnabled(object sender, EventArgs e)
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
                    break;
                case 2:
                    isEnabled = true;
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

            onLoadPageEvents();
        }


        private void rb_p0_emType_other_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_p0_emType_other.Checked)
            {
                rb_p0_emType_PPC.Checked = false;
                rb_p0_emType_x86.Checked = false;
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
    }
}
