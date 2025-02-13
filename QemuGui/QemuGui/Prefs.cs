using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QEMUInterface
{
    public partial class WIN_Prefs : Form
    {

        bool hasUnsavedChanges = false;
        bool finishedInit = false;
        bool cancelFormClosing = false;

        public WIN_Prefs()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            Properties.Settings.Default.Reload();

            if (Properties.Settings.Default.vmFolder != null)
            {
                t_vmFolder.Text = Properties.Settings.Default.vmFolder;
            }

            finishedInit = true;
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            // Validate path
            if (!System.IO.Directory.Exists(t_vmFolder.Text))
            {
                MessageBox.Show("The VM path does not exist!.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cancelFormClosing = true;
                return;
            }

            Properties.Settings.Default.vmFolder = t_vmFolder.Text;
            Properties.Settings.Default.Save();

            this.Close();
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

        private void t_vmFolder_TextChanged(object sender, EventArgs e)
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
    }
}
