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
            Label ls_machinesText;
            Label ls_machineOS;
            TableLayoutPanel tlp_machineInfo;
            Label ls_pcType;
            TableLayoutPanel tlp_cpuTab;
            Label ls_cpuCores;
            Label ls_ram;
            TableLayoutPanel tlp_graphicsAndSound;
            Label ls_graphicsController;
            Label ls_soundController;
            ToolStripSeparator sep_file_1;
            ToolStripSeparator sep_machine_1;
            TableLayoutPanel tlp_mediaTab;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_MAIN));
            t_machineType = new TextBox();
            t_machineOS = new TextBox();
            t_machineName = new TextBox();
            l_machineSubversion = new Label();
            t_machineSubversion = new TextBox();
            t_ram = new TextBox();
            t_cpuCores = new TextBox();
            t_soundController = new TextBox();
            t_graphicsController = new TextBox();
            b_editMedia = new Button();
            lv_vmList = new ListView();
            il_vmList = new ImageList(components);
            gb_machineDetails = new GroupBox();
            tc_vmInfo = new TabControl();
            tc_vmInfo_media = new TabPage();
            tc_vmInfo_cpu = new TabPage();
            tc_vmInfo_gpu = new TabPage();
            ms_ts_file = new ToolStripMenuItem();
            ts_file_refresh = new ToolStripMenuItem();
            ts_file_prefs = new ToolStripMenuItem();
            ts_file_exit = new ToolStripMenuItem();
            ms_ts_machine = new ToolStripMenuItem();
            ts_machine_new = new ToolStripMenuItem();
            ts_machine_start = new ToolStripMenuItem();
            ts_machine_settings = new ToolStripMenuItem();
            ms_ts_about = new ToolStripMenuItem();
            ts_help_about = new ToolStripMenuItem();
            ms = new MenuStrip();
            gb_machineState = new GroupBox();
            l_machineState = new Label();
            b_newMachine = new Button();
            b_machineSettings = new Button();
            b_startMachine = new Button();
            p_main = new Panel();
            tlp_main = new TableLayoutPanel();
            tlp_vmControl = new TableLayoutPanel();
            ls_machineName = new Label();
            ls_machinesText = new Label();
            ls_machineOS = new Label();
            tlp_machineInfo = new TableLayoutPanel();
            ls_pcType = new Label();
            tlp_cpuTab = new TableLayoutPanel();
            ls_cpuCores = new Label();
            ls_ram = new Label();
            tlp_graphicsAndSound = new TableLayoutPanel();
            ls_graphicsController = new Label();
            ls_soundController = new Label();
            sep_file_1 = new ToolStripSeparator();
            sep_machine_1 = new ToolStripSeparator();
            tlp_mediaTab = new TableLayoutPanel();
            tlp_machineInfo.SuspendLayout();
            tlp_cpuTab.SuspendLayout();
            tlp_graphicsAndSound.SuspendLayout();
            tlp_mediaTab.SuspendLayout();
            gb_machineDetails.SuspendLayout();
            tc_vmInfo.SuspendLayout();
            tc_vmInfo_media.SuspendLayout();
            tc_vmInfo_cpu.SuspendLayout();
            tc_vmInfo_gpu.SuspendLayout();
            ms.SuspendLayout();
            gb_machineState.SuspendLayout();
            p_main.SuspendLayout();
            tlp_main.SuspendLayout();
            tlp_vmControl.SuspendLayout();
            SuspendLayout();
            // 
            // ls_machineName
            // 
            ls_machineName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_machineName.AutoSize = true;
            ls_machineName.Location = new Point(79, 5);
            ls_machineName.Margin = new Padding(10, 5, 5, 5);
            ls_machineName.Name = "ls_machineName";
            ls_machineName.Size = new Size(46, 25);
            ls_machineName.TabIndex = 1;
            ls_machineName.Text = "Name:";
            ls_machineName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_machinesText
            // 
            ls_machinesText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ls_machinesText.Font = new Font("Microsoft Sans Serif", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ls_machinesText.Location = new Point(4, 22);
            ls_machinesText.Name = "ls_machinesText";
            ls_machinesText.Size = new Size(282, 52);
            ls_machinesText.TabIndex = 0;
            ls_machinesText.Text = "Machines";
            ls_machinesText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ls_machineOS
            // 
            ls_machineOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_machineOS.AutoSize = true;
            ls_machineOS.Location = new Point(10, 75);
            ls_machineOS.Margin = new Padding(10, 5, 5, 5);
            ls_machineOS.Name = "ls_machineOS";
            ls_machineOS.Size = new Size(115, 25);
            ls_machineOS.TabIndex = 3;
            ls_machineOS.Text = "Operating System:";
            ls_machineOS.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlp_machineInfo
            // 
            tlp_machineInfo.AutoSize = true;
            tlp_machineInfo.ColumnCount = 2;
            tlp_machineInfo.ColumnStyles.Add(new ColumnStyle());
            tlp_machineInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_machineInfo.Controls.Add(ls_machineName, 0, 0);
            tlp_machineInfo.Controls.Add(ls_pcType, 0, 1);
            tlp_machineInfo.Controls.Add(ls_machineOS, 0, 2);
            tlp_machineInfo.Controls.Add(t_machineType, 1, 1);
            tlp_machineInfo.Controls.Add(t_machineOS, 1, 2);
            tlp_machineInfo.Controls.Add(t_machineName, 1, 0);
            tlp_machineInfo.Controls.Add(l_machineSubversion, 0, 3);
            tlp_machineInfo.Controls.Add(t_machineSubversion, 1, 3);
            tlp_machineInfo.Dock = DockStyle.Fill;
            tlp_machineInfo.Location = new Point(10, 28);
            tlp_machineInfo.Name = "tlp_machineInfo";
            tlp_machineInfo.RowCount = 5;
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_machineInfo.Size = new Size(483, 168);
            tlp_machineInfo.TabIndex = 6;
            // 
            // ls_pcType
            // 
            ls_pcType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pcType.AutoSize = true;
            ls_pcType.Location = new Point(34, 40);
            ls_pcType.Margin = new Padding(10, 5, 5, 5);
            ls_pcType.Name = "ls_pcType";
            ls_pcType.Size = new Size(91, 25);
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
            t_machineType.Location = new Point(135, 40);
            t_machineType.Margin = new Padding(5);
            t_machineType.Name = "t_machineType";
            t_machineType.ReadOnly = true;
            t_machineType.ShortcutsEnabled = false;
            t_machineType.Size = new Size(343, 25);
            t_machineType.TabIndex = 7;
            // 
            // t_machineOS
            // 
            t_machineOS.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_machineOS.BackColor = SystemColors.HighlightText;
            t_machineOS.BorderStyle = BorderStyle.FixedSingle;
            t_machineOS.Enabled = false;
            t_machineOS.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_machineOS.Location = new Point(135, 75);
            t_machineOS.Margin = new Padding(5);
            t_machineOS.Name = "t_machineOS";
            t_machineOS.ReadOnly = true;
            t_machineOS.ShortcutsEnabled = false;
            t_machineOS.Size = new Size(343, 25);
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
            t_machineName.Location = new Point(135, 5);
            t_machineName.Margin = new Padding(5);
            t_machineName.Name = "t_machineName";
            t_machineName.ReadOnly = true;
            t_machineName.ShortcutsEnabled = false;
            t_machineName.Size = new Size(343, 25);
            t_machineName.TabIndex = 4;
            t_machineName.Tag = "";
            // 
            // l_machineSubversion
            // 
            l_machineSubversion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            l_machineSubversion.AutoSize = true;
            l_machineSubversion.Location = new Point(50, 110);
            l_machineSubversion.Margin = new Padding(10, 5, 5, 5);
            l_machineSubversion.Name = "l_machineSubversion";
            l_machineSubversion.Size = new Size(75, 25);
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
            t_machineSubversion.Location = new Point(135, 110);
            t_machineSubversion.Margin = new Padding(5);
            t_machineSubversion.Name = "t_machineSubversion";
            t_machineSubversion.ReadOnly = true;
            t_machineSubversion.ShortcutsEnabled = false;
            t_machineSubversion.Size = new Size(343, 25);
            t_machineSubversion.TabIndex = 9;
            // 
            // tlp_cpuTab
            // 
            tlp_cpuTab.ColumnCount = 2;
            tlp_cpuTab.ColumnStyles.Add(new ColumnStyle());
            tlp_cpuTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.83019F));
            tlp_cpuTab.Controls.Add(ls_cpuCores, 0, 0);
            tlp_cpuTab.Controls.Add(ls_ram, 0, 1);
            tlp_cpuTab.Controls.Add(t_ram, 1, 1);
            tlp_cpuTab.Controls.Add(t_cpuCores, 1, 0);
            tlp_cpuTab.Dock = DockStyle.Fill;
            tlp_cpuTab.Location = new Point(3, 3);
            tlp_cpuTab.Name = "tlp_cpuTab";
            tlp_cpuTab.RowCount = 3;
            tlp_cpuTab.RowStyles.Add(new RowStyle());
            tlp_cpuTab.RowStyles.Add(new RowStyle());
            tlp_cpuTab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_cpuTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_cpuTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_cpuTab.Size = new Size(489, 293);
            tlp_cpuTab.TabIndex = 7;
            // 
            // ls_cpuCores
            // 
            ls_cpuCores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_cpuCores.AutoSize = true;
            ls_cpuCores.Location = new Point(10, 5);
            ls_cpuCores.Margin = new Padding(10, 5, 5, 5);
            ls_cpuCores.Name = "ls_cpuCores";
            ls_cpuCores.Size = new Size(73, 25);
            ls_cpuCores.TabIndex = 1;
            ls_cpuCores.Text = "CPU Cores:";
            ls_cpuCores.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_ram
            // 
            ls_ram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_ram.AutoSize = true;
            ls_ram.Location = new Point(44, 40);
            ls_ram.Margin = new Padding(10, 5, 5, 5);
            ls_ram.Name = "ls_ram";
            ls_ram.Size = new Size(39, 25);
            ls_ram.TabIndex = 6;
            ls_ram.Text = "RAM:";
            ls_ram.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_ram
            // 
            t_ram.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_ram.BackColor = SystemColors.HighlightText;
            t_ram.BorderStyle = BorderStyle.FixedSingle;
            t_ram.CausesValidation = false;
            t_ram.Enabled = false;
            t_ram.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_ram.HideSelection = false;
            t_ram.Location = new Point(93, 40);
            t_ram.Margin = new Padding(5);
            t_ram.Name = "t_ram";
            t_ram.ReadOnly = true;
            t_ram.ShortcutsEnabled = false;
            t_ram.Size = new Size(391, 25);
            t_ram.TabIndex = 7;
            // 
            // t_cpuCores
            // 
            t_cpuCores.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_cpuCores.BackColor = SystemColors.HighlightText;
            t_cpuCores.BorderStyle = BorderStyle.FixedSingle;
            t_cpuCores.CausesValidation = false;
            t_cpuCores.Enabled = false;
            t_cpuCores.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_cpuCores.HideSelection = false;
            t_cpuCores.Location = new Point(93, 5);
            t_cpuCores.Margin = new Padding(5);
            t_cpuCores.Name = "t_cpuCores";
            t_cpuCores.ReadOnly = true;
            t_cpuCores.ShortcutsEnabled = false;
            t_cpuCores.Size = new Size(391, 25);
            t_cpuCores.TabIndex = 4;
            // 
            // tlp_graphicsAndSound
            // 
            tlp_graphicsAndSound.ColumnCount = 2;
            tlp_graphicsAndSound.ColumnStyles.Add(new ColumnStyle());
            tlp_graphicsAndSound.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.83019F));
            tlp_graphicsAndSound.Controls.Add(ls_graphicsController, 0, 0);
            tlp_graphicsAndSound.Controls.Add(ls_soundController, 0, 1);
            tlp_graphicsAndSound.Controls.Add(t_soundController, 1, 1);
            tlp_graphicsAndSound.Controls.Add(t_graphicsController, 1, 0);
            tlp_graphicsAndSound.Dock = DockStyle.Fill;
            tlp_graphicsAndSound.Location = new Point(3, 3);
            tlp_graphicsAndSound.Name = "tlp_graphicsAndSound";
            tlp_graphicsAndSound.RowCount = 3;
            tlp_graphicsAndSound.RowStyles.Add(new RowStyle());
            tlp_graphicsAndSound.RowStyles.Add(new RowStyle());
            tlp_graphicsAndSound.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_graphicsAndSound.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_graphicsAndSound.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_graphicsAndSound.Size = new Size(489, 293);
            tlp_graphicsAndSound.TabIndex = 8;
            // 
            // ls_graphicsController
            // 
            ls_graphicsController.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_graphicsController.AutoSize = true;
            ls_graphicsController.Location = new Point(10, 5);
            ls_graphicsController.Margin = new Padding(10, 5, 5, 5);
            ls_graphicsController.Name = "ls_graphicsController";
            ls_graphicsController.Size = new Size(124, 25);
            ls_graphicsController.TabIndex = 1;
            ls_graphicsController.Text = "Graphics Controller:";
            ls_graphicsController.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_soundController
            // 
            ls_soundController.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_soundController.AutoSize = true;
            ls_soundController.Location = new Point(24, 40);
            ls_soundController.Margin = new Padding(10, 5, 5, 5);
            ls_soundController.Name = "ls_soundController";
            ls_soundController.Size = new Size(110, 25);
            ls_soundController.TabIndex = 6;
            ls_soundController.Text = "Sound Controller:";
            ls_soundController.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_soundController
            // 
            t_soundController.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_soundController.BackColor = SystemColors.HighlightText;
            t_soundController.BorderStyle = BorderStyle.FixedSingle;
            t_soundController.CausesValidation = false;
            t_soundController.Enabled = false;
            t_soundController.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_soundController.HideSelection = false;
            t_soundController.Location = new Point(144, 40);
            t_soundController.Margin = new Padding(5);
            t_soundController.Name = "t_soundController";
            t_soundController.ReadOnly = true;
            t_soundController.ShortcutsEnabled = false;
            t_soundController.Size = new Size(340, 25);
            t_soundController.TabIndex = 7;
            // 
            // t_graphicsController
            // 
            t_graphicsController.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_graphicsController.BackColor = SystemColors.HighlightText;
            t_graphicsController.BorderStyle = BorderStyle.FixedSingle;
            t_graphicsController.CausesValidation = false;
            t_graphicsController.Enabled = false;
            t_graphicsController.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_graphicsController.HideSelection = false;
            t_graphicsController.Location = new Point(144, 5);
            t_graphicsController.Margin = new Padding(5);
            t_graphicsController.Name = "t_graphicsController";
            t_graphicsController.ReadOnly = true;
            t_graphicsController.ShortcutsEnabled = false;
            t_graphicsController.Size = new Size(340, 25);
            t_graphicsController.TabIndex = 4;
            // 
            // sep_file_1
            // 
            sep_file_1.Name = "sep_file_1";
            sep_file_1.Size = new Size(255, 6);
            // 
            // sep_machine_1
            // 
            sep_machine_1.Name = "sep_machine_1";
            sep_machine_1.Size = new Size(152, 6);
            // 
            // tlp_mediaTab
            // 
            tlp_mediaTab.ColumnCount = 2;
            tlp_mediaTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_mediaTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_mediaTab.Controls.Add(b_editMedia, 0, 0);
            tlp_mediaTab.Dock = DockStyle.Fill;
            tlp_mediaTab.Location = new Point(3, 3);
            tlp_mediaTab.Name = "tlp_mediaTab";
            tlp_mediaTab.RowCount = 2;
            tlp_mediaTab.RowStyles.Add(new RowStyle(SizeType.Percent, 35.1535835F));
            tlp_mediaTab.RowStyles.Add(new RowStyle(SizeType.Percent, 64.84641F));
            tlp_mediaTab.Size = new Size(489, 293);
            tlp_mediaTab.TabIndex = 2;
            // 
            // b_editMedia
            // 
            b_editMedia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b_editMedia.Location = new Point(5, 5);
            b_editMedia.Margin = new Padding(5);
            b_editMedia.Name = "b_editMedia";
            b_editMedia.Size = new Size(234, 93);
            b_editMedia.TabIndex = 0;
            b_editMedia.Text = "Edit Media";
            b_editMedia.UseVisualStyleBackColor = true;
            b_editMedia.Click += button1_Click;
            // 
            // lv_vmList
            // 
            lv_vmList.Activation = ItemActivation.OneClick;
            lv_vmList.Alignment = ListViewAlignment.SnapToGrid;
            lv_vmList.AllowColumnReorder = true;
            lv_vmList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lv_vmList.BackColor = SystemColors.Control;
            lv_vmList.BorderStyle = BorderStyle.FixedSingle;
            lv_vmList.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_vmList.FullRowSelect = true;
            lv_vmList.GridLines = true;
            lv_vmList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_vmList.ImeMode = ImeMode.NoControl;
            lv_vmList.LargeImageList = il_vmList;
            lv_vmList.Location = new Point(4, 100);
            lv_vmList.MultiSelect = false;
            lv_vmList.Name = "lv_vmList";
            tlp_main.SetRowSpan(lv_vmList, 2);
            lv_vmList.Size = new Size(282, 550);
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
            // gb_machineDetails
            // 
            gb_machineDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_machineDetails.AutoSize = true;
            gb_machineDetails.BackgroundImageLayout = ImageLayout.Stretch;
            gb_machineDetails.Controls.Add(tlp_machineInfo);
            gb_machineDetails.Location = new Point(300, 102);
            gb_machineDetails.Margin = new Padding(10, 5, 10, 5);
            gb_machineDetails.Name = "gb_machineDetails";
            gb_machineDetails.Padding = new Padding(10);
            gb_machineDetails.Size = new Size(503, 206);
            gb_machineDetails.TabIndex = 0;
            gb_machineDetails.TabStop = false;
            gb_machineDetails.Text = "Machine Information";
            // 
            // tc_vmInfo
            // 
            tc_vmInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tc_vmInfo.Controls.Add(tc_vmInfo_media);
            tc_vmInfo.Controls.Add(tc_vmInfo_cpu);
            tc_vmInfo.Controls.Add(tc_vmInfo_gpu);
            tc_vmInfo.Location = new Point(300, 319);
            tc_vmInfo.Margin = new Padding(10, 5, 10, 5);
            tc_vmInfo.Multiline = true;
            tc_vmInfo.Name = "tc_vmInfo";
            tc_vmInfo.SelectedIndex = 0;
            tc_vmInfo.Size = new Size(503, 329);
            tc_vmInfo.TabIndex = 1;
            // 
            // tc_vmInfo_media
            // 
            tc_vmInfo_media.Controls.Add(tlp_mediaTab);
            tc_vmInfo_media.Location = new Point(4, 26);
            tc_vmInfo_media.Name = "tc_vmInfo_media";
            tc_vmInfo_media.Padding = new Padding(3);
            tc_vmInfo_media.Size = new Size(495, 299);
            tc_vmInfo_media.TabIndex = 2;
            tc_vmInfo_media.Text = "Media";
            tc_vmInfo_media.UseVisualStyleBackColor = true;
            // 
            // tc_vmInfo_cpu
            // 
            tc_vmInfo_cpu.Controls.Add(tlp_cpuTab);
            tc_vmInfo_cpu.Location = new Point(4, 26);
            tc_vmInfo_cpu.Name = "tc_vmInfo_cpu";
            tc_vmInfo_cpu.Padding = new Padding(3);
            tc_vmInfo_cpu.Size = new Size(495, 299);
            tc_vmInfo_cpu.TabIndex = 0;
            tc_vmInfo_cpu.Text = "CPU/RAM";
            tc_vmInfo_cpu.UseVisualStyleBackColor = true;
            // 
            // tc_vmInfo_gpu
            // 
            tc_vmInfo_gpu.Controls.Add(tlp_graphicsAndSound);
            tc_vmInfo_gpu.Location = new Point(4, 26);
            tc_vmInfo_gpu.Name = "tc_vmInfo_gpu";
            tc_vmInfo_gpu.Padding = new Padding(3);
            tc_vmInfo_gpu.Size = new Size(495, 299);
            tc_vmInfo_gpu.TabIndex = 1;
            tc_vmInfo_gpu.Text = "Graphics and Sound";
            tc_vmInfo_gpu.UseVisualStyleBackColor = true;
            // 
            // ms_ts_file
            // 
            ms_ts_file.DropDownItems.AddRange(new ToolStripItem[] { ts_file_refresh, sep_file_1, ts_file_prefs, ts_file_exit });
            ms_ts_file.Name = "ms_ts_file";
            ms_ts_file.Size = new Size(39, 21);
            ms_ts_file.Text = "File";
            // 
            // ts_file_refresh
            // 
            ts_file_refresh.Name = "ts_file_refresh";
            ts_file_refresh.ShortcutKeys = Keys.Control | Keys.R;
            ts_file_refresh.Size = new Size(258, 24);
            ts_file_refresh.Text = "Reload Machine List";
            ts_file_refresh.Click += ts_file_refresh_Click;
            // 
            // ts_file_prefs
            // 
            ts_file_prefs.Name = "ts_file_prefs";
            ts_file_prefs.ShortcutKeys = Keys.Control | Keys.Oemcomma;
            ts_file_prefs.Size = new Size(258, 24);
            ts_file_prefs.Text = "Preferences";
            ts_file_prefs.Click += ts_file_prefs_Click;
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
            ms_ts_machine.DropDownItems.AddRange(new ToolStripItem[] { ts_machine_new, sep_machine_1, ts_machine_start, ts_machine_settings });
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
            ms.Size = new Size(824, 25);
            ms.TabIndex = 0;
            ms.Text = "menuStrip1";
            // 
            // gb_machineState
            // 
            gb_machineState.Anchor = AnchorStyles.Right;
            gb_machineState.Controls.Add(l_machineState);
            gb_machineState.Location = new Point(209, 3);
            gb_machineState.Margin = new Padding(3, 3, 6, 10);
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
            b_newMachine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            b_newMachine.Location = new Point(10, 10);
            b_newMachine.Margin = new Padding(10, 0, 10, 0);
            b_newMachine.Name = "b_newMachine";
            b_newMachine.Size = new Size(104, 68);
            b_newMachine.TabIndex = 0;
            b_newMachine.Text = "New Machine";
            b_newMachine.UseVisualStyleBackColor = true;
            b_newMachine.Click += b_newMachine_Click;
            // 
            // b_machineSettings
            // 
            b_machineSettings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            b_machineSettings.Location = new Point(425, 11);
            b_machineSettings.Margin = new Padding(5, 10, 10, 10);
            b_machineSettings.Name = "b_machineSettings";
            b_machineSettings.Size = new Size(82, 66);
            b_machineSettings.TabIndex = 1;
            b_machineSettings.Text = "Settings";
            b_machineSettings.UseVisualStyleBackColor = true;
            b_machineSettings.Click += b_machineSettings_Click;
            // 
            // b_startMachine
            // 
            b_startMachine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            b_startMachine.BackColor = Color.FromArgb(128, 255, 128);
            b_startMachine.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_startMachine.Location = new Point(333, 11);
            b_startMachine.Margin = new Padding(10, 10, 5, 10);
            b_startMachine.Name = "b_startMachine";
            b_startMachine.Size = new Size(82, 66);
            b_startMachine.TabIndex = 0;
            b_startMachine.Text = "Launch";
            b_startMachine.UseVisualStyleBackColor = false;
            b_startMachine.Click += b_startMachine_Click;
            // 
            // p_main
            // 
            p_main.BackColor = SystemColors.Control;
            p_main.Controls.Add(tlp_main);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 25);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(5, 10, 5, 10);
            p_main.Size = new Size(824, 674);
            p_main.TabIndex = 2;
            // 
            // tlp_main
            // 
            tlp_main.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlp_main.ColumnCount = 2;
            tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.5897446F));
            tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.4102554F));
            tlp_main.Controls.Add(ls_machinesText, 0, 0);
            tlp_main.Controls.Add(lv_vmList, 0, 1);
            tlp_main.Controls.Add(tlp_vmControl, 1, 0);
            tlp_main.Controls.Add(gb_machineDetails, 1, 1);
            tlp_main.Controls.Add(tc_vmInfo, 1, 2);
            tlp_main.Dock = DockStyle.Fill;
            tlp_main.Location = new Point(5, 10);
            tlp_main.Name = "tlp_main";
            tlp_main.RowCount = 3;
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 33.28313F));
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 52.1084328F));
            tlp_main.Size = new Size(814, 654);
            tlp_main.TabIndex = 1;
            // 
            // tlp_vmControl
            // 
            tlp_vmControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_vmControl.ColumnCount = 4;
            tlp_vmControl.ColumnStyles.Add(new ColumnStyle());
            tlp_vmControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_vmControl.ColumnStyles.Add(new ColumnStyle());
            tlp_vmControl.ColumnStyles.Add(new ColumnStyle());
            tlp_vmControl.Controls.Add(b_machineSettings, 3, 0);
            tlp_vmControl.Controls.Add(b_newMachine, 0, 0);
            tlp_vmControl.Controls.Add(b_startMachine, 2, 0);
            tlp_vmControl.Controls.Add(gb_machineState, 1, 0);
            tlp_vmControl.Location = new Point(293, 4);
            tlp_vmControl.Name = "tlp_vmControl";
            tlp_vmControl.RowCount = 1;
            tlp_vmControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_vmControl.Size = new Size(517, 89);
            tlp_vmControl.TabIndex = 1;
            // 
            // WIN_MAIN
            // 
            AcceptButton = b_startMachine;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 699);
            Controls.Add(p_main);
            Controls.Add(ms);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = ms;
            MinimumSize = new Size(840, 740);
            Name = "WIN_MAIN";
            Text = "QEMU Interface";
            tlp_machineInfo.ResumeLayout(false);
            tlp_machineInfo.PerformLayout();
            tlp_cpuTab.ResumeLayout(false);
            tlp_cpuTab.PerformLayout();
            tlp_graphicsAndSound.ResumeLayout(false);
            tlp_graphicsAndSound.PerformLayout();
            tlp_mediaTab.ResumeLayout(false);
            gb_machineDetails.ResumeLayout(false);
            gb_machineDetails.PerformLayout();
            tc_vmInfo.ResumeLayout(false);
            tc_vmInfo_media.ResumeLayout(false);
            tc_vmInfo_cpu.ResumeLayout(false);
            tc_vmInfo_gpu.ResumeLayout(false);
            ms.ResumeLayout(false);
            ms.PerformLayout();
            gb_machineState.ResumeLayout(false);
            p_main.ResumeLayout(false);
            tlp_main.ResumeLayout(false);
            tlp_main.PerformLayout();
            tlp_vmControl.ResumeLayout(false);
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
        private Button b_startMachine;
        private Button b_machineSettings;
        private ToolStripMenuItem ts_machine_start;
        private ToolStripMenuItem ts_machine_settings;
        private ToolStripMenuItem ts_file_prefs;
        private ToolStripSeparator sep_file_1;
        private Button b_newMachine;
        private ToolStripMenuItem ts_machine_new;
        private ToolStripSeparator sep_machine_1;
        private GroupBox gb_machineDetails;
        private GroupBox gb_machineState;
        private Label l_machineState;
        private Panel p_main;
        private ListView lv_vmList;
        private ImageList il_vmList;
        private Label ls_machineOS;
        private TextBox t_machineName;
        private TextBox t_machineOS;
        private TableLayoutPanel tlp_machineInfo;
        private TextBox t_machineType;
        private TextBox t_machineSubversion;
        private Label l_machineSubversion;
        private ToolStripMenuItem ts_file_refresh;
        private TabControl tc_vmInfo;
        private TabPage tc_vmInfo_cpu;
        private TabPage tc_vmInfo_gpu;
        private TextBox t_ram;
        private TextBox t_cpuCores;
        private TextBox t_soundController;
        private TextBox t_graphicsController;
        private Label deburgggg;
        private Button b_editMedia;
        private TableLayoutPanel tlp_main;
        private TableLayoutPanel tlp_vmControl;
        private TableLayoutPanel tlp_mediaTab;
        private TabPage tc_vmInfo_media;
    }
}
