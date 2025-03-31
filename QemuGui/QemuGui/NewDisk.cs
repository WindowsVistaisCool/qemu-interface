using DarkModeForms;

namespace QEMUInterface
{
    public partial class WIN_NewDisk : Form
    {
        private VirtualMachine machine;

        private string fileExt = ".qcow2";
        private bool isEditing = false;

        public WIN_NewDisk(VirtualMachine machine)
        {
            InitializeComponent();

            if (Properties.Settings.Default.darkMode)
            {
                _ = new DarkModeCS(this)
                {
                    ColorMode = DarkModeCS.DisplayMode.DarkMode,
                };
            }

            this.machine = machine;

            Text += machine.Name;

            num_size.Maximum = slider.Maximum;
            num_size.Minimum = slider.Minimum;
            num_size.Value = slider.Value;

            t_folder.Text = Path.GetDirectoryName(machine.FilePath);
            t_name.Text = "Disk 1";
        }

        private void WIN_NewDisk_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isEditing)
            {
                e.Cancel = true;
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit? All changes will be lost.", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    isEditing = false;
                    Close();
                }
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                isEditing = false;
            }

            if (!Directory.Exists(t_folder.Text))
            {
                MessageBox.Show("The path does not exist!.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isEditing = true;
                return;
            }

            if (File.Exists(Path.Combine(t_folder.Text, t_name.Text) + fileExt)) 
            {
                MessageBox.Show("The file already exists!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isEditing = true;
                return;
            }

            Close();
        }

        private void slider_Scroll(object sender, EventArgs e)
        {
            num_size.Value = slider.Value;
        }

        private void t_qemuPath_TextChanged(object sender, EventArgs e)
        {
            validateButton();
        }

        private void validateButton()
        {
            bool shouldEnable = true;

            if (t_name.Text.Length <= 0 && shouldEnable)
            {
                shouldEnable = false;
            }

            if (t_folder.Text.Length <= 0 && shouldEnable)
            {
                shouldEnable = false;
            }

            b_save.Enabled = shouldEnable;
        }
    }
}
