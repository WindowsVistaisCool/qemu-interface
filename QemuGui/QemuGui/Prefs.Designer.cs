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
            TableLayoutPanel tlp_main;
            TableLayoutPanel tlp_fileFolder;
            Label ls_vmFolder;
            Label ls_qemuFiles;
            gb_configFiles = new GroupBox();
            t_vmFolder = new TextBox();
            b_selvmFolder = new Button();
            t_qemuPath = new TextBox();
            b_selqemuFolder = new Button();
            gb_theme = new GroupBox();
            flp_theme = new FlowLayoutPanel();
            rb_theme_light = new RadioButton();
            rb_theme_dark = new RadioButton();
            fbd_vmFolder = new FolderBrowserDialog();
            b_cancel = new Button();
            b_save = new Button();
            flp_bottom = new FlowLayoutPanel();
            fbd_qemuFolder = new FolderBrowserDialog();
            p_main = new Panel();
            tlp_main = new TableLayoutPanel();
            tlp_fileFolder = new TableLayoutPanel();
            ls_vmFolder = new Label();
            ls_qemuFiles = new Label();
            p_main.SuspendLayout();
            tlp_main.SuspendLayout();
            gb_configFiles.SuspendLayout();
            tlp_fileFolder.SuspendLayout();
            gb_theme.SuspendLayout();
            flp_theme.SuspendLayout();
            flp_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // p_main
            // 
            p_main.Controls.Add(tlp_main);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Margin = new Padding(0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(10);
            p_main.Size = new Size(584, 340);
            p_main.TabIndex = 3;
            // 
            // tlp_main
            // 
            tlp_main.ColumnCount = 1;
            tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_main.Controls.Add(gb_configFiles, 0, 0);
            tlp_main.Controls.Add(gb_theme, 0, 1);
            tlp_main.Dock = DockStyle.Fill;
            tlp_main.Location = new Point(10, 10);
            tlp_main.Name = "tlp_main";
            tlp_main.RowCount = 3;
            tlp_main.RowStyles.Add(new RowStyle());
            tlp_main.RowStyles.Add(new RowStyle());
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_main.Size = new Size(564, 320);
            tlp_main.TabIndex = 2;
            // 
            // gb_configFiles
            // 
            gb_configFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_configFiles.Controls.Add(tlp_fileFolder);
            gb_configFiles.Location = new Point(10, 10);
            gb_configFiles.Margin = new Padding(10);
            gb_configFiles.Name = "gb_configFiles";
            gb_configFiles.Padding = new Padding(10, 5, 10, 10);
            gb_configFiles.Size = new Size(544, 130);
            gb_configFiles.TabIndex = 0;
            gb_configFiles.TabStop = false;
            gb_configFiles.Text = "File/Folder Paths";
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
            tlp_fileFolder.Controls.Add(b_selqemuFolder, 2, 1);
            tlp_fileFolder.Dock = DockStyle.Fill;
            tlp_fileFolder.Location = new Point(10, 23);
            tlp_fileFolder.Margin = new Padding(0);
            tlp_fileFolder.Name = "tlp_fileFolder";
            tlp_fileFolder.RowCount = 2;
            tlp_fileFolder.RowStyles.Add(new RowStyle());
            tlp_fileFolder.RowStyles.Add(new RowStyle());
            tlp_fileFolder.Size = new Size(524, 97);
            tlp_fileFolder.TabIndex = 4;
            // 
            // ls_vmFolder
            // 
            ls_vmFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ls_vmFolder.AutoSize = true;
            ls_vmFolder.Location = new Point(5, 5);
            ls_vmFolder.Margin = new Padding(5);
            ls_vmFolder.Name = "ls_vmFolder";
            ls_vmFolder.Size = new Size(86, 24);
            ls_vmFolder.TabIndex = 0;
            ls_vmFolder.Text = "VM Folder:";
            ls_vmFolder.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_vmFolder
            // 
            t_vmFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            t_vmFolder.Location = new Point(101, 3);
            t_vmFolder.Margin = new Padding(5, 3, 5, 3);
            t_vmFolder.Name = "t_vmFolder";
            t_vmFolder.PlaceholderText = "Select a path...";
            t_vmFolder.Size = new Size(325, 25);
            t_vmFolder.TabIndex = 1;
            t_vmFolder.TextChanged += setUnsavedChanges;
            // 
            // b_selvmFolder
            // 
            b_selvmFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b_selvmFolder.Location = new Point(436, 3);
            b_selvmFolder.Margin = new Padding(5, 3, 5, 3);
            b_selvmFolder.Name = "b_selvmFolder";
            b_selvmFolder.Size = new Size(83, 28);
            b_selvmFolder.TabIndex = 2;
            b_selvmFolder.Text = "Select";
            b_selvmFolder.UseVisualStyleBackColor = true;
            b_selvmFolder.Click += b_selFolder_Click;
            // 
            // ls_qemuFiles
            // 
            ls_qemuFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ls_qemuFiles.AutoSize = true;
            ls_qemuFiles.Location = new Point(5, 39);
            ls_qemuFiles.Margin = new Padding(5);
            ls_qemuFiles.Name = "ls_qemuFiles";
            ls_qemuFiles.Size = new Size(86, 53);
            ls_qemuFiles.TabIndex = 3;
            ls_qemuFiles.Text = "QEMU Program Files:";
            ls_qemuFiles.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_qemuPath
            // 
            t_qemuPath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_qemuPath.BackColor = SystemColors.Window;
            t_qemuPath.Location = new Point(101, 53);
            t_qemuPath.Margin = new Padding(5, 3, 5, 3);
            t_qemuPath.Name = "t_qemuPath";
            t_qemuPath.PlaceholderText = "Select a path...";
            t_qemuPath.Size = new Size(325, 25);
            t_qemuPath.TabIndex = 4;
            t_qemuPath.TextChanged += setUnsavedChanges;
            // 
            // b_selqemuFolder
            // 
            b_selqemuFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            b_selqemuFolder.Location = new Point(436, 53);
            b_selqemuFolder.Margin = new Padding(5, 3, 5, 3);
            b_selqemuFolder.Name = "b_selqemuFolder";
            b_selqemuFolder.Size = new Size(83, 25);
            b_selqemuFolder.TabIndex = 5;
            b_selqemuFolder.Text = "Select";
            b_selqemuFolder.UseVisualStyleBackColor = true;
            b_selqemuFolder.Click += b_selqemuFolder_Click;
            // 
            // gb_theme
            // 
            gb_theme.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gb_theme.AutoSize = true;
            gb_theme.Controls.Add(flp_theme);
            gb_theme.Location = new Point(10, 160);
            gb_theme.Margin = new Padding(10);
            gb_theme.Name = "gb_theme";
            gb_theme.Size = new Size(544, 64);
            gb_theme.TabIndex = 1;
            gb_theme.TabStop = false;
            gb_theme.Text = "Theme";
            // 
            // flp_theme
            // 
            flp_theme.AutoSize = true;
            flp_theme.Controls.Add(rb_theme_light);
            flp_theme.Controls.Add(rb_theme_dark);
            flp_theme.Dock = DockStyle.Fill;
            flp_theme.Location = new Point(3, 21);
            flp_theme.Name = "flp_theme";
            flp_theme.Padding = new Padding(6, 3, 3, 10);
            flp_theme.Size = new Size(538, 40);
            flp_theme.TabIndex = 0;
            // 
            // rb_theme_light
            // 
            rb_theme_light.AutoSize = true;
            rb_theme_light.Checked = true;
            rb_theme_light.Location = new Point(9, 6);
            rb_theme_light.Margin = new Padding(3, 3, 50, 3);
            rb_theme_light.Name = "rb_theme_light";
            rb_theme_light.Size = new Size(97, 21);
            rb_theme_light.TabIndex = 0;
            rb_theme_light.TabStop = true;
            rb_theme_light.Text = "Light Theme";
            rb_theme_light.UseVisualStyleBackColor = true;
            rb_theme_light.CheckedChanged += triggerRepaintFlag;
            // 
            // rb_theme_dark
            // 
            rb_theme_dark.AutoSize = true;
            rb_theme_dark.Location = new Point(159, 6);
            rb_theme_dark.Name = "rb_theme_dark";
            rb_theme_dark.Size = new Size(183, 21);
            rb_theme_dark.TabIndex = 1;
            rb_theme_dark.Text = "Dark Theme (experimental)";
            rb_theme_dark.UseVisualStyleBackColor = true;
            rb_theme_dark.CheckedChanged += triggerRepaintFlag;
            // 
            // b_cancel
            // 
            b_cancel.BackColor = SystemColors.Control;
            b_cancel.BackgroundImageLayout = ImageLayout.None;
            b_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            b_cancel.FlatStyle = FlatStyle.System;
            b_cancel.Location = new Point(392, 10);
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
            b_save.Location = new Point(488, 10);
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
            flp_bottom.Location = new Point(0, 340);
            flp_bottom.Name = "flp_bottom";
            flp_bottom.Size = new Size(584, 49);
            flp_bottom.TabIndex = 2;
            // 
            // fbd_qemuFolder
            // 
            fbd_qemuFolder.RootFolder = Environment.SpecialFolder.CommonPrograms;
            // 
            // WIN_Prefs
            // 
            AcceptButton = b_save;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(584, 389);
            Controls.Add(p_main);
            Controls.Add(flp_bottom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WIN_Prefs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QEMU Interface - Preferences";
            FormClosing += Preferences_FormClosing;
            Load += Preferences_Load;
            p_main.ResumeLayout(false);
            tlp_main.ResumeLayout(false);
            tlp_main.PerformLayout();
            gb_configFiles.ResumeLayout(false);
            gb_configFiles.PerformLayout();
            tlp_fileFolder.ResumeLayout(false);
            tlp_fileFolder.PerformLayout();
            gb_theme.ResumeLayout(false);
            gb_theme.PerformLayout();
            flp_theme.ResumeLayout(false);
            flp_theme.PerformLayout();
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
        private Button b_selqemuFolder;
        private FolderBrowserDialog fbd_qemuFolder;
        private GroupBox gb_theme;
        private FlowLayoutPanel flp_theme;
        private RadioButton rb_theme_light;
        private RadioButton rb_theme_dark;
    }
}