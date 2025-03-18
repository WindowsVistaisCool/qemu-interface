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
            tlp_main = new TableLayoutPanel();
            gb_diskType = new GroupBox();
            flp_diskType = new FlowLayoutPanel();
            rb_diskType_qcow2 = new RadioButton();
            rb_diskType_vmdk = new RadioButton();
            gb_diskLoc = new GroupBox();
            flp_bottom = new FlowLayoutPanel();
            b_cancel = new Button();
            b_save = new Button();
            gb_size = new GroupBox();
            trackBar1 = new TrackBar();
            p_main = new Panel();
            p_main.SuspendLayout();
            tlp_main.SuspendLayout();
            gb_diskType.SuspendLayout();
            flp_diskType.SuspendLayout();
            flp_bottom.SuspendLayout();
            gb_size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // p_main
            // 
            p_main.Controls.Add(tlp_main);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Name = "p_main";
            p_main.Size = new Size(956, 589);
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
            tlp_main.RowCount = 3;
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 59.4240837F));
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 40.5759163F));
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_main.Size = new Size(956, 589);
            tlp_main.TabIndex = 0;
            // 
            // gb_diskType
            // 
            gb_diskType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_diskType.Controls.Add(flp_diskType);
            gb_diskType.Location = new Point(10, 243);
            gb_diskType.Margin = new Padding(10);
            gb_diskType.Name = "gb_diskType";
            gb_diskType.Padding = new Padding(5, 5, 5, 10);
            gb_diskType.Size = new Size(936, 139);
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
            flp_diskType.Size = new Size(926, 108);
            flp_diskType.TabIndex = 0;
            // 
            // rb_diskType_qcow2
            // 
            rb_diskType_qcow2.AutoSize = true;
            rb_diskType_qcow2.Checked = true;
            rb_diskType_qcow2.Location = new Point(8, 8);
            rb_diskType_qcow2.Name = "rb_diskType_qcow2";
            rb_diskType_qcow2.Size = new Size(185, 19);
            rb_diskType_qcow2.TabIndex = 0;
            rb_diskType_qcow2.TabStop = true;
            rb_diskType_qcow2.Text = "QCow2 (Qemu Image Format)";
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
            gb_diskLoc.Location = new Point(10, 20);
            gb_diskLoc.Margin = new Padding(10, 20, 10, 10);
            gb_diskLoc.Name = "gb_diskLoc";
            gb_diskLoc.Size = new Size(936, 203);
            gb_diskLoc.TabIndex = 1;
            gb_diskLoc.TabStop = false;
            gb_diskLoc.Text = "Disk Name and File Location";
            // 
            // flp_bottom
            // 
            flp_bottom.AutoSize = true;
            flp_bottom.BackColor = SystemColors.ControlLight;
            flp_bottom.Controls.Add(b_cancel);
            flp_bottom.Controls.Add(b_save);
            flp_bottom.Dock = DockStyle.Bottom;
            flp_bottom.FlowDirection = FlowDirection.RightToLeft;
            flp_bottom.Location = new Point(0, 589);
            flp_bottom.Name = "flp_bottom";
            flp_bottom.Size = new Size(956, 44);
            flp_bottom.TabIndex = 4;
            // 
            // b_cancel
            // 
            b_cancel.BackColor = SystemColors.Control;
            b_cancel.BackgroundImageLayout = ImageLayout.None;
            b_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            b_cancel.FlatStyle = FlatStyle.System;
            b_cancel.Location = new Point(860, 9);
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
            b_save.Location = new Point(764, 9);
            b_save.Margin = new Padding(5, 9, 5, 9);
            b_save.Name = "b_save";
            b_save.Size = new Size(86, 26);
            b_save.TabIndex = 0;
            b_save.Text = "Create";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // gb_size
            // 
            gb_size.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_size.Controls.Add(trackBar1);
            gb_size.Location = new Point(10, 402);
            gb_size.Margin = new Padding(10, 10, 10, 20);
            gb_size.Name = "gb_size";
            gb_size.Size = new Size(936, 167);
            gb_size.TabIndex = 2;
            gb_size.TabStop = false;
            gb_size.Text = "Disk Size";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(91, 52);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(695, 45);
            trackBar1.TabIndex = 0;
            // 
            // WIN_NewDisk
            // 
            AcceptButton = b_save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(956, 633);
            Controls.Add(p_main);
            Controls.Add(flp_bottom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WIN_NewDisk";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Disk - ";
            FormClosing += WIN_MEDIA_FormClosing;
            p_main.ResumeLayout(false);
            tlp_main.ResumeLayout(false);
            gb_diskType.ResumeLayout(false);
            flp_diskType.ResumeLayout(false);
            flp_diskType.PerformLayout();
            flp_bottom.ResumeLayout(false);
            gb_size.ResumeLayout(false);
            gb_size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
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
        private TrackBar trackBar1;
    }
}