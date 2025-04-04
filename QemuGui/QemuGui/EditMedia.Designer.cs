﻿namespace QEMUInterface
{
    partial class WIN_MEDIA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Panel p_main;
            TreeNode treeNode3 = new TreeNode("Hard Disks");
            TreeNode treeNode4 = new TreeNode("CD ROMS");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_MEDIA));
            tlp_main = new TableLayoutPanel();
            b_newDisk = new Button();
            tv_main = new TreeView();
            il_tree = new ImageList(components);
            label1 = new Label();
            flp_bottom = new FlowLayoutPanel();
            b_cancel = new Button();
            b_save = new Button();
            p_main = new Panel();
            p_main.SuspendLayout();
            tlp_main.SuspendLayout();
            flp_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // p_main
            // 
            p_main.Controls.Add(tlp_main);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(3);
            p_main.Size = new Size(388, 377);
            p_main.TabIndex = 4;
            // 
            // tlp_main
            // 
            tlp_main.ColumnCount = 1;
            tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp_main.Controls.Add(b_newDisk, 0, 2);
            tlp_main.Controls.Add(tv_main, 0, 1);
            tlp_main.Controls.Add(label1, 0, 0);
            tlp_main.Dock = DockStyle.Fill;
            tlp_main.Location = new Point(3, 3);
            tlp_main.Name = "tlp_main";
            tlp_main.RowCount = 3;
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 9.834304F));
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 74.39353F));
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9029646F));
            tlp_main.Size = new Size(382, 371);
            tlp_main.TabIndex = 0;
            // 
            // b_newDisk
            // 
            b_newDisk.Anchor = AnchorStyles.Top;
            b_newDisk.Location = new Point(108, 314);
            b_newDisk.Name = "b_newDisk";
            b_newDisk.Size = new Size(166, 46);
            b_newDisk.TabIndex = 2;
            b_newDisk.Text = "Add New HDD";
            b_newDisk.UseVisualStyleBackColor = true;
            b_newDisk.Click += b_newDisk_Click;
            // 
            // tv_main
            // 
            tv_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tv_main.FullRowSelect = true;
            tv_main.ImageIndex = 0;
            tv_main.ImageList = il_tree;
            tv_main.Location = new Point(20, 59);
            tv_main.Margin = new Padding(20, 23, 20, 23);
            tv_main.Name = "tv_main";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "tvn_hdd";
            treeNode3.Text = "Hard Disks";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "tvn_cdrom";
            treeNode4.Text = "CD ROMS";
            tv_main.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode4 });
            tv_main.SelectedImageIndex = 0;
            tv_main.Size = new Size(342, 229);
            tv_main.TabIndex = 3;
            // 
            // il_tree
            // 
            il_tree.ColorDepth = ColorDepth.Depth32Bit;
            il_tree.ImageStream = (ImageListStreamer)resources.GetObject("il_tree.ImageStream");
            il_tree.TransparentColor = Color.Transparent;
            il_tree.Images.SetKeyName(0, "HardDrive.png");
            il_tree.Images.SetKeyName(1, "CDDrive.png");
            il_tree.Images.SetKeyName(2, "FloppyDrive.png");
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(376, 17);
            label1.TabIndex = 4;
            label1.Text = "Devices";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flp_bottom
            // 
            flp_bottom.AutoSize = true;
            flp_bottom.BackColor = SystemColors.ControlLight;
            flp_bottom.Controls.Add(b_cancel);
            flp_bottom.Controls.Add(b_save);
            flp_bottom.Dock = DockStyle.Bottom;
            flp_bottom.FlowDirection = FlowDirection.RightToLeft;
            flp_bottom.Location = new Point(0, 377);
            flp_bottom.Name = "flp_bottom";
            flp_bottom.Size = new Size(388, 49);
            flp_bottom.TabIndex = 3;
            // 
            // b_cancel
            // 
            b_cancel.BackColor = SystemColors.Control;
            b_cancel.BackgroundImageLayout = ImageLayout.None;
            b_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            b_cancel.FlatStyle = FlatStyle.System;
            b_cancel.Location = new Point(292, 10);
            b_cancel.Margin = new Padding(5, 10, 10, 10);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(86, 29);
            b_cancel.TabIndex = 1;
            b_cancel.Text = "Cancel";
            b_cancel.UseVisualStyleBackColor = false;
            b_cancel.Click += b_cancel_Click;
            // 
            // b_save
            // 
            b_save.BackColor = SystemColors.Control;
            b_save.BackgroundImageLayout = ImageLayout.None;
            b_save.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            b_save.FlatStyle = FlatStyle.System;
            b_save.Location = new Point(196, 10);
            b_save.Margin = new Padding(5, 10, 5, 10);
            b_save.Name = "b_save";
            b_save.Size = new Size(86, 29);
            b_save.TabIndex = 0;
            b_save.Text = "Save";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // WIN_MEDIA
            // 
            AcceptButton = b_save;
            AutoScaleMode = AutoScaleMode.Inherit;
            CancelButton = b_cancel;
            ClientSize = new Size(388, 426);
            Controls.Add(p_main);
            Controls.Add(flp_bottom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WIN_MEDIA";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Media - ";
            FormClosing += WIN_MEDIA_FormClosing;
            p_main.ResumeLayout(false);
            tlp_main.ResumeLayout(false);
            tlp_main.PerformLayout();
            flp_bottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_bottom;
        private Button b_save;
        private Button b_cancel;
        private TableLayoutPanel tlp_main;
        private Button b_newDisk;
        private TreeView tv_main;
        private Label label1;
        private ImageList il_tree;
    }
}