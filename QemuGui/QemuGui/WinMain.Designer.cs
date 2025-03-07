namespace QEMUInterface
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
            TableLayoutPanel tlp_cpuTab;
            Label ls_cpuCores;
            Label ls_ram;
            TableLayoutPanel tableLayoutPanel1;
            Label ls_graphicsController;
            Label label2;
            ToolStripSeparator sep1;
            ToolStripSeparator sep2;
            p_vmList = new Panel();
            lv_vmList = new ListView();
            il_vmList = new ImageList(components);
            t_machineType = new TextBox();
            t_machineOS = new TextBox();
            t_machineName = new TextBox();
            l_machineSubversion = new Label();
            t_machineSubversion = new TextBox();
            gb_machineDetails = new GroupBox();
            tc_vmInfo = new TabControl();
            tc_vmInfo_cpu = new TabPage();
            t_ram = new TextBox();
            t_cpuCores = new TextBox();
            tc_vmInfo_gpu = new TabPage();
            textBox1 = new TextBox();
            t_graphicsController = new TextBox();
            tc_vmInfo_media = new TabPage();
            label1 = new Label();
            button1 = new Button();
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
            sc_maincont = new SplitContainer();
            sc_machine = new SplitContainer();
            gb_machineState = new GroupBox();
            l_machineState = new Label();
            b_newMachine = new Button();
            b_machineSettings = new Button();
            b_startMachine = new Button();
            p_main = new Panel();
            ls_machineName = new Label();
            sc_sublist = new SplitContainer();
            ls_machinesText = new Label();
            ls_machineOS = new Label();
            tlp_machineInfo = new TableLayoutPanel();
            ls_pcType = new Label();
            tlp_cpuTab = new TableLayoutPanel();
            ls_cpuCores = new Label();
            ls_ram = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ls_graphicsController = new Label();
            label2 = new Label();
            sep1 = new ToolStripSeparator();
            sep2 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)sc_sublist).BeginInit();
            sc_sublist.Panel1.SuspendLayout();
            sc_sublist.Panel2.SuspendLayout();
            sc_sublist.SuspendLayout();
            p_vmList.SuspendLayout();
            tlp_machineInfo.SuspendLayout();
            gb_machineDetails.SuspendLayout();
            tc_vmInfo.SuspendLayout();
            tc_vmInfo_cpu.SuspendLayout();
            tlp_cpuTab.SuspendLayout();
            tc_vmInfo_gpu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tc_vmInfo_media.SuspendLayout();
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
            p_main.SuspendLayout();
            SuspendLayout();
            // 
            // ls_machineName
            // 
            ls_machineName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_machineName.AutoSize = true;
            ls_machineName.Location = new Point(78, 5);
            ls_machineName.Margin = new Padding(10, 5, 5, 5);
            ls_machineName.Name = "ls_machineName";
            ls_machineName.Size = new Size(46, 25);
            ls_machineName.TabIndex = 1;
            ls_machineName.Text = "Name:";
            ls_machineName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sc_sublist
            // 
            sc_sublist.BorderStyle = BorderStyle.FixedSingle;
            sc_sublist.Dock = DockStyle.Fill;
            sc_sublist.FixedPanel = FixedPanel.Panel1;
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
            sc_sublist.Size = new Size(331, 646);
            sc_sublist.SplitterDistance = 84;
            sc_sublist.SplitterWidth = 5;
            sc_sublist.TabIndex = 1;
            // 
            // ls_machinesText
            // 
            ls_machinesText.Dock = DockStyle.Fill;
            ls_machinesText.Font = new Font("MS Gothic", 22F);
            ls_machinesText.Location = new Point(5, 25);
            ls_machinesText.Margin = new Padding(0);
            ls_machinesText.Name = "ls_machinesText";
            ls_machinesText.Size = new Size(319, 52);
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
            p_vmList.Size = new Size(329, 555);
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
            lv_vmList.Size = new Size(309, 545);
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
            ls_machineOS.Location = new Point(57, 75);
            ls_machineOS.Margin = new Padding(10, 5, 5, 5);
            ls_machineOS.Name = "ls_machineOS";
            ls_machineOS.Size = new Size(67, 34);
            ls_machineOS.TabIndex = 3;
            ls_machineOS.Text = "Operating System:";
            ls_machineOS.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlp_machineInfo
            // 
            tlp_machineInfo.AutoSize = true;
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
            tlp_machineInfo.Location = new Point(10, 28);
            tlp_machineInfo.Name = "tlp_machineInfo";
            tlp_machineInfo.RowCount = 5;
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle());
            tlp_machineInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_machineInfo.Size = new Size(586, 140);
            tlp_machineInfo.TabIndex = 6;
            // 
            // ls_pcType
            // 
            ls_pcType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pcType.AutoSize = true;
            ls_pcType.Location = new Point(33, 40);
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
            t_machineType.Location = new Point(134, 40);
            t_machineType.Margin = new Padding(5);
            t_machineType.Name = "t_machineType";
            t_machineType.ReadOnly = true;
            t_machineType.ShortcutsEnabled = false;
            t_machineType.Size = new Size(447, 25);
            t_machineType.TabIndex = 7;
            // 
            // t_machineOS
            // 
            t_machineOS.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_machineOS.BackColor = SystemColors.HighlightText;
            t_machineOS.BorderStyle = BorderStyle.FixedSingle;
            t_machineOS.Enabled = false;
            t_machineOS.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            t_machineOS.Location = new Point(134, 79);
            t_machineOS.Margin = new Padding(5);
            t_machineOS.Name = "t_machineOS";
            t_machineOS.ReadOnly = true;
            t_machineOS.ShortcutsEnabled = false;
            t_machineOS.Size = new Size(447, 25);
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
            t_machineName.Location = new Point(134, 5);
            t_machineName.Margin = new Padding(5);
            t_machineName.Name = "t_machineName";
            t_machineName.ReadOnly = true;
            t_machineName.ShortcutsEnabled = false;
            t_machineName.Size = new Size(447, 25);
            t_machineName.TabIndex = 4;
            // 
            // l_machineSubversion
            // 
            l_machineSubversion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            l_machineSubversion.AutoSize = true;
            l_machineSubversion.Location = new Point(49, 119);
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
            t_machineSubversion.Location = new Point(134, 119);
            t_machineSubversion.Margin = new Padding(5);
            t_machineSubversion.Name = "t_machineSubversion";
            t_machineSubversion.ReadOnly = true;
            t_machineSubversion.ShortcutsEnabled = false;
            t_machineSubversion.Size = new Size(447, 25);
            t_machineSubversion.TabIndex = 9;
            // 
            // gb_machineDetails
            // 
            gb_machineDetails.AutoSize = true;
            gb_machineDetails.BackgroundImageLayout = ImageLayout.Stretch;
            gb_machineDetails.Controls.Add(tlp_machineInfo);
            gb_machineDetails.Location = new Point(0, 0);
            gb_machineDetails.Margin = new Padding(3, 3, 0, 3);
            gb_machineDetails.Name = "gb_machineDetails";
            gb_machineDetails.Padding = new Padding(10);
            gb_machineDetails.Size = new Size(606, 178);
            gb_machineDetails.TabIndex = 0;
            gb_machineDetails.TabStop = false;
            gb_machineDetails.Text = "Machine Information";
            // 
            // tc_vmInfo
            // 
            tc_vmInfo.Controls.Add(tc_vmInfo_cpu);
            tc_vmInfo.Controls.Add(tc_vmInfo_gpu);
            tc_vmInfo.Controls.Add(tc_vmInfo_media);
            tc_vmInfo.Dock = DockStyle.Fill;
            tc_vmInfo.Location = new Point(0, 0);
            tc_vmInfo.Multiline = true;
            tc_vmInfo.Name = "tc_vmInfo";
            tc_vmInfo.SelectedIndex = 0;
            tc_vmInfo.Size = new Size(638, 555);
            tc_vmInfo.TabIndex = 1;
            // 
            // tc_vmInfo_cpu
            // 
            tc_vmInfo_cpu.Controls.Add(tlp_cpuTab);
            tc_vmInfo_cpu.Location = new Point(4, 26);
            tc_vmInfo_cpu.Name = "tc_vmInfo_cpu";
            tc_vmInfo_cpu.Padding = new Padding(3);
            tc_vmInfo_cpu.Size = new Size(630, 525);
            tc_vmInfo_cpu.TabIndex = 0;
            tc_vmInfo_cpu.Text = "CPU/RAM";
            tc_vmInfo_cpu.UseVisualStyleBackColor = true;
            // 
            // tlp_cpuTab
            // 
            tlp_cpuTab.ColumnCount = 2;
            tlp_cpuTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.16981F));
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
            tlp_cpuTab.Size = new Size(624, 519);
            tlp_cpuTab.TabIndex = 7;
            // 
            // ls_cpuCores
            // 
            ls_cpuCores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_cpuCores.AutoSize = true;
            ls_cpuCores.Location = new Point(88, 5);
            ls_cpuCores.Margin = new Padding(10, 5, 5, 5);
            ls_cpuCores.Name = "ls_cpuCores";
            ls_cpuCores.Size = new Size(45, 25);
            ls_cpuCores.TabIndex = 1;
            ls_cpuCores.Text = "Cores:";
            ls_cpuCores.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_ram
            // 
            ls_ram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_ram.AutoSize = true;
            ls_ram.Location = new Point(94, 40);
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
            t_ram.Location = new Point(143, 40);
            t_ram.Margin = new Padding(5);
            t_ram.Name = "t_ram";
            t_ram.ReadOnly = true;
            t_ram.ShortcutsEnabled = false;
            t_ram.Size = new Size(476, 25);
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
            t_cpuCores.Location = new Point(143, 5);
            t_cpuCores.Margin = new Padding(5);
            t_cpuCores.Name = "t_cpuCores";
            t_cpuCores.ReadOnly = true;
            t_cpuCores.ShortcutsEnabled = false;
            t_cpuCores.Size = new Size(476, 25);
            t_cpuCores.TabIndex = 4;
            // 
            // tc_vmInfo_gpu
            // 
            tc_vmInfo_gpu.Controls.Add(tableLayoutPanel1);
            tc_vmInfo_gpu.Location = new Point(4, 26);
            tc_vmInfo_gpu.Name = "tc_vmInfo_gpu";
            tc_vmInfo_gpu.Padding = new Padding(3);
            tc_vmInfo_gpu.Size = new Size(595, 150);
            tc_vmInfo_gpu.TabIndex = 1;
            tc_vmInfo_gpu.Text = "Graphics and Sound";
            tc_vmInfo_gpu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.16981F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.83019F));
            tableLayoutPanel1.Controls.Add(ls_graphicsController, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(t_graphicsController, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(589, 144);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // ls_graphicsController
            // 
            ls_graphicsController.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_graphicsController.AutoSize = true;
            ls_graphicsController.Location = new Point(56, 5);
            ls_graphicsController.Margin = new Padding(10, 5, 5, 5);
            ls_graphicsController.Name = "ls_graphicsController";
            ls_graphicsController.Size = new Size(69, 25);
            ls_graphicsController.TabIndex = 1;
            ls_graphicsController.Text = "Controller:";
            ls_graphicsController.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(86, 40);
            label2.Margin = new Padding(10, 5, 5, 5);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 6;
            label2.Text = "RAM:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.CausesValidation = false;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold);
            textBox1.HideSelection = false;
            textBox1.Location = new Point(135, 40);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(449, 25);
            textBox1.TabIndex = 7;
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
            t_graphicsController.Location = new Point(135, 5);
            t_graphicsController.Margin = new Padding(5);
            t_graphicsController.Name = "t_graphicsController";
            t_graphicsController.ReadOnly = true;
            t_graphicsController.ShortcutsEnabled = false;
            t_graphicsController.Size = new Size(449, 25);
            t_graphicsController.TabIndex = 4;
            // 
            // tc_vmInfo_media
            // 
            tc_vmInfo_media.Controls.Add(label1);
            tc_vmInfo_media.Controls.Add(button1);
            tc_vmInfo_media.Location = new Point(4, 26);
            tc_vmInfo_media.Name = "tc_vmInfo_media";
            tc_vmInfo_media.Padding = new Padding(3);
            tc_vmInfo_media.Size = new Size(595, 150);
            tc_vmInfo_media.TabIndex = 2;
            tc_vmInfo_media.Text = "Media";
            tc_vmInfo_media.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 13);
            label1.Name = "label1";
            label1.Size = new Size(181, 34);
            label1.TabIndex = 1;
            label1.Text = "hey monk!\r\nthis is in debug so be careful!";
            // 
            // button1
            // 
            button1.Location = new Point(0, 3);
            button1.Name = "button1";
            button1.Size = new Size(78, 64);
            button1.TabIndex = 0;
            button1.Text = "Edit Media";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sep1
            // 
            sep1.Name = "sep1";
            sep1.Size = new Size(255, 6);
            // 
            // sep2
            // 
            sep2.Name = "sep2";
            sep2.Size = new Size(152, 6);
            // 
            // ms_ts_file
            // 
            ms_ts_file.DropDownItems.AddRange(new ToolStripItem[] { ts_file_refresh, sep1, ts_file_prefs, ts_file_exit });
            ms_ts_file.Name = "ms_ts_file";
            ms_ts_file.Size = new Size(39, 21);
            ms_ts_file.Text = "File";
            // 
            // ts_file_refresh
            // 
            ts_file_refresh.Name = "ts_file_refresh";
            ts_file_refresh.ShortcutKeys = Keys.Control | Keys.R;
            ts_file_refresh.Size = new Size(258, 24);
            ts_file_refresh.Text = "Reload Machines";
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
            ms_ts_machine.DropDownItems.AddRange(new ToolStripItem[] { ts_machine_new, sep2, ts_machine_start, ts_machine_settings });
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
            ms.Size = new Size(985, 25);
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
            sc_maincont.Size = new Size(975, 646);
            sc_maincont.SplitterDistance = 331;
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
            sc_machine.Panel2.Controls.Add(tc_vmInfo);
            sc_machine.Panel2.Controls.Add(gb_machineDetails);
            sc_machine.Panel2.Margin = new Padding(5);
            sc_machine.Size = new Size(640, 646);
            sc_machine.SplitterDistance = 84;
            sc_machine.SplitterWidth = 5;
            sc_machine.TabIndex = 0;
            // 
            // gb_machineState
            // 
            gb_machineState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gb_machineState.Controls.Add(l_machineState);
            gb_machineState.Location = new Point(320, 1);
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
            b_newMachine.Size = new Size(104, 68);
            b_newMachine.TabIndex = 0;
            b_newMachine.Text = "New Machine";
            b_newMachine.UseVisualStyleBackColor = true;
            b_newMachine.Click += b_newMachine_Click;
            // 
            // b_machineSettings
            // 
            b_machineSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            b_machineSettings.Location = new Point(539, 8);
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
            b_startMachine.Location = new Point(441, 8);
            b_startMachine.Margin = new Padding(10);
            b_startMachine.Name = "b_startMachine";
            b_startMachine.Size = new Size(82, 68);
            b_startMachine.TabIndex = 0;
            b_startMachine.Text = "Launch";
            b_startMachine.UseVisualStyleBackColor = false;
            b_startMachine.Click += b_startMachine_Click;
            // 
            // p_main
            // 
            p_main.Controls.Add(sc_maincont);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 25);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(5, 10, 5, 10);
            p_main.Size = new Size(985, 666);
            p_main.TabIndex = 2;
            // 
            // WIN_MAIN
            // 
            AcceptButton = b_startMachine;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 691);
            Controls.Add(p_main);
            Controls.Add(ms);
            MainMenuStrip = ms;
            MinimumSize = new Size(745, 600);
            Name = "WIN_MAIN";
            Text = "QEMU Interface";
            sc_sublist.Panel1.ResumeLayout(false);
            sc_sublist.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_sublist).EndInit();
            sc_sublist.ResumeLayout(false);
            p_vmList.ResumeLayout(false);
            tlp_machineInfo.ResumeLayout(false);
            tlp_machineInfo.PerformLayout();
            gb_machineDetails.ResumeLayout(false);
            gb_machineDetails.PerformLayout();
            tc_vmInfo.ResumeLayout(false);
            tc_vmInfo_cpu.ResumeLayout(false);
            tlp_cpuTab.ResumeLayout(false);
            tlp_cpuTab.PerformLayout();
            tc_vmInfo_gpu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tc_vmInfo_media.ResumeLayout(false);
            tc_vmInfo_media.PerformLayout();
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
        private ToolStripSeparator sep1;
        private Button b_newMachine;
        private ToolStripMenuItem ts_machine_new;
        private ToolStripSeparator sep2;
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
        private TabControl tc_vmInfo;
        private TabPage tc_vmInfo_cpu;
        private TabPage tc_vmInfo_gpu;
        private TextBox t_ram;
        private TextBox t_cpuCores;
        private TextBox textBox1;
        private TextBox t_graphicsController;
        private TabPage tc_vmInfo_media;
        private Label label1;
        private Button button1;
    }
}
