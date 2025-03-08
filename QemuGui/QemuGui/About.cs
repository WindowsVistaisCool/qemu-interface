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
    public partial class WIN_ABOUT : Form
    {
        public WIN_ABOUT()
        {
            InitializeComponent();
            if (Properties.Settings.Default.darkMode)
            {
                _ = new DarkModeCS(this)
                {
                    ColorMode = DarkModeCS.DisplayMode.DarkMode,
                };
            }
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }
    }
}
