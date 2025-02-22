﻿namespace QEMUInterface
{
    partial class WIN_MAIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ImageList il_vmList;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_MAIN));
            Label ls_machineName;
            SplitContainer sc_sublist;
            Label ls_machinesText;
            p_vmList = new Panel();
            lv_vmList = new ListView();
            ms_ts_file = new ToolStripMenuItem();
            ts_file_prefs = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ts_file_exit = new ToolStripMenuItem();
            ms_ts_machine = new ToolStripMenuItem();
            ts_machine_new = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ts_machine_start = new ToolStripMenuItem();
            ts_machine_settings = new ToolStripMenuItem();
            ms_ts_about = new ToolStripMenuItem();
            ts_help_about = new ToolStripMenuItem();
            ms = new MenuStrip();
            sc_maincont = new SplitContainer();
            sc_machine = new SplitContainer();
            gb_machineState = new GroupBox();
            l_machineState = new Label();
            b_newMachine = new Button();
            b_machineSettings = new Button();
            b_startMachine = new Button();
            gb_machineDetails = new GroupBox();
            t_machineOS = new TextBox();
            t_machineName = new TextBox();
            ls_machineOS = new Label();
            p_main = new Panel();
            il_vmList = new ImageList(components);
            ls_machineName = new Label();
            sc_sublist = new SplitContainer();
            ls_machinesText = new Label();
            ((System.ComponentModel.ISupportInitialize)sc_sublist).BeginInit();
            sc_sublist.Panel1.SuspendLayout();
            sc_sublist.Panel2.SuspendLayout();
            sc_sublist.SuspendLayout();
            p_vmList.SuspendLayout();
            ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_maincont).BeginInit();
            sc_maincont.Panel1.SuspendLayout();
            sc_maincont.Panel2.SuspendLayout();
            sc_maincont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_machine).BeginInit();
            sc_machine.Panel1.SuspendLayout();
            sc_machine.Panel2.SuspendLayout();
            sc_machine.SuspendLayout();
            gb_machineState.SuspendLayout();
            gb_machineDetails.SuspendLayout();
            p_main.SuspendLayout();
            SuspendLayout();
            // 
            // il_vmList
            // 
            il_vmList.ColorDepth = ColorDepth.Depth32Bit;
            il_vmList.ImageStream = (ImageListStreamer)resources.GetObject("il_vmList.ImageStream");
            il_vmList.TransparentColor = Color.Transparent;
            il_vmList.Images.SetKeyName(0, "95.png");
            il_vmList.Images.SetKeyName(1, "winxp.png");
            il_vmList.Images.SetKeyName(2, "vista.png");
            il_vmList.Images.SetKeyName(3, "win10.png");
            // 
            // ls_machineName
            // 
            ls_machineName.AutoSize = true;
            ls_machineName.Dock = DockStyle.Left;
            ls_machineName.Location = new Point(10, 28);
            ls_machineName.Name = "ls_machineName";
            ls_machineName.Size = new Size(46, 17);
            ls_machineName.TabIndex = 1;
            ls_machineName.Text = "Name:";
            // 
            // sc_sublist
            // 
            sc_sublist.BorderStyle = BorderStyle.FixedSingle;
            sc_sublist.Dock = DockStyle.Fill;
            sc_sublist.IsSplitterFixed = true;
            sc_sublist.Location = new Point(0, 0);
            sc_sublist.Name = "sc_sublist";
            sc_sublist.Orientation = Orientation.Horizontal;
            // 
            // sc_sublist.Panel1
            // 
            sc_sublist.Panel1.Controls.Add(ls_machinesText);
            sc_sublist.Panel1.Padding = new Padding(5, 25, 5, 5);
            // 
            // sc_sublist.Panel2
            // 
            sc_sublist.Panel2.Controls.Add(p_vmList);
            sc_sublist.Size = new Size(244, 514);
            sc_sublist.SplitterDistance = 83;
            sc_sublist.TabIndex = 1;
            // 
            // ls_machinesText
            // 
            ls_machinesText.Dock = DockStyle.Fill;
            ls_machinesText.Font = new Font("MS Gothic", 22F);
            ls_machinesText.Location = new Point(5, 25);
            ls_machinesText.Margin = new Padding(0);
            ls_machinesText.Name = "ls_machinesText";
            ls_machinesText.Size = new Size(232, 51);
            ls_machinesText.TabIndex = 0;
            ls_machinesText.Text = "Machines";
            ls_machinesText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p_vmList
            // 
            p_vmList.BackColor = SystemColors.Window;
            p_vmList.Controls.Add(lv_vmList);
            p_vmList.Dock = DockStyle.Fill;
            p_vmList.Location = new Point(0, 0);
            p_vmList.Name = "p_vmList";
            p_vmList.Padding = new Padding(10, 5, 10, 5);
            p_vmList.Size = new Size(242, 425);
            p_vmList.TabIndex = 0;
            // 
            // lv_vmList
            // 
            lv_vmList.Activation = ItemActivation.OneClick;
            lv_vmList.BackColor = SystemColors.Window;
            lv_vmList.BackgroundImageTiled = true;
            lv_vmList.BorderStyle = BorderStyle.None;
            lv_vmList.Dock = DockStyle.Fill;
            lv_vmList.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_vmList.FullRowSelect = true;
            lv_vmList.GridLines = true;
            lv_vmList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_vmList.LargeImageList = il_vmList;
            lv_vmList.Location = new Point(10, 5);
            lv_vmList.Margin = new Padding(8);
            lv_vmList.MultiSelect = false;
            lv_vmList.Name = "lv_vmList";
            lv_vmList.Size = new Size(222, 415);
            lv_vmList.TabIndex = 0;
            lv_vmList.TileSize = new Size(221, 50);
            lv_vmList.UseCompatibleStateImageBehavior = false;
            lv_vmList.View = View.Tile;
            lv_vmList.SelectedIndexChanged += lv_vmList_SelectedIndexChanged;
            // 
            // ms_ts_file
            // 
            ms_ts_file.DropDownItems.AddRange(new ToolStripItem[] { ts_file_prefs, toolStripSeparator1, ts_file_exit });
            ms_ts_file.Name = "ms_ts_file";
            ms_ts_file.Size = new Size(39, 21);
            ms_ts_file.Text = "File";
            // 
            // ts_file_prefs
            // 
            ts_file_prefs.Name = "ts_file_prefs";
            ts_file_prefs.ShortcutKeys = Keys.Control | Keys.Oemcomma;
            ts_file_prefs.Size = new Size(258, 24);
            ts_file_prefs.Text = "Preferences";
            ts_file_prefs.Click += ts_file_prefs_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(255, 6);
            // 
            // ts_file_exit
            // 
            ts_file_exit.Name = "ts_file_exit";
            ts_file_exit.ShortcutKeys = Keys.Control | Keys.Q;
            ts_file_exit.Size = new Size(258, 24);
            ts_file_exit.Text = "Exit";
            ts_file_exit.Click += ts_file_exit_Click;
            // 
            // ms_ts_machine
            // 
            ms_ts_machine.DropDownItems.AddRange(new ToolStripItem[] { ts_machine_new, toolStripSeparator2, ts_machine_start, ts_machine_settings });
            ms_ts_machine.Name = "ms_ts_machine";
            ms_ts_machine.Size = new Size(69, 21);
            ms_ts_machine.Text = "Machine";
            // 
            // ts_machine_new
            // 
            ts_machine_new.Name = "ts_machine_new";
            ts_machine_new.ShortcutKeys = Keys.Control | Keys.N;
            ts_machine_new.Size = new Size(155, 24);
            ts_machine_new.Text = "New";
            ts_machine_new.Click += b_newMachine_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(152, 6);
            // 
            // ts_machine_start
            // 
            ts_machine_start.Enabled = false;
            ts_machine_start.Name = "ts_machine_start";
            ts_machine_start.Size = new Size(155, 24);
            ts_machine_start.Text = "Start";
            // 
            // ts_machine_settings
            // 
            ts_machine_settings.Enabled = false;
            ts_machine_settings.Name = "ts_machine_settings";
            ts_machine_settings.Size = new Size(155, 24);
            ts_machine_settings.Text = "Settings";
            // 
            // ms_ts_about
            // 
            ms_ts_about.DropDownItems.AddRange(new ToolStripItem[] { ts_help_about });
            ms_ts_about.Name = "ms_ts_about";
            ms_ts_about.Size = new Size(47, 21);
            ms_ts_about.Text = "Help";
            // 
            // ts_help_about
            // 
            ts_help_about.Name = "ts_help_about";
            ts_help_about.Size = new Size(117, 24);
            ts_help_about.Text = "About";
            ts_help_about.Click += ts_help_about_Click;
            // 
            // ms
            // 
            ms.ImageScalingSize = new Size(18, 18);
            ms.Items.AddRange(new ToolStripItem[] { ms_ts_file, ms_ts_machine, ms_ts_about });
            ms.Location = new Point(0, 0);
            ms.Name = "ms";
            ms.Size = new Size(724, 25);
            ms.TabIndex = 0;
            ms.Text = "menuStrip1";
            // 
            // sc_maincont
            // 
            sc_maincont.BorderStyle = BorderStyle.FixedSingle;
            sc_maincont.Dock = DockStyle.Fill;
            sc_maincont.IsSplitterFixed = true;
            sc_maincont.Location = new Point(5, 10);
            sc_maincont.Name = "sc_maincont";
            // 
            // sc_maincont.Panel1
            // 
            sc_maincont.Panel1.Controls.Add(sc_sublist);
            sc_maincont.Panel1.Margin = new Padding(5);
            // 
            // sc_maincont.Panel2
            // 
            sc_maincont.Panel2.Controls.Add(sc_machine);
            sc_maincont.Size = new Size(714, 514);
            sc_maincont.SplitterDistance = 244;
            sc_maincont.TabIndex = 1;
            // 
            // sc_machine
            // 
            sc_machine.BorderStyle = BorderStyle.FixedSingle;
            sc_machine.Dock = DockStyle.Fill;
            sc_machine.FixedPanel = FixedPanel.Panel1;
            sc_machine.IsSplitterFixed = true;
            sc_machine.Location = new Point(0, 0);
            sc_machine.Name = "sc_machine";
            sc_machine.Orientation = Orientation.Horizontal;
            // 
            // sc_machine.Panel1
            // 
            sc_machine.Panel1.Controls.Add(gb_machineState);
            sc_machine.Panel1.Controls.Add(b_newMachine);
            sc_machine.Panel1.Controls.Add(b_machineSettings);
            sc_machine.Panel1.Controls.Add(b_startMachine);
            sc_machine.Panel1.Margin = new Padding(5);
            sc_machine.Panel1.Padding = new Padding(10);
            // 
            // sc_machine.Panel2
            // 
            sc_machine.Panel2.Controls.Add(gb_machineDetails);
            sc_machine.Panel2.Margin = new Padding(5);
            sc_machine.Panel2.Padding = new Padding(10);
            sc_machine.Size = new Size(466, 514);
            sc_machine.SplitterDistance = 84;
            sc_machine.TabIndex = 0;
            // 
            // gb_machineState
            // 
            gb_machineState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gb_machineState.Controls.Add(l_machineState);
            gb_machineState.Location = new Point(146, 1);
            gb_machineState.Name = "gb_machineState";
            gb_machineState.Padding = new Padding(5);
            gb_machineState.Size = new Size(108, 75);
            gb_machineState.TabIndex = 2;
            gb_machineState.TabStop = false;
            gb_machineState.Text = "Machine State";
            // 
            // l_machineState
            // 
            l_machineState.Font = new Font("Lucida Console", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_machineState.ForeColor = Color.FromArgb(192, 0, 0);
            l_machineState.Location = new Point(5, 17);
            l_machineState.Margin = new Padding(0);
            l_machineState.Name = "l_machineState";
            l_machineState.Size = new Size(98, 46);
            l_machineState.TabIndex = 0;
            l_machineState.Text = "STOPPED";
            l_machineState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // b_newMachine
            // 
            b_newMachine.Location = new Point(14, 8);
            b_newMachine.Margin = new Padding(10, 0, 10, 0);
            b_newMachine.Name = "b_newMachine";
            b_newMachine.Size = new Size(86, 68);
            b_newMachine.TabIndex = 0;
            b_newMachine.Text = "New Machine";
            b_newMachine.UseVisualStyleBackColor = true;
            b_newMachine.Click += b_newMachine_Click;
            // 
            // b_machineSettings
            // 
            b_machineSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            b_machineSettings.Location = new Point(365, 8);
            b_machineSettings.Margin = new Padding(10);
            b_machineSettings.Name = "b_machineSettings";
            b_machineSettings.Size = new Size(82, 68);
            b_machineSettings.TabIndex = 1;
            b_machineSettings.Text = "Settings";
            b_machineSettings.UseVisualStyleBackColor = true;
            b_machineSettings.Click += b_machineSettings_Click;
            // 
            // b_startMachine
            // 
            b_startMachine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            b_startMachine.BackColor = Color.FromArgb(128, 255, 128);
            b_startMachine.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_startMachine.Location = new Point(267, 8);
            b_startMachine.Margin = new Padding(10);
            b_startMachine.Name = "b_startMachine";
            b_startMachine.Size = new Size(82, 68);
            b_startMachine.TabIndex = 0;
            b_startMachine.Text = "Launch";
            b_startMachine.UseVisualStyleBackColor = false;
            b_startMachine.Click += b_startMachine_Click;
            // 
            // gb_machineDetails
            // 
            gb_machineDetails.AutoSize = true;
            gb_machineDetails.BackgroundImageLayout = ImageLayout.Stretch;
            gb_machineDetails.Controls.Add(t_machineOS);
            gb_machineDetails.Controls.Add(t_machineName);
            gb_machineDetails.Controls.Add(ls_machineOS);
            gb_machineDetails.Controls.Add(ls_machineName);
            gb_machineDetails.Dock = DockStyle.Top;
            gb_machineDetails.Location = new Point(10, 10);
            gb_machineDetails.Name = "gb_machineDetails";
            gb_machineDetails.Padding = new Padding(10);
            gb_machineDetails.Size = new Size(444, 115);
            gb_machineDetails.TabIndex = 0;
            gb_machineDetails.TabStop = false;
            gb_machineDetails.Text = "Machine Information";
            // 
            // t_machineOS
            // 
            t_machineOS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            t_machineOS.BackColor = SystemColors.HighlightText;
            t_machineOS.BorderStyle = BorderStyle.FixedSingle;
            t_machineOS.Enabled = false;
            t_machineOS.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_machineOS.Location = new Point(139, 59);
            t_machineOS.Name = "t_machineOS";
            t_machineOS.ReadOnly = true;
            t_machineOS.ShortcutsEnabled = false;
            t_machineOS.Size = new Size(292, 25);
            t_machineOS.TabIndex = 5;
            // 
            // t_machineName
            // 
            t_machineName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            t_machineName.BackColor = SystemColors.HighlightText;
            t_machineName.BorderStyle = BorderStyle.FixedSingle;
            t_machineName.CausesValidation = false;
            t_machineName.Enabled = false;
            t_machineName.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_machineName.HideSelection = false;
            t_machineName.Location = new Point(139, 25);
            t_machineName.Name = "t_machineName";
            t_machineName.ReadOnly = true;
            t_machineName.ShortcutsEnabled = false;
            t_machineName.Size = new Size(292, 25);
            t_machineName.TabIndex = 4;
            // 
            // ls_machineOS
            // 
            ls_machineOS.AutoSize = true;
            ls_machineOS.Location = new Point(10, 62);
            ls_machineOS.Name = "ls_machineOS";
            ls_machineOS.Size = new Size(115, 17);
            ls_machineOS.TabIndex = 3;
            ls_machineOS.Text = "Operating System:";
            // 
            // p_main
            // 
            p_main.Controls.Add(sc_maincont);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 25);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(5, 10, 5, 10);
            p_main.Size = new Size(724, 534);
            p_main.TabIndex = 2;
            // 
            // WIN_MAIN
            // 
            AcceptButton = b_startMachine;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 559);
            Controls.Add(p_main);
            Controls.Add(ms);
            MainMenuStrip = ms;
            MinimumSize = new Size(740, 600);
            Name = "WIN_MAIN";
            Text = "QEMU Interface";
            sc_sublist.Panel1.ResumeLayout(false);
            sc_sublist.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_sublist).EndInit();
            sc_sublist.ResumeLayout(false);
            p_vmList.ResumeLayout(false);
            ms.ResumeLayout(false);
            ms.PerformLayout();
            sc_maincont.Panel1.ResumeLayout(false);
            sc_maincont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_maincont).EndInit();
            sc_maincont.ResumeLayout(false);
            sc_machine.Panel1.ResumeLayout(false);
            sc_machine.Panel2.ResumeLayout(false);
            sc_machine.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sc_machine).EndInit();
            sc_machine.ResumeLayout(false);
            gb_machineState.ResumeLayout(false);
            gb_machineDetails.ResumeLayout(false);
            gb_machineDetails.PerformLayout();
            p_main.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem ms_ts_file;
        private ToolStripMenuItem ts_file_exit;
        private ToolStripMenuItem ms_ts_machine;
        private ToolStripMenuItem ms_ts_about;
        private ToolStripMenuItem ts_help_about;
        private MenuStrip ms;
        private SplitContainer sc_maincont;
        private SplitContainer sc_machine;
        private Button b_startMachine;
        private Button b_machineSettings;
        private ToolStripMenuItem ts_machine_start;
        private ToolStripMenuItem ts_machine_settings;
        private ToolStripMenuItem ts_file_prefs;
        private ToolStripSeparator toolStripSeparator1;
        private Button b_newMachine;
        private ToolStripMenuItem ts_machine_new;
        private ToolStripSeparator toolStripSeparator2;
        private GroupBox gb_machineDetails;
        private GroupBox gb_machineState;
        private Label l_machineState;
        private Panel p_main;
        private ListView lv_vmList;
        private ImageList il_vmList;
        private Panel p_vmList;
        private Label ls_machineOS;
        private TextBox t_machineName;
        private TextBox t_machineOS;
    }
}
