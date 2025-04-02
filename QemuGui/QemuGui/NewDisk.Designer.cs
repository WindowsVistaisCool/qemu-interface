namespace QEMUInterface
{
    partial class WIN_NewDisk
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
            Panel p_main;
            TableLayoutPanel tlp_size;
            Label l_boundRight;
            TableLayoutPanel tlp_fileFolder;
            Label ls_folder;
            Label ls_name;
            tlp_main = new TableLayoutPanel();
            gb_size = new GroupBox();
            l_boundLeft = new Label();
            slider = new TrackBar();
            num_size = new NumericUpDown();
            gb_diskType = new GroupBox();
            flp_diskType = new FlowLayoutPanel();
            rb_diskType_qcow2 = new RadioButton();
            rb_diskType_vmdk = new RadioButton();
            gb_diskLoc = new GroupBox();
            t_folder = new TextBox();
            b_selFolder = new Button();
            t_name = new TextBox();
            flp_bottom = new FlowLayoutPanel();
            b_cancel = new Button();
            b_save = new Button();
            fbd_folder = new FolderBrowserDialog();
            p_main = new Panel();
            tlp_size = new TableLayoutPanel();
            l_boundRight = new Label();
            tlp_fileFolder = new TableLayoutPanel();
            ls_folder = new Label();
            ls_name = new Label();
            p_main.SuspendLayout();
            tlp_main.SuspendLayout();
            gb_size.SuspendLayout();
            tlp_size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_size).BeginInit();
            gb_diskType.SuspendLayout();
            flp_diskType.SuspendLayout();
            gb_diskLoc.SuspendLayout();
            tlp_fileFolder.SuspendLayout();
            flp_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // p_main
            // 
            p_main.Controls.Add(tlp_main);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Name = "p_main";
            p_main.Size = new Size(547, 411);
            p_main.TabIndex = 5;
            // 
            // tlp_main
            // 
            tlp_main.ColumnCount = 1;
            tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.3139F));
            tlp_main.Controls.Add(gb_size, 0, 2);
            tlp_main.Controls.Add(gb_diskType, 0, 1);
            tlp_main.Controls.Add(gb_diskLoc, 0, 0);
            tlp_main.Dock = DockStyle.Fill;
            tlp_main.Location = new Point(0, 0);
            tlp_main.Name = "tlp_main";
            tlp_main.Padding = new Padding(4, 2, 4, 0);
            tlp_main.RowCount = 3;
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 32.9949226F));
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 31.8944836F));
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 35.2517967F));
            tlp_main.Size = new Size(547, 411);
            tlp_main.TabIndex = 0;
            // 
            // gb_size
            // 
            gb_size.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_size.Controls.Add(tlp_size);
            gb_size.Location = new Point(14, 270);
            gb_size.Margin = new Padding(10, 4, 10, 20);
            gb_size.Name = "gb_size";
            gb_size.Padding = new Padding(5, 5, 5, 10);
            gb_size.Size = new Size(519, 121);
            gb_size.TabIndex = 2;
            gb_size.TabStop = false;
            gb_size.Text = "Disk Size";
            // 
            // tlp_size
            // 
            tlp_size.AutoSize = true;
            tlp_size.ColumnCount = 3;
            tlp_size.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.76023F));
            tlp_size.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.41615F));
            tlp_size.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.0124226F));
            tlp_size.Controls.Add(l_boundLeft, 1, 1);
            tlp_size.Controls.Add(slider, 0, 0);
            tlp_size.Controls.Add(l_boundRight, 0, 1);
            tlp_size.Controls.Add(num_size, 2, 0);
            tlp_size.Dock = DockStyle.Fill;
            tlp_size.Location = new Point(5, 21);
            tlp_size.Margin = new Padding(5, 9, 5, 9);
            tlp_size.Name = "tlp_size";
            tlp_size.RowCount = 2;
            tlp_size.RowStyles.Add(new RowStyle());
            tlp_size.RowStyles.Add(new RowStyle());
            tlp_size.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tlp_size.Size = new Size(509, 90);
            tlp_size.TabIndex = 8;
            // 
            // l_boundLeft
            // 
            l_boundLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_boundLeft.AutoSize = true;
            l_boundLeft.Location = new Point(368, 49);
            l_boundLeft.Margin = new Padding(5, 0, 0, 4);
            l_boundLeft.Name = "l_boundLeft";
            l_boundLeft.Size = new Size(49, 15);
            l_boundLeft.TabIndex = 8;
            l_boundLeft.Text = "4096 GB";
            l_boundLeft.TextAlign = ContentAlignment.MiddleRight;
            // 
            // slider
            // 
            slider.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_size.SetColumnSpan(slider, 2);
            slider.LargeChange = 16;
            slider.Location = new Point(5, 4);
            slider.Margin = new Padding(5, 4, 10, 0);
            slider.Maximum = 4096;
            slider.Minimum = 1;
            slider.Name = "slider";
            slider.Size = new Size(402, 45);
            slider.SmallChange = 2;
            slider.TabIndex = 6;
            slider.TickFrequency = 512;
            slider.TickStyle = TickStyle.Both;
            slider.Value = 1;
            slider.Scroll += slider_Scroll;
            // 
            // l_boundRight
            // 
            l_boundRight.AutoSize = true;
            l_boundRight.Location = new Point(0, 49);
            l_boundRight.Margin = new Padding(0, 0, 5, 4);
            l_boundRight.Name = "l_boundRight";
            l_boundRight.Size = new Size(34, 15);
            l_boundRight.TabIndex = 7;
            l_boundRight.Text = "1 MB";
            l_boundRight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // num_size
            // 
            num_size.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            num_size.Location = new Point(422, 13);
            num_size.Margin = new Padding(5, 4, 5, 4);
            num_size.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            num_size.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_size.Name = "num_size";
            num_size.RightToLeft = RightToLeft.No;
            num_size.Size = new Size(82, 23);
            num_size.TabIndex = 9;
            num_size.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gb_diskType
            // 
            gb_diskType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_diskType.Controls.Add(flp_diskType);
            gb_diskType.Location = new Point(14, 140);
            gb_diskType.Margin = new Padding(10, 4, 10, 4);
            gb_diskType.Name = "gb_diskType";
            gb_diskType.Padding = new Padding(5, 5, 5, 10);
            gb_diskType.Size = new Size(519, 122);
            gb_diskType.TabIndex = 0;
            gb_diskType.TabStop = false;
            gb_diskType.Text = "Disk Type";
            // 
            // flp_diskType
            // 
            flp_diskType.Controls.Add(rb_diskType_qcow2);
            flp_diskType.Controls.Add(rb_diskType_vmdk);
            flp_diskType.Dock = DockStyle.Fill;
            flp_diskType.FlowDirection = FlowDirection.TopDown;
            flp_diskType.Location = new Point(5, 21);
            flp_diskType.Name = "flp_diskType";
            flp_diskType.Padding = new Padding(5);
            flp_diskType.Size = new Size(509, 91);
            flp_diskType.TabIndex = 0;
            // 
            // rb_diskType_qcow2
            // 
            rb_diskType_qcow2.AutoSize = true;
            rb_diskType_qcow2.Checked = true;
            rb_diskType_qcow2.Location = new Point(8, 8);
            rb_diskType_qcow2.Name = "rb_diskType_qcow2";
            rb_diskType_qcow2.Size = new Size(192, 19);
            rb_diskType_qcow2.TabIndex = 0;
            rb_diskType_qcow2.TabStop = true;
            rb_diskType_qcow2.Text = "QCow2 (Qemu CopyOnWrite 2)";
            rb_diskType_qcow2.UseVisualStyleBackColor = true;
            // 
            // rb_diskType_vmdk
            // 
            rb_diskType_vmdk.AutoSize = true;
            rb_diskType_vmdk.Location = new Point(8, 33);
            rb_diskType_vmdk.Name = "rb_diskType_vmdk";
            rb_diskType_vmdk.Size = new Size(177, 19);
            rb_diskType_vmdk.TabIndex = 1;
            rb_diskType_vmdk.Text = "VMDK (Virtual Machine Disk)";
            rb_diskType_vmdk.UseVisualStyleBackColor = true;
            // 
            // gb_diskLoc
            // 
            gb_diskLoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_diskLoc.Controls.Add(tlp_fileFolder);
            gb_diskLoc.Location = new Point(14, 15);
            gb_diskLoc.Margin = new Padding(10, 13, 10, 4);
            gb_diskLoc.Name = "gb_diskLoc";
            gb_diskLoc.Size = new Size(519, 117);
            gb_diskLoc.TabIndex = 1;
            gb_diskLoc.TabStop = false;
            gb_diskLoc.Text = "Disk Name and File Location";
            // 
            // tlp_fileFolder
            // 
            tlp_fileFolder.AutoSize = true;
            tlp_fileFolder.ColumnCount = 3;
            tlp_fileFolder.ColumnStyles.Add(new ColumnStyle());
            tlp_fileFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_fileFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tlp_fileFolder.Controls.Add(ls_folder, 0, 0);
            tlp_fileFolder.Controls.Add(t_folder, 1, 0);
            tlp_fileFolder.Controls.Add(b_selFolder, 2, 0);
            tlp_fileFolder.Controls.Add(ls_name, 0, 1);
            tlp_fileFolder.Controls.Add(t_name, 1, 1);
            tlp_fileFolder.Dock = DockStyle.Fill;
            tlp_fileFolder.Location = new Point(3, 19);
            tlp_fileFolder.Margin = new Padding(0);
            tlp_fileFolder.Name = "tlp_fileFolder";
            tlp_fileFolder.RowCount = 3;
            tlp_fileFolder.RowStyles.Add(new RowStyle(SizeType.Percent, 56.0606079F));
            tlp_fileFolder.RowStyles.Add(new RowStyle());
            tlp_fileFolder.RowStyles.Add(new RowStyle(SizeType.Percent, 43.9393921F));
            tlp_fileFolder.Size = new Size(513, 95);
            tlp_fileFolder.TabIndex = 5;
            // 
            // ls_folder
            // 
            ls_folder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ls_folder.AutoSize = true;
            ls_folder.Location = new Point(5, 4);
            ls_folder.Margin = new Padding(5, 4, 5, 4);
            ls_folder.Name = "ls_folder";
            ls_folder.Size = new Size(67, 29);
            ls_folder.TabIndex = 0;
            ls_folder.Text = "Folder:";
            ls_folder.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_folder
            // 
            t_folder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_folder.Location = new Point(82, 7);
            t_folder.Margin = new Padding(5, 3, 5, 3);
            t_folder.Name = "t_folder";
            t_folder.PlaceholderText = "Select a path...";
            t_folder.Size = new Size(324, 23);
            t_folder.TabIndex = 1;
            // 
            // b_selFolder
            // 
            b_selFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b_selFolder.Location = new Point(416, 3);
            b_selFolder.Margin = new Padding(5, 3, 5, 3);
            b_selFolder.Name = "b_selFolder";
            b_selFolder.Size = new Size(92, 31);
            b_selFolder.TabIndex = 2;
            b_selFolder.Text = "Select";
            b_selFolder.UseVisualStyleBackColor = true;
            b_selFolder.Click += b_selFolder_Click;
            // 
            // ls_name
            // 
            ls_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ls_name.AutoSize = true;
            ls_name.Location = new Point(5, 41);
            ls_name.Margin = new Padding(5, 4, 5, 4);
            ls_name.Name = "ls_name";
            ls_name.Size = new Size(67, 21);
            ls_name.TabIndex = 3;
            ls_name.Text = "Disk Name:";
            ls_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_name
            // 
            t_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_name.BackColor = SystemColors.Window;
            tlp_fileFolder.SetColumnSpan(t_name, 2);
            t_name.Location = new Point(82, 40);
            t_name.Margin = new Padding(5, 3, 5, 3);
            t_name.Name = "t_name";
            t_name.Size = new Size(426, 23);
            t_name.TabIndex = 4;
            // 
            // flp_bottom
            // 
            flp_bottom.AutoSize = true;
            flp_bottom.BackColor = SystemColors.ControlLight;
            flp_bottom.Controls.Add(b_cancel);
            flp_bottom.Controls.Add(b_save);
            flp_bottom.Dock = DockStyle.Bottom;
            flp_bottom.FlowDirection = FlowDirection.RightToLeft;
            flp_bottom.Location = new Point(0, 411);
            flp_bottom.Name = "flp_bottom";
            flp_bottom.Size = new Size(547, 44);
            flp_bottom.TabIndex = 4;
            // 
            // b_cancel
            // 
            b_cancel.BackColor = SystemColors.Control;
            b_cancel.BackgroundImageLayout = ImageLayout.None;
            b_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            b_cancel.FlatStyle = FlatStyle.System;
            b_cancel.Location = new Point(451, 9);
            b_cancel.Margin = new Padding(5, 9, 10, 9);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(86, 26);
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
            b_save.Location = new Point(355, 9);
            b_save.Margin = new Padding(5, 9, 5, 9);
            b_save.Name = "b_save";
            b_save.Size = new Size(86, 26);
            b_save.TabIndex = 0;
            b_save.Text = "Create";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // WIN_NewDisk
            // 
            AcceptButton = b_save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(547, 455);
            Controls.Add(p_main);
            Controls.Add(flp_bottom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WIN_NewDisk";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Disk - ";
            FormClosing += WIN_NewDisk_FormClosing;
            p_main.ResumeLayout(false);
            tlp_main.ResumeLayout(false);
            gb_size.ResumeLayout(false);
            gb_size.PerformLayout();
            tlp_size.ResumeLayout(false);
            tlp_size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slider).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_size).EndInit();
            gb_diskType.ResumeLayout(false);
            flp_diskType.ResumeLayout(false);
            flp_diskType.PerformLayout();
            gb_diskLoc.ResumeLayout(false);
            gb_diskLoc.PerformLayout();
            tlp_fileFolder.ResumeLayout(false);
            tlp_fileFolder.PerformLayout();
            flp_bottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_bottom;
        private Button b_cancel;
        private Button b_save;
        private TableLayoutPanel tlp_main;
        private GroupBox gb_diskType;
        private FlowLayoutPanel flp_diskType;
        private RadioButton rb_diskType_qcow2;
        private RadioButton rb_diskType_vmdk;
        private GroupBox gb_diskLoc;
        private GroupBox gb_size;
        private TextBox t_folder;
        private Button b_selFolder;
        private TextBox t_name;
        private Label l_boundLeft;
        private TrackBar slider;
        private NumericUpDown num_size;
        private FolderBrowserDialog fbd_folder;
    }
}