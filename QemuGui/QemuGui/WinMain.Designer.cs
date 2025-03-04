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
            Label ls_machineName;
            SplitContainer sc_sublist;
            Label ls_machinesText;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_MAIN));
            Label ls_machineOS;
            TableLayoutPanel tlp_machineInfo;
            Label ls_pcType;
            p_vmList = new Panel();
            lv_vmList = new ListView();
            il_vmList = new ImageList(components);
            t_machineType = new TextBox();
            t_machineOS = new TextBox();
            t_machineName = new TextBox();
            l_machineSubversion = new Label();
            t_machineSubversion = new TextBox();
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
            p_main = new Panel();
            ts_file_refresh = new ToolStripMenuItem();
            ls_machineName = new Label();
            sc_sublist = new SplitContainer();
            ls_machinesText = new Label();
            ls_machineOS = new Label();
            tlp_machineInfo = new TableLayoutPanel();
            ls_pcType = new Label();
            ((System.ComponentModel.ISupportInitialize)sc_sublist).BeginInit();
            sc_sublist.Panel1.SuspendLayout();
            sc_sublist.Panel2.SuspendLayout();
            sc_sublist.SuspendLayout();
            p_vmList.SuspendLayout();
            tlp_machineInfo.SuspendLayout();
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
            // ls_machineName
            // 
            ls_machineName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_machineName.AutoSize = true;
            ls_machineName.Location = new Point(47, 4);
            ls_machineName.Margin = new Padding(10, 4, 5, 4);
            ls_machineName.Name = "ls_machineName";
            ls_machineName.Size = new Size(42, 23);
            ls_machineName.TabIndex = 1;
            ls_machineName.Text = "Name:";
            ls_machineName.TextAlign = ContentAlignment.MiddleRight;
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
            sc_sublist.Panel1.Padding = new Padding(5, 22, 5, 4);
            // 
            // sc_sublist.Panel2
            // 
            sc_sublist.Panel2.Controls.Add(p_vmList);
            sc_sublist.Size = new Size(244, 453);
            sc_sublist.SplitterDistance = 73;
            sc_sublist.TabIndex = 1;
            // 
            // ls_machinesText
            // 
            ls_machinesText.Dock = DockStyle.Fill;
            ls_machinesText.Font = new Font("MS Gothic", 22F);
            ls_machinesText.Location = new Point(5, 22);
            ls_machinesText.Margin = new Padding(0);
            ls_machinesText.Name = "ls_machinesText";
            ls_machinesText.Size = new Size(232, 45);
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
            p_vmList.Padding = new Padding(10, 4, 10, 4);
            p_vmList.Size = new Size(242, 374);
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
            lv_vmList.Location = new Point(10, 4);
            lv_vmList.Margin = new Padding(8, 7, 8, 7);
            lv_vmList.MultiSelect = false;
            lv_vmList.Name = "lv_vmList";
            lv_vmList.Size = new Size(222, 366);
            lv_vmList.TabIndex = 0;
            lv_vmList.TileSize = new Size(221, 50);
            lv_vmList.UseCompatibleStateImageBehavior = false;
            lv_vmList.View = View.Tile;
            lv_vmList.SelectedIndexChanged += lv_vmList_SelectedIndexChanged;
            // 
            // il_vmList
            // 
            il_vmList.ColorDepth = ColorDepth.Depth32Bit;
            il_vmList.ImageStream = (ImageListStreamer)resources.GetObject("il_vmList.ImageStream");
            il_vmList.TransparentColor = Color.Transparent;
            il_vmList.Images.SetKeyName(0, "95.png");
            il_vmList.Images.SetKeyName(1, "winxp.png");
            il_vmList.Images.SetKeyName(2, "vista.png");
            il_vmList.Images.SetKeyName(3, "win7.png");
            il_vmList.Images.SetKeyName(4, "win10.png");
            il_vmList.Images.SetKeyName(5, "win11png");
            il_vmList.Images.SetKeyName(6, "applerainbow.png");
            il_vmList.Images.SetKeyName(7, "OSX");
            il_vmList.Images.SetKeyName(8, "macOS");
            il_vmList.Images.SetKeyName(9, "Tux.svg.png");
            il_vmList.Images.SetKeyName(10, "images.jpg");
            // 
            // ls_machineOS
            // 
            ls_machineOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_machineOS.AutoSize = true;
            ls_machineOS.Location = new Point(29, 73);
            ls_machineOS.Margin = new Padding(10, 4, 5, 4);
            ls_machineOS.Name = "ls_machineOS";
            ls_machineOS.Size = new Size(60, 30);
            ls_machineOS.TabIndex = 3;
            ls_machineOS.Text = "Operating System:";
            ls_machineOS.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlp_machineInfo
            // 
            tlp_machineInfo.ColumnCount = 2;
            tlp_machineInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.1698112F));
            tlp_machineInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.83019F));
            tlp_machineInfo.Controls.Add(ls_machineName, 0, 0);
            tlp_machineInfo.Controls.Add(ls_pcType, 0, 1);
            tlp_machineInfo.Controls.Add(ls_machineOS, 0, 2);
            tlp_machineInfo.Controls.Add(t_machineType, 1, 1);
            tlp_machineInfo.Controls.Add(t_machineOS, 1, 2);
            tlp_machineInfo.Controls.Add(t_machineName, 1, 0);
            tlp_machineInfo.Controls.Add(l_machineSubversion, 0, 3);
            tlp_machineInfo.Controls.Add(t_machineSubversion, 1, 3);
            tlp_machineInfo.Dock = DockStyle.Fill;
            tlp_machineInfo.Location = new Point(10, 25);
            tlp_machineInfo.Name = "tlp_machineInfo";
            tlp_machineInfo.RowCount = 5;
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_machineInfo.Size = new Size(424, 150);
            tlp_machineInfo.TabIndex = 6;
            // 
            // ls_pcType
            // 
            ls_pcType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pcType.AutoSize = true;
            ls_pcType.Location = new Point(36, 35);
            ls_pcType.Margin = new Padding(10, 4, 5, 4);
            ls_pcType.Name = "ls_pcType";
            ls_pcType.Size = new Size(53, 30);
            ls_pcType.TabIndex = 6;
            ls_pcType.Text = "Machine Type:";
            ls_pcType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_machineType
            // 
            t_machineType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_machineType.BackColor = SystemColors.HighlightText;
            t_machineType.BorderStyle = BorderStyle.FixedSingle;
            t_machineType.CausesValidation = false;
            t_machineType.Enabled = false;
            t_machineType.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_machineType.HideSelection = false;
            t_machineType.Location = new Point(99, 38);
            t_machineType.Margin = new Padding(5, 4, 5, 4);
            t_machineType.Name = "t_machineType";
            t_machineType.ReadOnly = true;
            t_machineType.ShortcutsEnabled = false;
            t_machineType.Size = new Size(320, 23);
            t_machineType.TabIndex = 7;
            // 
            // t_machineOS
            // 
            t_machineOS.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_machineOS.BackColor = SystemColors.HighlightText;
            t_machineOS.BorderStyle = BorderStyle.FixedSingle;
            t_machineOS.Enabled = false;
            t_machineOS.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_machineOS.Location = new Point(99, 76);
            t_machineOS.Margin = new Padding(5, 4, 5, 4);
            t_machineOS.Name = "t_machineOS";
            t_machineOS.ReadOnly = true;
            t_machineOS.ShortcutsEnabled = false;
            t_machineOS.Size = new Size(320, 23);
            t_machineOS.TabIndex = 5;
            // 
            // t_machineName
            // 
            t_machineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_machineName.BackColor = SystemColors.HighlightText;
            t_machineName.BorderStyle = BorderStyle.FixedSingle;
            t_machineName.CausesValidation = false;
            t_machineName.Enabled = false;
            t_machineName.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_machineName.HideSelection = false;
            t_machineName.Location = new Point(99, 4);
            t_machineName.Margin = new Padding(5, 4, 5, 4);
            t_machineName.Name = "t_machineName";
            t_machineName.ReadOnly = true;
            t_machineName.ShortcutsEnabled = false;
            t_machineName.Size = new Size(320, 23);
            t_machineName.TabIndex = 4;
            // 
            // l_machineSubversion
            // 
            l_machineSubversion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            l_machineSubversion.AutoSize = true;
            l_machineSubversion.Location = new Point(21, 111);
            l_machineSubversion.Margin = new Padding(10, 4, 5, 4);
            l_machineSubversion.Name = "l_machineSubversion";
            l_machineSubversion.Size = new Size(68, 23);
            l_machineSubversion.TabIndex = 8;
            l_machineSubversion.Text = "Subversion:";
            l_machineSubversion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_machineSubversion
            // 
            t_machineSubversion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_machineSubversion.BackColor = SystemColors.HighlightText;
            t_machineSubversion.BorderStyle = BorderStyle.FixedSingle;
            t_machineSubversion.Enabled = false;
            t_machineSubversion.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_machineSubversion.Location = new Point(99, 111);
            t_machineSubversion.Margin = new Padding(5, 4, 5, 4);
            t_machineSubversion.Name = "t_machineSubversion";
            t_machineSubversion.ReadOnly = true;
            t_machineSubversion.ShortcutsEnabled = false;
            t_machineSubversion.Size = new Size(320, 23);
            t_machineSubversion.TabIndex = 9;
            // 
            // ms_ts_file
            // 
            ms_ts_file.DropDownItems.AddRange(new ToolStripItem[] { ts_file_refresh, toolStripSeparator1, ts_file_prefs, ts_file_exit });
            ms_ts_file.Name = "ms_ts_file";
            ms_ts_file.Size = new Size(37, 20);
            ms_ts_file.Text = "File";
            // 
            // ts_file_prefs
            // 
            ts_file_prefs.Name = "ts_file_prefs";
            ts_file_prefs.ShortcutKeys = Keys.Control | Keys.Oemcomma;
            ts_file_prefs.Size = new Size(236, 22);
            ts_file_prefs.Text = "Preferences";
            ts_file_prefs.Click += ts_file_prefs_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(233, 6);
            // 
            // ts_file_exit
            // 
            ts_file_exit.Name = "ts_file_exit";
            ts_file_exit.ShortcutKeys = Keys.Control | Keys.Q;
            ts_file_exit.Size = new Size(236, 22);
            ts_file_exit.Text = "Exit";
            ts_file_exit.Click += ts_file_exit_Click;
            // 
            // ms_ts_machine
            // 
            ms_ts_machine.DropDownItems.AddRange(new ToolStripItem[] { ts_machine_new, toolStripSeparator2, ts_machine_start, ts_machine_settings });
            ms_ts_machine.Name = "ms_ts_machine";
            ms_ts_machine.Size = new Size(65, 20);
            ms_ts_machine.Text = "Machine";
            // 
            // ts_machine_new
            // 
            ts_machine_new.Name = "ts_machine_new";
            ts_machine_new.ShortcutKeys = Keys.Control | Keys.N;
            ts_machine_new.Size = new Size(141, 22);
            ts_machine_new.Text = "New";
            ts_machine_new.Click += b_newMachine_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(138, 6);
            // 
            // ts_machine_start
            // 
            ts_machine_start.Enabled = false;
            ts_machine_start.Name = "ts_machine_start";
            ts_machine_start.Size = new Size(141, 22);
            ts_machine_start.Text = "Start";
            // 
            // ts_machine_settings
            // 
            ts_machine_settings.Enabled = false;
            ts_machine_settings.Name = "ts_machine_settings";
            ts_machine_settings.Size = new Size(141, 22);
            ts_machine_settings.Text = "Settings";
            // 
            // ms_ts_about
            // 
            ms_ts_about.DropDownItems.AddRange(new ToolStripItem[] { ts_help_about });
            ms_ts_about.Name = "ms_ts_about";
            ms_ts_about.Size = new Size(44, 20);
            ms_ts_about.Text = "Help";
            // 
            // ts_help_about
            // 
            ts_help_about.Name = "ts_help_about";
            ts_help_about.Size = new Size(107, 22);
            ts_help_about.Text = "About";
            ts_help_about.Click += ts_help_about_Click;
            // 
            // ms
            // 
            ms.ImageScalingSize = new Size(18, 18);
            ms.Items.AddRange(new ToolStripItem[] { ms_ts_file, ms_ts_machine, ms_ts_about });
            ms.Location = new Point(0, 0);
            ms.Name = "ms";
            ms.Size = new Size(724, 24);
            ms.TabIndex = 0;
            ms.Text = "menuStrip1";
            // 
            // sc_maincont
            // 
            sc_maincont.BorderStyle = BorderStyle.FixedSingle;
            sc_maincont.Dock = DockStyle.Fill;
            sc_maincont.IsSplitterFixed = true;
            sc_maincont.Location = new Point(5, 9);
            sc_maincont.Name = "sc_maincont";
            // 
            // sc_maincont.Panel1
            // 
            sc_maincont.Panel1.Controls.Add(sc_sublist);
            sc_maincont.Panel1.Margin = new Padding(5, 4, 5, 4);
            // 
            // sc_maincont.Panel2
            // 
            sc_maincont.Panel2.Controls.Add(sc_machine);
            sc_maincont.Size = new Size(714, 453);
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
            sc_machine.Panel1.Margin = new Padding(5, 4, 5, 4);
            sc_machine.Panel1.Padding = new Padding(10, 9, 10, 9);
            // 
            // sc_machine.Panel2
            // 
            sc_machine.Panel2.Controls.Add(gb_machineDetails);
            sc_machine.Panel2.Margin = new Padding(5, 4, 5, 4);
            sc_machine.Panel2.Padding = new Padding(10, 9, 10, 9);
            sc_machine.Size = new Size(466, 453);
            sc_machine.SplitterDistance = 74;
            sc_machine.TabIndex = 0;
            // 
            // gb_machineState
            // 
            gb_machineState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gb_machineState.Controls.Add(l_machineState);
            gb_machineState.Location = new Point(146, 1);
            gb_machineState.Name = "gb_machineState";
            gb_machineState.Padding = new Padding(5, 4, 5, 4);
            gb_machineState.Size = new Size(108, 66);
            gb_machineState.TabIndex = 2;
            gb_machineState.TabStop = false;
            gb_machineState.Text = "Machine State";
            // 
            // l_machineState
            // 
            l_machineState.Font = new Font("Lucida Console", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_machineState.ForeColor = Color.FromArgb(192, 0, 0);
            l_machineState.Location = new Point(5, 15);
            l_machineState.Margin = new Padding(0);
            l_machineState.Name = "l_machineState";
            l_machineState.Size = new Size(98, 41);
            l_machineState.TabIndex = 0;
            l_machineState.Text = "STOPPED";
            l_machineState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // b_newMachine
            // 
            b_newMachine.Location = new Point(14, 7);
            b_newMachine.Margin = new Padding(10, 0, 10, 0);
            b_newMachine.Name = "b_newMachine";
            b_newMachine.Size = new Size(86, 60);
            b_newMachine.TabIndex = 0;
            b_newMachine.Text = "New Machine";
            b_newMachine.UseVisualStyleBackColor = true;
            b_newMachine.Click += b_newMachine_Click;
            // 
            // b_machineSettings
            // 
            b_machineSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            b_machineSettings.Location = new Point(365, 7);
            b_machineSettings.Margin = new Padding(10, 9, 10, 9);
            b_machineSettings.Name = "b_machineSettings";
            b_machineSettings.Size = new Size(82, 60);
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
            b_startMachine.Location = new Point(267, 7);
            b_startMachine.Margin = new Padding(10, 9, 10, 9);
            b_startMachine.Name = "b_startMachine";
            b_startMachine.Size = new Size(82, 60);
            b_startMachine.TabIndex = 0;
            b_startMachine.Text = "Launch";
            b_startMachine.UseVisualStyleBackColor = false;
            b_startMachine.Click += b_startMachine_Click;
            // 
            // gb_machineDetails
            // 
            gb_machineDetails.BackgroundImageLayout = ImageLayout.Stretch;
            gb_machineDetails.Controls.Add(tlp_machineInfo);
            gb_machineDetails.Dock = DockStyle.Top;
            gb_machineDetails.Location = new Point(10, 9);
            gb_machineDetails.Name = "gb_machineDetails";
            gb_machineDetails.Padding = new Padding(10, 9, 10, 9);
            gb_machineDetails.Size = new Size(444, 184);
            gb_machineDetails.TabIndex = 0;
            gb_machineDetails.TabStop = false;
            gb_machineDetails.Text = "Machine Information";
            // 
            // p_main
            // 
            p_main.Controls.Add(sc_maincont);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 24);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(5, 9, 5, 9);
            p_main.Size = new Size(724, 471);
            p_main.TabIndex = 2;
            // 
            // ts_file_refresh
            // 
            ts_file_refresh.Name = "ts_file_refresh";
            ts_file_refresh.ShortcutKeys = Keys.Control | Keys.R;
            ts_file_refresh.Size = new Size(236, 22);
            ts_file_refresh.Text = "Refresh Machines";
            ts_file_refresh.Click += ts_file_refresh_Click;
            // 
            // WIN_MAIN
            // 
            AcceptButton = b_startMachine;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 495);
            Controls.Add(p_main);
            Controls.Add(ms);
            MainMenuStrip = ms;
            MinimumSize = new Size(740, 534);
            Name = "WIN_MAIN";
            Text = "QEMU Interface";
            sc_sublist.Panel1.ResumeLayout(false);
            sc_sublist.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_sublist).EndInit();
            sc_sublist.ResumeLayout(false);
            p_vmList.ResumeLayout(false);
            tlp_machineInfo.ResumeLayout(false);
            tlp_machineInfo.PerformLayout();
            ms.ResumeLayout(false);
            ms.PerformLayout();
            sc_maincont.Panel1.ResumeLayout(false);
            sc_maincont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_maincont).EndInit();
            sc_maincont.ResumeLayout(false);
            sc_machine.Panel1.ResumeLayout(false);
            sc_machine.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_machine).EndInit();
            sc_machine.ResumeLayout(false);
            gb_machineState.ResumeLayout(false);
            gb_machineDetails.ResumeLayout(false);
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
        private TableLayoutPanel tlp_machineInfo;
        private TextBox t_machineType;
        private TextBox t_machineSubversion;
        private Label l_machineSubversion;
        private ToolStripMenuItem ts_file_refresh;
    }
}
