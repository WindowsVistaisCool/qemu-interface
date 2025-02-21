namespace QEMUInterface
{
    partial class WIN_Prefs
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
            GroupBox gb_meme;
            TableLayoutPanel tlp_fileFolder;
            Label ls_vmFolder;
            Label ls_qemuFiles;
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            gb_configFiles = new GroupBox();
            t_vmFolder = new TextBox();
            b_selvmFolder = new Button();
            t_qemuPath = new TextBox();
            button1 = new Button();
            fbd_vmFolder = new FolderBrowserDialog();
            b_cancel = new Button();
            b_save = new Button();
            flp_bottom = new FlowLayoutPanel();
            p_main = new Panel();
            gb_meme = new GroupBox();
            tlp_fileFolder = new TableLayoutPanel();
            ls_vmFolder = new Label();
            ls_qemuFiles = new Label();
            p_main.SuspendLayout();
            gb_meme.SuspendLayout();
            gb_configFiles.SuspendLayout();
            tlp_fileFolder.SuspendLayout();
            flp_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // p_main
            // 
            p_main.Controls.Add(gb_meme);
            p_main.Controls.Add(gb_configFiles);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Margin = new Padding(0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(10);
            p_main.Size = new Size(600, 251);
            p_main.TabIndex = 3;
            // 
            // gb_meme
            // 
            gb_meme.AutoSize = true;
            gb_meme.Controls.Add(radioButton2);
            gb_meme.Controls.Add(radioButton1);
            gb_meme.Dock = DockStyle.Top;
            gb_meme.Enabled = false;
            gb_meme.Location = new Point(10, 121);
            gb_meme.Name = "gb_meme";
            gb_meme.Size = new Size(580, 76);
            gb_meme.TabIndex = 1;
            gb_meme.TabStop = false;
            gb_meme.Text = "Shits and Giggles";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(208, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 21);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "no funny";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(32, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 21);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "yes funny";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // gb_configFiles
            // 
            gb_configFiles.Controls.Add(tlp_fileFolder);
            gb_configFiles.Dock = DockStyle.Top;
            gb_configFiles.Location = new Point(10, 10);
            gb_configFiles.Margin = new Padding(10);
            gb_configFiles.Name = "gb_configFiles";
            gb_configFiles.Padding = new Padding(10, 5, 10, 10);
            gb_configFiles.Size = new Size(580, 111);
            gb_configFiles.TabIndex = 0;
            gb_configFiles.TabStop = false;
            gb_configFiles.Text = "File/Folder Paths";
            gb_configFiles.Enter += groupBox1_Enter;
            // 
            // tlp_fileFolder
            // 
            tlp_fileFolder.AutoSize = true;
            tlp_fileFolder.ColumnCount = 3;
            tlp_fileFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3928566F));
            tlp_fileFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.92857F));
            tlp_fileFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5344486F));
            tlp_fileFolder.Controls.Add(ls_vmFolder, 0, 0);
            tlp_fileFolder.Controls.Add(t_vmFolder, 1, 0);
            tlp_fileFolder.Controls.Add(b_selvmFolder, 2, 0);
            tlp_fileFolder.Controls.Add(ls_qemuFiles, 0, 1);
            tlp_fileFolder.Controls.Add(t_qemuPath, 1, 1);
            tlp_fileFolder.Controls.Add(button1, 2, 1);
            tlp_fileFolder.Dock = DockStyle.Fill;
            tlp_fileFolder.Location = new Point(10, 23);
            tlp_fileFolder.Margin = new Padding(0);
            tlp_fileFolder.Name = "tlp_fileFolder";
            tlp_fileFolder.RowCount = 2;
            tlp_fileFolder.RowStyles.Add(new RowStyle());
            tlp_fileFolder.RowStyles.Add(new RowStyle());
            tlp_fileFolder.Size = new Size(560, 78);
            tlp_fileFolder.TabIndex = 4;
            // 
            // ls_vmFolder
            // 
            ls_vmFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ls_vmFolder.AutoSize = true;
            ls_vmFolder.Location = new Point(5, 5);
            ls_vmFolder.Margin = new Padding(5);
            ls_vmFolder.Name = "ls_vmFolder";
            ls_vmFolder.Size = new Size(93, 21);
            ls_vmFolder.TabIndex = 0;
            ls_vmFolder.Text = "VM Folder:";
            ls_vmFolder.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_vmFolder
            // 
            t_vmFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            t_vmFolder.Location = new Point(108, 3);
            t_vmFolder.Margin = new Padding(5, 3, 5, 3);
            t_vmFolder.Name = "t_vmFolder";
            t_vmFolder.PlaceholderText = "Select a path...";
            t_vmFolder.Size = new Size(348, 25);
            t_vmFolder.TabIndex = 1;
            t_vmFolder.TextChanged += t_vmFolder_TextChanged;
            // 
            // b_selvmFolder
            // 
            b_selvmFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b_selvmFolder.Location = new Point(466, 3);
            b_selvmFolder.Margin = new Padding(5, 3, 5, 3);
            b_selvmFolder.Name = "b_selvmFolder";
            b_selvmFolder.Size = new Size(89, 25);
            b_selvmFolder.TabIndex = 2;
            b_selvmFolder.Text = "Select";
            b_selvmFolder.UseVisualStyleBackColor = true;
            b_selvmFolder.Click += b_selFolder_Click;
            // 
            // ls_qemuFiles
            // 
            ls_qemuFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ls_qemuFiles.AutoSize = true;
            ls_qemuFiles.Location = new Point(5, 36);
            ls_qemuFiles.Margin = new Padding(5);
            ls_qemuFiles.Name = "ls_qemuFiles";
            ls_qemuFiles.Size = new Size(93, 37);
            ls_qemuFiles.TabIndex = 3;
            ls_qemuFiles.Text = "QEMU Program Files:";
            ls_qemuFiles.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_qemuPath
            // 
            t_qemuPath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_qemuPath.BackColor = SystemColors.Window;
            t_qemuPath.Location = new Point(108, 42);
            t_qemuPath.Margin = new Padding(5, 3, 5, 3);
            t_qemuPath.Name = "t_qemuPath";
            t_qemuPath.PlaceholderText = "Select a path...";
            t_qemuPath.Size = new Size(348, 25);
            t_qemuPath.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(466, 42);
            button1.Margin = new Padding(5, 3, 5, 3);
            button1.Name = "button1";
            button1.Size = new Size(89, 25);
            button1.TabIndex = 5;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            // 
            // b_cancel
            // 
            b_cancel.BackColor = SystemColors.Control;
            b_cancel.BackgroundImageLayout = ImageLayout.None;
            b_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            b_cancel.FlatStyle = FlatStyle.System;
            b_cancel.Location = new Point(408, 10);
            b_cancel.Margin = new Padding(5, 10, 5, 10);
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
            b_save.Location = new Point(504, 10);
            b_save.Margin = new Padding(5, 10, 10, 10);
            b_save.Name = "b_save";
            b_save.Size = new Size(86, 29);
            b_save.TabIndex = 0;
            b_save.Text = "OK";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // flp_bottom
            // 
            flp_bottom.AutoSize = true;
            flp_bottom.BackColor = SystemColors.ControlLight;
            flp_bottom.Controls.Add(b_save);
            flp_bottom.Controls.Add(b_cancel);
            flp_bottom.Dock = DockStyle.Bottom;
            flp_bottom.FlowDirection = FlowDirection.RightToLeft;
            flp_bottom.Location = new Point(0, 251);
            flp_bottom.Name = "flp_bottom";
            flp_bottom.Size = new Size(600, 49);
            flp_bottom.TabIndex = 2;
            // 
            // WIN_Prefs
            // 
            AcceptButton = b_save;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(600, 300);
            Controls.Add(p_main);
            Controls.Add(flp_bottom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WIN_Prefs";
            Text = "QEMU Interface - Preferences";
            FormClosing += Preferences_FormClosing;
            Load += Preferences_Load;
            p_main.ResumeLayout(false);
            p_main.PerformLayout();
            gb_meme.ResumeLayout(false);
            gb_meme.PerformLayout();
            gb_configFiles.ResumeLayout(false);
            gb_configFiles.PerformLayout();
            tlp_fileFolder.ResumeLayout(false);
            tlp_fileFolder.PerformLayout();
            flp_bottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_configFiles;
        private Button b_selvmFolder;
        private TextBox t_vmFolder;
        private Label ls_vmFolder;
        private FolderBrowserDialog fbd_vmFolder;
        private Button b_save;
        private Button b_cancel;
        private FlowLayoutPanel flp_bottom;
        private TableLayoutPanel tlp_fileFolder;
        private TextBox t_qemuPath;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}