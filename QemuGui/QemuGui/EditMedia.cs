﻿using System;
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

        private bool isEditing = false;

        public WIN_MEDIA(VirtualMachine machine)
        {
            this.machine = machine;
            InitializeComponent();

            this.Text = "Edit Media - " + machine.Name;
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

        private void button1_Click(object sender, EventArgs e)
        {
            isEditing = true;
        }
    }
}
