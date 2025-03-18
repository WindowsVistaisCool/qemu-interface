using DarkModeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QEMUInterface
{
    public partial class WIN_NewDisk: Form
    {
        private VirtualMachine machine;

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
        }

        private void WIN_MEDIA_FormClosing(object sender, FormClosingEventArgs e)
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
            Close();
        }
    }
}
