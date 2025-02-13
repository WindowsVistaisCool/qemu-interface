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
            gb_configFiles = new GroupBox();
            b_selvmFolder = new Button();
            t_vmFolder = new TextBox();
            l_vmFolder = new Label();
            fbd_vmFolder = new FolderBrowserDialog();
            bottomPanel = new Panel();
            b_cancel = new Button();
            b_save = new Button();
            gb_configFiles.SuspendLayout();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gb_configFiles
            // 
            gb_configFiles.Controls.Add(b_selvmFolder);
            gb_configFiles.Controls.Add(t_vmFolder);
            gb_configFiles.Controls.Add(l_vmFolder);
            gb_configFiles.Location = new Point(12, 12);
            gb_configFiles.Name = "gb_configFiles";
            gb_configFiles.Size = new Size(583, 69);
            gb_configFiles.TabIndex = 0;
            gb_configFiles.TabStop = false;
            gb_configFiles.Text = "File/Folder Paths";
            gb_configFiles.Enter += groupBox1_Enter;
            // 
            // b_selvmFolder
            // 
            b_selvmFolder.Location = new Point(494, 26);
            b_selvmFolder.Name = "b_selvmFolder";
            b_selvmFolder.Size = new Size(83, 25);
            b_selvmFolder.TabIndex = 2;
            b_selvmFolder.Text = "Select";
            b_selvmFolder.UseVisualStyleBackColor = true;
            b_selvmFolder.Click += b_selFolder_Click;
            // 
            // t_vmFolder
            // 
            t_vmFolder.Location = new Point(95, 26);
            t_vmFolder.Name = "t_vmFolder";
            t_vmFolder.PlaceholderText = "Select a path...";
            t_vmFolder.Size = new Size(393, 25);
            t_vmFolder.TabIndex = 1;
            t_vmFolder.TextChanged += t_vmFolder_TextChanged;
            // 
            // l_vmFolder
            // 
            l_vmFolder.AutoSize = true;
            l_vmFolder.Location = new Point(9, 29);
            l_vmFolder.Margin = new Padding(6, 0, 14, 0);
            l_vmFolder.Name = "l_vmFolder";
            l_vmFolder.Size = new Size(69, 17);
            l_vmFolder.TabIndex = 0;
            l_vmFolder.Text = "VM Folder";
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(b_cancel);
            bottomPanel.Controls.Add(b_save);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 256);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(5, 5, 5, 10);
            bottomPanel.Size = new Size(608, 44);
            bottomPanel.TabIndex = 1;
            // 
            // b_cancel
            // 
            b_cancel.Dock = DockStyle.Right;
            b_cancel.Location = new Point(437, 5);
            b_cancel.Margin = new Padding(10);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(83, 29);
            b_cancel.TabIndex = 1;
            b_cancel.Text = "Cancel";
            b_cancel.UseVisualStyleBackColor = true;
            b_cancel.Click += b_cancel_Click;
            // 
            // b_save
            // 
            b_save.Dock = DockStyle.Right;
            b_save.Location = new Point(520, 5);
            b_save.Margin = new Padding(10);
            b_save.Name = "b_save";
            b_save.Size = new Size(83, 29);
            b_save.TabIndex = 0;
            b_save.Text = "OK";
            b_save.Click += b_save_Click;
            // 
            // WIN_Prefs
            // 
            AcceptButton = b_save;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(608, 300);
            Controls.Add(bottomPanel);
            Controls.Add(gb_configFiles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WIN_Prefs";
            Text = "QEMU Interface - Preferences";
            FormClosing += Preferences_FormClosing;
            Load += Preferences_Load;
            gb_configFiles.ResumeLayout(false);
            gb_configFiles.PerformLayout();
            bottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_configFiles;
        private Button b_selvmFolder;
        private TextBox t_vmFolder;
        private Label l_vmFolder;
        private FolderBrowserDialog fbd_vmFolder;
        private Panel bottomPanel;
        private Button b_save;
        private Button b_cancel;
    }
}