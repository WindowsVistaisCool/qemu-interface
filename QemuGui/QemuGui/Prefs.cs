using DarkModeForms;
using QEMUInterface.Properties;

namespace QEMUInterface
{
    public partial class WIN_Prefs : Form
    {
        private bool hasUnsavedChanges = false;
        private bool finishedInit = false;
        private bool cancelFormClosing = false;
        private bool needsRepainting = false;

        public WIN_Prefs()
        {

            InitializeComponent();

            if (Settings.Default.darkMode)
            {
                _ = new DarkModeCS(this)
                {
                    ColorMode = DarkModeCS.DisplayMode.DarkMode
                };
            }

            rb_theme_light.Checked = !Settings.Default.darkMode;
            rb_theme_dark.Checked = Settings.Default.darkMode;
            needsRepainting = false;
        }

        private void b_selFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd_vmFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                t_vmFolder.Text = fbd_vmFolder.SelectedPath;
            }
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            Settings.Default.Reload();

            if (Settings.Default.vmFolder != null)
            {
                t_vmFolder.Text = Properties.Settings.Default.vmFolder;
            }

            if (Settings.Default.qemuFolder != null)
            {
                t_qemuPath.Text = Properties.Settings.Default.qemuFolder;
            }

            finishedInit = true;
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            // Validate path
            if (!Directory.Exists(t_vmFolder.Text))
            {
                MessageBox.Show("The VM path does not exist!.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cancelFormClosing = true;
                return;
            }

            if (!Directory.Exists(t_qemuPath.Text))
            {
                MessageBox.Show("The QEMU path does not exist!.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cancelFormClosing = true;
                return;
            }

            Settings.Default.vmFolder = t_vmFolder.Text;
            Settings.Default.qemuFolder = t_qemuPath.Text;
            Settings.Default.darkMode = rb_theme_dark.Checked;
            Settings.Default.Save();

            if (needsRepainting)
            {
                MessageBox.Show("The new theme will be applied after you restart QEMUInterface.", "Theme Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            if (!hasUnsavedChanges)
            {
                this.Close();
                return;
            }
            DialogResult result = MessageBox.Show("You have unsaved changes. Are you sure you want to exit?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                cancelFormClosing = true;
                return;
            }
            this.Close();
        }

        private void setUnsavedChanges(object sender, EventArgs e)
        {
            if (finishedInit)
            {
                hasUnsavedChanges = true;
            }
        }

        private void Preferences_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelFormClosing)
            {
                e.Cancel = true;
                cancelFormClosing = false;
            }
        }

        private void b_selqemuFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd_qemuFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                t_qemuPath.Text = fbd_qemuFolder.SelectedPath;
            }
        }

        private void triggerRepaintFlag(object sender, EventArgs e)
        {
            needsRepainting = true;
        }
    }
}
