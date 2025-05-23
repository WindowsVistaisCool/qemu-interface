﻿using DarkModeForms;
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

        private bool isEditing = false;

        public WIN_MEDIA(VirtualMachine machine)
        {
            this.machine = machine;
            InitializeComponent();

            if (Properties.Settings.Default.darkMode)
            {
                _ = new DarkModeCS(this)
                {
                    ColorMode = DarkModeCS.DisplayMode.DarkMode,
                };
            }

            Text += machine.Name;

            Populate(null, null);
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
                DialogResult result = MessageBox.Show("Are you sure you want to exit? All changes will be lost.", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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

        private void Populate(object? sender, EventArgs? e)
        {
            tv_main.Nodes.Clear();
            TreeNode hdd = new()
            {
                Name = "tvn_hdd",
                Text = "Hard Disks",
                ImageIndex = 0,
            };

            TreeNode cdrom = new()
            {
                Name = "tvn_cdrom",
                Text = "CD ROMs",
                ImageIndex = 1,
            };

            TreeNode floppy = new()
            {
                Name = "tvn_floppy",
                Text = "Floppy Drives",
                ImageIndex = 2,
            };

            var vmData = machine.Media;

            foreach (var media in vmData) {
                try
                {
                    if (((MEDIA_TYPE)media["Type"]) == MEDIA_TYPE.HDD)
                    {
                        hdd.Nodes.Add(new TreeNode
                        {
                            Name = "tvn_hdd_" + media["Name"],
                            Text = media["Name"].ToString(),
                        });
                    }
                } catch (Exception)
                {

                }
            }

            tv_main.Nodes.Add(hdd);
            tv_main.Nodes.Add(cdrom);
            tv_main.Nodes.Add(floppy);
            tv_main.ExpandAll();
        }

        private void b_newDisk_Click(object sender, EventArgs e)
        {
            new WIN_NewDisk(machine).ShowDialog();
            Populate(null, null);
        }
    }
}
