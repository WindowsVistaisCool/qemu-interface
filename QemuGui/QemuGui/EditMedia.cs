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
    public partial class WIN_MEDIA : Form
    {
        private readonly VirtualMachine machine;

        public WIN_MEDIA(VirtualMachine machine)
        {
            this.machine = machine;
            InitializeComponent();

            this.Text = "Edit Media - " + machine.Name;
        }

        private void WIN_MEDIA_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
