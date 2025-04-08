namespace QEMUInterface
{
    partial class WIN_NewMachine
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
            FlowLayoutPanel fpl_bottom;
            Panel p_main;
            SplitContainer sc_p0_main;
            Label ls_p0_info;
            Label ls_p0_placeholder;
            GroupBox gb_p0_basic;
            Label ls_p0_emulator;
            Label ls_p0_name;
            FlowLayoutPanel flp_p0_emType;
            SplitContainer sc_p1_main;
            Label ls_p1_info;
            GroupBox gb_p1_os;
            Label ls_p1_version;
            FlowLayoutPanel flp_p1_osType;
            Label ls_p1_osName;
            SplitContainer sc_p2_main;
            Label ls_p2_info;
            Label ls_p2_hardwareInfo;
            SplitContainer sc_p3_main;
            Label ls_p3_info;
            Label ls_p3_cpu_type;
            Label ls_p3_cpu_cores;
            TableLayoutPanel tlp_p3_cpu_cores;
            Label ls_p3_coreBoundaryLeft;
            TableLayoutPanel tlp_p3_ram;
            Label ls_p3_ramBoundaryLeft;
            Label ls_p3_cpu_ram;
            GroupBox gb_p3_graphics;
            TableLayoutPanel tlp_p3_graphics;
            Label ls_p3_graphics;
            GroupBox gb_p3_audio;
            TableLayoutPanel tlp_p3_audio;
            Label ls_p3_audio;
            SplitContainer sc_pfin_main;
            Label ls_pfin_info;
            Label ls_pfin_name;
            Label ls_pfin_emtype;
            Label ls_pfin_os;
            Label ls_pfin_machine;
            Label ls_pfin_ram;
            Label ls_pfin_cpu;
            FlowLayoutPanel flp_pfin_disk;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_NewMachine));
            b_cancel = new Button();
            b_next = new Button();
            b_back = new Button();
            progressBarGeneric = new ProgressBar();
            p0 = new Panel();
            tlp_p0_basic = new TableLayoutPanel();
            t_p0_name = new TextBox();
            rb_p0_emType_x86 = new RadioButton();
            rb_p0_emType_i386 = new RadioButton();
            rb_p0_emType_PPC = new RadioButton();
            rb_p0_emType_m68k = new RadioButton();
            flp_p0_otherEm = new FlowLayoutPanel();
            rb_p0_emType_other = new RadioButton();
            cb_p0_otherEm = new ComboBox();
            p1_os = new Panel();
            tlp_p1_os = new TableLayoutPanel();
            l_p1_bitness = new Label();
            l_p1_subversion = new Label();
            rb_p1_os_win = new RadioButton();
            rb_p1_os_mac = new RadioButton();
            rb_p1_os_linux = new RadioButton();
            flp_p1_otherOS = new FlowLayoutPanel();
            rb_p1_os_other = new RadioButton();
            cb_p1_otherOS = new ComboBox();
            cb_p1_subversion = new ComboBox();
            cb_p1_version = new ComboBox();
            flp_p1_bitness = new FlowLayoutPanel();
            rb_p1_bitness_32 = new RadioButton();
            rb_p1_bitness_64 = new RadioButton();
            p2_pcType = new Panel();
            gb_p2_pcType = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lv_p2_type = new ListView();
            lv_p2_type_machine = new ColumnHeader();
            lv_p2_type_desc = new ColumnHeader();
            p3_hardware = new Panel();
            tc_p3_main = new TabControl();
            tp_p3_main_cpu = new TabPage();
            tlp_p3_cpu = new TableLayoutPanel();
            cb_p3_cpuType = new ComboBox();
            l_p3_coreBoundaryRight = new Label();
            slider_p3_cores = new TrackBar();
            num_p3_cores = new NumericUpDown();
            l_p3_ramBoundaryRight = new Label();
            slider_p3_ram = new TrackBar();
            num_p3_ram = new NumericUpDown();
            tp_p3_main_graphics = new TabPage();
            tlp_p3_main = new TableLayoutPanel();
            cb_p3_graphics = new ComboBox();
            cb_p3_audio = new ComboBox();
            tp_p3_main_accel = new TabPage();
            pfin = new Panel();
            tlp_pfin_main = new TableLayoutPanel();
            l_pfin_name = new Label();
            l_pfin_emType = new Label();
            l_pfin_os = new Label();
            l_pfin_machine = new Label();
            l_pfin_ram = new Label();
            l_pfin_cpu = new Label();
            gb_pfin_diskWrapper = new GroupBox();
            rb_pfin_createDisk = new RadioButton();
            rb_pfin_skipDisks = new RadioButton();
            fpl_bottom = new FlowLayoutPanel();
            p_main = new Panel();
            sc_p0_main = new SplitContainer();
            ls_p0_info = new Label();
            ls_p0_placeholder = new Label();
            gb_p0_basic = new GroupBox();
            ls_p0_emulator = new Label();
            ls_p0_name = new Label();
            flp_p0_emType = new FlowLayoutPanel();
            sc_p1_main = new SplitContainer();
            ls_p1_info = new Label();
            gb_p1_os = new GroupBox();
            ls_p1_version = new Label();
            flp_p1_osType = new FlowLayoutPanel();
            ls_p1_osName = new Label();
            sc_p2_main = new SplitContainer();
            ls_p2_info = new Label();
            ls_p2_hardwareInfo = new Label();
            sc_p3_main = new SplitContainer();
            ls_p3_info = new Label();
            ls_p3_cpu_type = new Label();
            ls_p3_cpu_cores = new Label();
            tlp_p3_cpu_cores = new TableLayoutPanel();
            ls_p3_coreBoundaryLeft = new Label();
            tlp_p3_ram = new TableLayoutPanel();
            ls_p3_ramBoundaryLeft = new Label();
            ls_p3_cpu_ram = new Label();
            gb_p3_graphics = new GroupBox();
            tlp_p3_graphics = new TableLayoutPanel();
            ls_p3_graphics = new Label();
            gb_p3_audio = new GroupBox();
            tlp_p3_audio = new TableLayoutPanel();
            ls_p3_audio = new Label();
            sc_pfin_main = new SplitContainer();
            ls_pfin_info = new Label();
            ls_pfin_name = new Label();
            ls_pfin_emtype = new Label();
            ls_pfin_os = new Label();
            ls_pfin_machine = new Label();
            ls_pfin_ram = new Label();
            ls_pfin_cpu = new Label();
            flp_pfin_disk = new FlowLayoutPanel();
            fpl_bottom.SuspendLayout();
            p_main.SuspendLayout();
            p0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_p0_main).BeginInit();
            sc_p0_main.Panel1.SuspendLayout();
            sc_p0_main.Panel2.SuspendLayout();
            sc_p0_main.SuspendLayout();
            gb_p0_basic.SuspendLayout();
            tlp_p0_basic.SuspendLayout();
            flp_p0_emType.SuspendLayout();
            flp_p0_otherEm.SuspendLayout();
            p1_os.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_p1_main).BeginInit();
            sc_p1_main.Panel1.SuspendLayout();
            sc_p1_main.Panel2.SuspendLayout();
            sc_p1_main.SuspendLayout();
            gb_p1_os.SuspendLayout();
            tlp_p1_os.SuspendLayout();
            flp_p1_osType.SuspendLayout();
            flp_p1_otherOS.SuspendLayout();
            flp_p1_bitness.SuspendLayout();
            p2_pcType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_p2_main).BeginInit();
            sc_p2_main.Panel1.SuspendLayout();
            sc_p2_main.Panel2.SuspendLayout();
            sc_p2_main.SuspendLayout();
            gb_p2_pcType.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            p3_hardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_p3_main).BeginInit();
            sc_p3_main.Panel1.SuspendLayout();
            sc_p3_main.Panel2.SuspendLayout();
            sc_p3_main.SuspendLayout();
            tc_p3_main.SuspendLayout();
            tp_p3_main_cpu.SuspendLayout();
            tlp_p3_cpu.SuspendLayout();
            tlp_p3_cpu_cores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slider_p3_cores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_p3_cores).BeginInit();
            tlp_p3_ram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slider_p3_ram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_p3_ram).BeginInit();
            tp_p3_main_graphics.SuspendLayout();
            tlp_p3_main.SuspendLayout();
            gb_p3_graphics.SuspendLayout();
            tlp_p3_graphics.SuspendLayout();
            gb_p3_audio.SuspendLayout();
            tlp_p3_audio.SuspendLayout();
            pfin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_pfin_main).BeginInit();
            sc_pfin_main.Panel1.SuspendLayout();
            sc_pfin_main.Panel2.SuspendLayout();
            sc_pfin_main.SuspendLayout();
            tlp_pfin_main.SuspendLayout();
            gb_pfin_diskWrapper.SuspendLayout();
            flp_pfin_disk.SuspendLayout();
            SuspendLayout();
            // 
            // fpl_bottom
            // 
            fpl_bottom.AutoSize = true;
            fpl_bottom.BackColor = SystemColors.ControlLight;
            fpl_bottom.Controls.Add(b_cancel);
            fpl_bottom.Controls.Add(b_next);
            fpl_bottom.Controls.Add(b_back);
            fpl_bottom.Controls.Add(progressBarGeneric);
            fpl_bottom.Dock = DockStyle.Bottom;
            fpl_bottom.FlowDirection = FlowDirection.RightToLeft;
            fpl_bottom.Location = new Point(0, 385);
            fpl_bottom.Name = "fpl_bottom";
            fpl_bottom.Size = new Size(594, 44);
            fpl_bottom.TabIndex = 2;
            // 
            // b_cancel
            // 
            b_cancel.Location = new Point(498, 9);
            b_cancel.Margin = new Padding(5, 9, 10, 9);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(86, 26);
            b_cancel.TabIndex = 1;
            b_cancel.Text = "Cancel";
            b_cancel.UseVisualStyleBackColor = true;
            b_cancel.Click += b_cancel_Click;
            // 
            // b_next
            // 
            b_next.Enabled = false;
            b_next.Location = new Point(392, 9);
            b_next.Margin = new Padding(5, 9, 15, 9);
            b_next.Name = "b_next";
            b_next.Size = new Size(86, 26);
            b_next.TabIndex = 0;
            b_next.Text = "N̲ext >";
            b_next.UseVisualStyleBackColor = true;
            b_next.Click += b_next_Click;
            // 
            // b_back
            // 
            b_back.Enabled = false;
            b_back.Location = new Point(299, 9);
            b_back.Margin = new Padding(5, 9, 5, 9);
            b_back.Name = "b_back";
            b_back.Size = new Size(83, 26);
            b_back.TabIndex = 2;
            b_back.Text = "< B̲ack";
            b_back.UseVisualStyleBackColor = true;
            b_back.Click += b_back_Click;
            // 
            // progressBarGeneric
            // 
            progressBarGeneric.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            progressBarGeneric.Location = new Point(16, 11);
            progressBarGeneric.Margin = new Padding(5, 4, 15, 4);
            progressBarGeneric.MarqueeAnimationSpeed = 1;
            progressBarGeneric.Name = "progressBarGeneric";
            progressBarGeneric.RightToLeft = RightToLeft.No;
            progressBarGeneric.Size = new Size(263, 22);
            progressBarGeneric.Style = ProgressBarStyle.Marquee;
            progressBarGeneric.TabIndex = 5;
            progressBarGeneric.Visible = false;
            // 
            // p_main
            // 
            p_main.BackColor = SystemColors.Control;
            p_main.Controls.Add(p0);
            p_main.Controls.Add(p1_os);
            p_main.Controls.Add(p2_pcType);
            p_main.Controls.Add(p3_hardware);
            p_main.Controls.Add(pfin);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Margin = new Padding(0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(10, 9, 10, 9);
            p_main.Size = new Size(594, 385);
            p_main.TabIndex = 3;
            // 
            // p0
            // 
            p0.Controls.Add(sc_p0_main);
            p0.Dock = DockStyle.Fill;
            p0.Location = new Point(10, 9);
            p0.Name = "p0";
            p0.Size = new Size(574, 367);
            p0.TabIndex = 0;
            // 
            // sc_p0_main
            // 
            sc_p0_main.Dock = DockStyle.Fill;
            sc_p0_main.IsSplitterFixed = true;
            sc_p0_main.Location = new Point(0, 0);
            sc_p0_main.Name = "sc_p0_main";
            sc_p0_main.Orientation = Orientation.Horizontal;
            // 
            // sc_p0_main.Panel1
            // 
            sc_p0_main.Panel1.Controls.Add(ls_p0_info);
            sc_p0_main.Panel1.Padding = new Padding(5, 4, 5, 4);
            // 
            // sc_p0_main.Panel2
            // 
            sc_p0_main.Panel2.Controls.Add(ls_p0_placeholder);
            sc_p0_main.Panel2.Controls.Add(gb_p0_basic);
            sc_p0_main.Panel2.Padding = new Padding(5, 4, 5, 4);
            sc_p0_main.Size = new Size(574, 367);
            sc_p0_main.SplitterDistance = 53;
            sc_p0_main.TabIndex = 0;
            sc_p0_main.TabStop = false;
            // 
            // ls_p0_info
            // 
            ls_p0_info.Dock = DockStyle.Fill;
            ls_p0_info.Location = new Point(5, 4);
            ls_p0_info.Margin = new Padding(0);
            ls_p0_info.Name = "ls_p0_info";
            ls_p0_info.Padding = new Padding(5, 4, 5, 4);
            ls_p0_info.Size = new Size(564, 45);
            ls_p0_info.TabIndex = 0;
            ls_p0_info.Text = "Here is where you will choose the type and name of your VM.";
            ls_p0_info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ls_p0_placeholder
            // 
            ls_p0_placeholder.AutoSize = true;
            ls_p0_placeholder.Dock = DockStyle.Top;
            ls_p0_placeholder.Font = new Font("Segoe UI", 4F);
            ls_p0_placeholder.Location = new Point(5, 154);
            ls_p0_placeholder.Name = "ls_p0_placeholder";
            ls_p0_placeholder.Size = new Size(0, 8);
            ls_p0_placeholder.TabIndex = 2;
            // 
            // gb_p0_basic
            // 
            gb_p0_basic.AutoSize = true;
            gb_p0_basic.Controls.Add(tlp_p0_basic);
            gb_p0_basic.Dock = DockStyle.Top;
            gb_p0_basic.Location = new Point(5, 4);
            gb_p0_basic.Margin = new Padding(5, 4, 5, 4);
            gb_p0_basic.Name = "gb_p0_basic";
            gb_p0_basic.Padding = new Padding(5, 4, 5, 4);
            gb_p0_basic.RightToLeft = RightToLeft.No;
            gb_p0_basic.Size = new Size(564, 150);
            gb_p0_basic.TabIndex = 0;
            gb_p0_basic.TabStop = false;
            gb_p0_basic.Text = "Basic Information";
            // 
            // tlp_p0_basic
            // 
            tlp_p0_basic.AutoSize = true;
            tlp_p0_basic.ColumnCount = 2;
            tlp_p0_basic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.94617F));
            tlp_p0_basic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.05383F));
            tlp_p0_basic.Controls.Add(ls_p0_emulator, 0, 1);
            tlp_p0_basic.Controls.Add(ls_p0_name, 0, 0);
            tlp_p0_basic.Controls.Add(t_p0_name, 1, 0);
            tlp_p0_basic.Controls.Add(flp_p0_emType, 1, 1);
            tlp_p0_basic.Dock = DockStyle.Fill;
            tlp_p0_basic.Location = new Point(5, 20);
            tlp_p0_basic.Name = "tlp_p0_basic";
            tlp_p0_basic.RowCount = 2;
            tlp_p0_basic.RowStyles.Add(new RowStyle());
            tlp_p0_basic.RowStyles.Add(new RowStyle());
            tlp_p0_basic.Size = new Size(554, 126);
            tlp_p0_basic.TabIndex = 0;
            // 
            // ls_p0_emulator
            // 
            ls_p0_emulator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p0_emulator.AutoSize = true;
            ls_p0_emulator.Location = new Point(58, 35);
            ls_p0_emulator.Margin = new Padding(5, 4, 5, 4);
            ls_p0_emulator.Name = "ls_p0_emulator";
            ls_p0_emulator.Size = new Size(58, 87);
            ls_p0_emulator.TabIndex = 2;
            ls_p0_emulator.Text = "Emulator:";
            ls_p0_emulator.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_p0_name
            // 
            ls_p0_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p0_name.AutoSize = true;
            ls_p0_name.Location = new Point(74, 4);
            ls_p0_name.Margin = new Padding(5, 4, 5, 4);
            ls_p0_name.Name = "ls_p0_name";
            ls_p0_name.Size = new Size(42, 23);
            ls_p0_name.TabIndex = 0;
            ls_p0_name.Text = "Name:";
            ls_p0_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_p0_name
            // 
            t_p0_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_p0_name.Location = new Point(126, 4);
            t_p0_name.Margin = new Padding(5, 4, 5, 4);
            t_p0_name.Name = "t_p0_name";
            t_p0_name.Size = new Size(423, 23);
            t_p0_name.TabIndex = 1;
            t_p0_name.Text = "Meee and my debug";
            t_p0_name.TextChanged += CheckNextButton;
            // 
            // flp_p0_emType
            // 
            flp_p0_emType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flp_p0_emType.AutoSize = true;
            flp_p0_emType.BorderStyle = BorderStyle.FixedSingle;
            flp_p0_emType.Controls.Add(rb_p0_emType_x86);
            flp_p0_emType.Controls.Add(rb_p0_emType_i386);
            flp_p0_emType.Controls.Add(rb_p0_emType_PPC);
            flp_p0_emType.Controls.Add(rb_p0_emType_m68k);
            flp_p0_emType.Controls.Add(flp_p0_otherEm);
            flp_p0_emType.Location = new Point(124, 34);
            flp_p0_emType.Name = "flp_p0_emType";
            flp_p0_emType.Padding = new Padding(5, 4, 5, 4);
            flp_p0_emType.Size = new Size(427, 89);
            flp_p0_emType.TabIndex = 3;
            // 
            // rb_p0_emType_x86
            // 
            rb_p0_emType_x86.AutoSize = true;
            rb_p0_emType_x86.Checked = true;
            rb_p0_emType_x86.Location = new Point(8, 7);
            rb_p0_emType_x86.Margin = new Padding(3, 3, 50, 3);
            rb_p0_emType_x86.Name = "rb_p0_emType_x86";
            rb_p0_emType_x86.Size = new Size(97, 19);
            rb_p0_emType_x86.TabIndex = 0;
            rb_p0_emType_x86.TabStop = true;
            rb_p0_emType_x86.Text = "QEMU x86-64";
            rb_p0_emType_x86.UseVisualStyleBackColor = true;
            rb_p0_emType_x86.CheckedChanged += rb_p0_emType_x86_CheckedChanged;
            // 
            // rb_p0_emType_i386
            // 
            rb_p0_emType_i386.AutoSize = true;
            rb_p0_emType_i386.Location = new Point(158, 7);
            rb_p0_emType_i386.Margin = new Padding(3, 3, 100, 3);
            rb_p0_emType_i386.Name = "rb_p0_emType_i386";
            rb_p0_emType_i386.Size = new Size(83, 19);
            rb_p0_emType_i386.TabIndex = 3;
            rb_p0_emType_i386.Text = "QEMU i386";
            rb_p0_emType_i386.UseVisualStyleBackColor = true;
            rb_p0_emType_i386.CheckedChanged += rb_p0_emType_i386_CheckedChanged;
            // 
            // rb_p0_emType_PPC
            // 
            rb_p0_emType_PPC.AutoSize = true;
            rb_p0_emType_PPC.Location = new Point(8, 32);
            rb_p0_emType_PPC.Margin = new Padding(3, 3, 37, 3);
            rb_p0_emType_PPC.Name = "rb_p0_emType_PPC";
            rb_p0_emType_PPC.Size = new Size(110, 19);
            rb_p0_emType_PPC.TabIndex = 1;
            rb_p0_emType_PPC.Text = "QEMU PowerPC";
            rb_p0_emType_PPC.UseVisualStyleBackColor = true;
            rb_p0_emType_PPC.CheckedChanged += rb_p0_emType_PPC_CheckedChanged;
            // 
            // rb_p0_emType_m68k
            // 
            rb_p0_emType_m68k.AutoSize = true;
            rb_p0_emType_m68k.Location = new Point(158, 32);
            rb_p0_emType_m68k.Margin = new Padding(3, 3, 50, 3);
            rb_p0_emType_m68k.Name = "rb_p0_emType_m68k";
            rb_p0_emType_m68k.Size = new Size(92, 19);
            rb_p0_emType_m68k.TabIndex = 2;
            rb_p0_emType_m68k.TabStop = true;
            rb_p0_emType_m68k.Text = "QEMU M68K";
            rb_p0_emType_m68k.UseVisualStyleBackColor = true;
            rb_p0_emType_m68k.CheckedChanged += rb_p0_emType_m68k_CheckedChanged;
            // 
            // flp_p0_otherEm
            // 
            flp_p0_otherEm.AutoSize = true;
            flp_p0_otherEm.Controls.Add(rb_p0_emType_other);
            flp_p0_otherEm.Controls.Add(cb_p0_otherEm);
            flp_p0_otherEm.Dock = DockStyle.Fill;
            flp_p0_otherEm.Location = new Point(8, 54);
            flp_p0_otherEm.Margin = new Padding(3, 0, 0, 0);
            flp_p0_otherEm.Name = "flp_p0_otherEm";
            flp_p0_otherEm.Size = new Size(346, 29);
            flp_p0_otherEm.TabIndex = 2;
            flp_p0_otherEm.Visible = false;
            // 
            // rb_p0_emType_other
            // 
            rb_p0_emType_other.AutoSize = true;
            rb_p0_emType_other.Location = new Point(0, 4);
            rb_p0_emType_other.Margin = new Padding(0, 4, 3, 3);
            rb_p0_emType_other.Name = "rb_p0_emType_other";
            rb_p0_emType_other.Size = new Size(61, 19);
            rb_p0_emType_other.TabIndex = 1;
            rb_p0_emType_other.Text = "Other: ";
            rb_p0_emType_other.UseVisualStyleBackColor = true;
            rb_p0_emType_other.CheckedChanged += rb_p0_emType_other_CheckedChanged;
            // 
            // cb_p0_otherEm
            // 
            cb_p0_otherEm.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p0_otherEm.FormattingEnabled = true;
            cb_p0_otherEm.Items.AddRange(new object[] { "yi long ma", "xiao hong shu" });
            cb_p0_otherEm.Location = new Point(67, 3);
            cb_p0_otherEm.Name = "cb_p0_otherEm";
            cb_p0_otherEm.Size = new Size(276, 23);
            cb_p0_otherEm.TabIndex = 1;
            cb_p0_otherEm.SelectedIndexChanged += cb_p0_otherEm_SelectedIndexChanged;
            // 
            // p1_os
            // 
            p1_os.Controls.Add(sc_p1_main);
            p1_os.Dock = DockStyle.Fill;
            p1_os.Location = new Point(10, 9);
            p1_os.Name = "p1_os";
            p1_os.Size = new Size(574, 367);
            p1_os.TabIndex = 3;
            // 
            // sc_p1_main
            // 
            sc_p1_main.Dock = DockStyle.Fill;
            sc_p1_main.Location = new Point(0, 0);
            sc_p1_main.Name = "sc_p1_main";
            sc_p1_main.Orientation = Orientation.Horizontal;
            // 
            // sc_p1_main.Panel1
            // 
            sc_p1_main.Panel1.Controls.Add(ls_p1_info);
            // 
            // sc_p1_main.Panel2
            // 
            sc_p1_main.Panel2.Controls.Add(gb_p1_os);
            sc_p1_main.Panel2.Padding = new Padding(5, 4, 5, 4);
            sc_p1_main.Size = new Size(574, 367);
            sc_p1_main.SplitterDistance = 53;
            sc_p1_main.TabIndex = 2;
            sc_p1_main.TabStop = false;
            // 
            // ls_p1_info
            // 
            ls_p1_info.Dock = DockStyle.Fill;
            ls_p1_info.Location = new Point(0, 0);
            ls_p1_info.Margin = new Padding(0);
            ls_p1_info.Name = "ls_p1_info";
            ls_p1_info.Padding = new Padding(5, 4, 5, 4);
            ls_p1_info.Size = new Size(574, 53);
            ls_p1_info.TabIndex = 1;
            ls_p1_info.Text = "Here is where you will choose the Operating System of the VM.";
            ls_p1_info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gb_p1_os
            // 
            gb_p1_os.AutoSize = true;
            gb_p1_os.Controls.Add(tlp_p1_os);
            gb_p1_os.Dock = DockStyle.Top;
            gb_p1_os.Location = new Point(5, 4);
            gb_p1_os.Margin = new Padding(5, 4, 5, 4);
            gb_p1_os.Name = "gb_p1_os";
            gb_p1_os.Padding = new Padding(5, 4, 5, 4);
            gb_p1_os.Size = new Size(564, 197);
            gb_p1_os.TabIndex = 1;
            gb_p1_os.TabStop = false;
            gb_p1_os.Text = "Operating System";
            // 
            // tlp_p1_os
            // 
            tlp_p1_os.AutoSize = true;
            tlp_p1_os.ColumnCount = 2;
            tlp_p1_os.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.94617F));
            tlp_p1_os.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.05383F));
            tlp_p1_os.Controls.Add(l_p1_bitness, 0, 3);
            tlp_p1_os.Controls.Add(l_p1_subversion, 0, 2);
            tlp_p1_os.Controls.Add(ls_p1_version, 0, 1);
            tlp_p1_os.Controls.Add(flp_p1_osType, 1, 0);
            tlp_p1_os.Controls.Add(ls_p1_osName, 0, 0);
            tlp_p1_os.Controls.Add(cb_p1_subversion, 1, 2);
            tlp_p1_os.Controls.Add(cb_p1_version, 1, 1);
            tlp_p1_os.Controls.Add(flp_p1_bitness, 1, 3);
            tlp_p1_os.Dock = DockStyle.Fill;
            tlp_p1_os.Location = new Point(5, 20);
            tlp_p1_os.Name = "tlp_p1_os";
            tlp_p1_os.RowCount = 5;
            tlp_p1_os.RowStyles.Add(new RowStyle());
            tlp_p1_os.RowStyles.Add(new RowStyle());
            tlp_p1_os.RowStyles.Add(new RowStyle());
            tlp_p1_os.RowStyles.Add(new RowStyle());
            tlp_p1_os.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_p1_os.Size = new Size(554, 173);
            tlp_p1_os.TabIndex = 1;
            // 
            // l_p1_bitness
            // 
            l_p1_bitness.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            l_p1_bitness.AutoSize = true;
            l_p1_bitness.Location = new Point(69, 136);
            l_p1_bitness.Margin = new Padding(5, 4, 5, 4);
            l_p1_bitness.Name = "l_p1_bitness";
            l_p1_bitness.Size = new Size(47, 33);
            l_p1_bitness.TabIndex = 9;
            l_p1_bitness.Text = "Bitness:";
            l_p1_bitness.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_p1_subversion
            // 
            l_p1_subversion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            l_p1_subversion.AutoSize = true;
            l_p1_subversion.Location = new Point(43, 105);
            l_p1_subversion.Margin = new Padding(5, 4, 5, 4);
            l_p1_subversion.Name = "l_p1_subversion";
            l_p1_subversion.Size = new Size(73, 23);
            l_p1_subversion.TabIndex = 6;
            l_p1_subversion.Text = "Sub-Version:";
            l_p1_subversion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_p1_version
            // 
            ls_p1_version.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p1_version.AutoSize = true;
            ls_p1_version.Location = new Point(68, 74);
            ls_p1_version.Margin = new Padding(5, 4, 5, 4);
            ls_p1_version.Name = "ls_p1_version";
            ls_p1_version.Size = new Size(48, 23);
            ls_p1_version.TabIndex = 5;
            ls_p1_version.Text = "Version:";
            ls_p1_version.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flp_p1_osType
            // 
            flp_p1_osType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flp_p1_osType.AutoSize = true;
            flp_p1_osType.BorderStyle = BorderStyle.FixedSingle;
            flp_p1_osType.Controls.Add(rb_p1_os_win);
            flp_p1_osType.Controls.Add(rb_p1_os_mac);
            flp_p1_osType.Controls.Add(rb_p1_os_linux);
            flp_p1_osType.Controls.Add(flp_p1_otherOS);
            flp_p1_osType.Location = new Point(124, 3);
            flp_p1_osType.Name = "flp_p1_osType";
            flp_p1_osType.Padding = new Padding(5, 4, 5, 4);
            flp_p1_osType.Size = new Size(427, 64);
            flp_p1_osType.TabIndex = 3;
            // 
            // rb_p1_os_win
            // 
            rb_p1_os_win.AutoSize = true;
            rb_p1_os_win.Checked = true;
            rb_p1_os_win.Location = new Point(8, 7);
            rb_p1_os_win.Margin = new Padding(3, 3, 50, 3);
            rb_p1_os_win.Name = "rb_p1_os_win";
            rb_p1_os_win.Size = new Size(74, 19);
            rb_p1_os_win.TabIndex = 6;
            rb_p1_os_win.TabStop = true;
            rb_p1_os_win.Text = "Windows";
            rb_p1_os_win.UseVisualStyleBackColor = true;
            rb_p1_os_win.CheckedChanged += LoadOSVersions;
            // 
            // rb_p1_os_mac
            // 
            rb_p1_os_mac.AutoSize = true;
            rb_p1_os_mac.Location = new Point(135, 7);
            rb_p1_os_mac.Margin = new Padding(3, 3, 50, 3);
            rb_p1_os_mac.Name = "rb_p1_os_mac";
            rb_p1_os_mac.Size = new Size(63, 19);
            rb_p1_os_mac.TabIndex = 7;
            rb_p1_os_mac.TabStop = true;
            rb_p1_os_mac.Text = "MacOS";
            rb_p1_os_mac.UseVisualStyleBackColor = true;
            rb_p1_os_mac.CheckedChanged += LoadOSVersions;
            // 
            // rb_p1_os_linux
            // 
            rb_p1_os_linux.AutoSize = true;
            rb_p1_os_linux.Location = new Point(251, 7);
            rb_p1_os_linux.Name = "rb_p1_os_linux";
            rb_p1_os_linux.Size = new Size(54, 19);
            rb_p1_os_linux.TabIndex = 8;
            rb_p1_os_linux.TabStop = true;
            rb_p1_os_linux.Text = "Linux";
            rb_p1_os_linux.UseVisualStyleBackColor = true;
            rb_p1_os_linux.CheckedChanged += LoadOSVersions;
            // 
            // flp_p1_otherOS
            // 
            flp_p1_otherOS.AutoSize = true;
            flp_p1_otherOS.Controls.Add(rb_p1_os_other);
            flp_p1_otherOS.Controls.Add(cb_p1_otherOS);
            flp_p1_otherOS.Dock = DockStyle.Fill;
            flp_p1_otherOS.Location = new Point(8, 29);
            flp_p1_otherOS.Margin = new Padding(3, 0, 0, 0);
            flp_p1_otherOS.Name = "flp_p1_otherOS";
            flp_p1_otherOS.Size = new Size(353, 29);
            flp_p1_otherOS.TabIndex = 2;
            flp_p1_otherOS.Visible = false;
            // 
            // rb_p1_os_other
            // 
            rb_p1_os_other.AutoSize = true;
            rb_p1_os_other.Location = new Point(0, 4);
            rb_p1_os_other.Margin = new Padding(0, 4, 3, 3);
            rb_p1_os_other.Name = "rb_p1_os_other";
            rb_p1_os_other.Size = new Size(61, 19);
            rb_p1_os_other.TabIndex = 1;
            rb_p1_os_other.Text = "Other: ";
            rb_p1_os_other.UseVisualStyleBackColor = true;
            rb_p1_os_other.CheckedChanged += LoadOSVersions;
            // 
            // cb_p1_otherOS
            // 
            cb_p1_otherOS.FormattingEnabled = true;
            cb_p1_otherOS.Items.AddRange(new object[] { "window", "bsd", "uhhh hi everyone" });
            cb_p1_otherOS.Location = new Point(67, 3);
            cb_p1_otherOS.Name = "cb_p1_otherOS";
            cb_p1_otherOS.Size = new Size(283, 23);
            cb_p1_otherOS.TabIndex = 1;
            // 
            // ls_p1_osName
            // 
            ls_p1_osName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p1_osName.AutoSize = true;
            ls_p1_osName.Location = new Point(12, 4);
            ls_p1_osName.Margin = new Padding(5, 4, 5, 4);
            ls_p1_osName.Name = "ls_p1_osName";
            ls_p1_osName.Size = new Size(104, 62);
            ls_p1_osName.TabIndex = 4;
            ls_p1_osName.Text = "Operating System:";
            ls_p1_osName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cb_p1_subversion
            // 
            cb_p1_subversion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_p1_subversion.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p1_subversion.Enabled = false;
            cb_p1_subversion.FormattingEnabled = true;
            cb_p1_subversion.Location = new Point(126, 105);
            cb_p1_subversion.Margin = new Padding(5, 4, 5, 4);
            cb_p1_subversion.Name = "cb_p1_subversion";
            cb_p1_subversion.Size = new Size(423, 23);
            cb_p1_subversion.TabIndex = 7;
            // 
            // cb_p1_version
            // 
            cb_p1_version.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_p1_version.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p1_version.FormattingEnabled = true;
            cb_p1_version.Items.AddRange(new object[] { "" });
            cb_p1_version.Location = new Point(126, 74);
            cb_p1_version.Margin = new Padding(5, 4, 5, 4);
            cb_p1_version.Name = "cb_p1_version";
            cb_p1_version.Size = new Size(423, 23);
            cb_p1_version.TabIndex = 8;
            cb_p1_version.SelectedIndexChanged += LoadOSMinorVersions;
            // 
            // flp_p1_bitness
            // 
            flp_p1_bitness.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flp_p1_bitness.AutoSize = true;
            flp_p1_bitness.BorderStyle = BorderStyle.FixedSingle;
            flp_p1_bitness.Controls.Add(rb_p1_bitness_32);
            flp_p1_bitness.Controls.Add(rb_p1_bitness_64);
            flp_p1_bitness.Location = new Point(124, 135);
            flp_p1_bitness.Name = "flp_p1_bitness";
            flp_p1_bitness.Padding = new Padding(5, 4, 5, 4);
            flp_p1_bitness.Size = new Size(427, 35);
            flp_p1_bitness.TabIndex = 10;
            // 
            // rb_p1_bitness_32
            // 
            rb_p1_bitness_32.AutoSize = true;
            rb_p1_bitness_32.Location = new Point(8, 7);
            rb_p1_bitness_32.Margin = new Padding(3, 3, 50, 3);
            rb_p1_bitness_32.Name = "rb_p1_bitness_32";
            rb_p1_bitness_32.Size = new Size(83, 19);
            rb_p1_bitness_32.TabIndex = 0;
            rb_p1_bitness_32.Text = "32 Bit (x86)";
            rb_p1_bitness_32.UseVisualStyleBackColor = true;
            // 
            // rb_p1_bitness_64
            // 
            rb_p1_bitness_64.AutoSize = true;
            rb_p1_bitness_64.Checked = true;
            rb_p1_bitness_64.Location = new Point(144, 7);
            rb_p1_bitness_64.Name = "rb_p1_bitness_64";
            rb_p1_bitness_64.Size = new Size(83, 19);
            rb_p1_bitness_64.TabIndex = 1;
            rb_p1_bitness_64.TabStop = true;
            rb_p1_bitness_64.Text = "64 Bit (x64)";
            rb_p1_bitness_64.UseVisualStyleBackColor = true;
            // 
            // p2_pcType
            // 
            p2_pcType.Controls.Add(sc_p2_main);
            p2_pcType.Dock = DockStyle.Fill;
            p2_pcType.Location = new Point(10, 9);
            p2_pcType.Margin = new Padding(0);
            p2_pcType.Name = "p2_pcType";
            p2_pcType.Size = new Size(574, 367);
            p2_pcType.TabIndex = 1;
            // 
            // sc_p2_main
            // 
            sc_p2_main.Dock = DockStyle.Fill;
            sc_p2_main.IsSplitterFixed = true;
            sc_p2_main.Location = new Point(0, 0);
            sc_p2_main.Name = "sc_p2_main";
            sc_p2_main.Orientation = Orientation.Horizontal;
            // 
            // sc_p2_main.Panel1
            // 
            sc_p2_main.Panel1.Controls.Add(ls_p2_info);
            sc_p2_main.Panel1.RightToLeft = RightToLeft.No;
            // 
            // sc_p2_main.Panel2
            // 
            sc_p2_main.Panel2.Controls.Add(gb_p2_pcType);
            sc_p2_main.Panel2.Padding = new Padding(5, 4, 5, 4);
            sc_p2_main.Panel2.RightToLeft = RightToLeft.No;
            sc_p2_main.Size = new Size(574, 367);
            sc_p2_main.SplitterDistance = 53;
            sc_p2_main.TabIndex = 0;
            sc_p2_main.TabStop = false;
            // 
            // ls_p2_info
            // 
            ls_p2_info.Dock = DockStyle.Fill;
            ls_p2_info.Location = new Point(0, 0);
            ls_p2_info.Margin = new Padding(0);
            ls_p2_info.Name = "ls_p2_info";
            ls_p2_info.Padding = new Padding(5, 4, 5, 4);
            ls_p2_info.Size = new Size(574, 53);
            ls_p2_info.TabIndex = 1;
            ls_p2_info.Text = "Here is where you will choose the hardware for your VM.";
            ls_p2_info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gb_p2_pcType
            // 
            gb_p2_pcType.Controls.Add(tableLayoutPanel1);
            gb_p2_pcType.Dock = DockStyle.Fill;
            gb_p2_pcType.Location = new Point(5, 4);
            gb_p2_pcType.Name = "gb_p2_pcType";
            gb_p2_pcType.Size = new Size(564, 302);
            gb_p2_pcType.TabIndex = 0;
            gb_p2_pcType.TabStop = false;
            gb_p2_pcType.Text = "Hardware";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.84546F));
            tableLayoutPanel1.Controls.Add(lv_p2_type, 0, 1);
            tableLayoutPanel1.Controls.Add(ls_p2_hardwareInfo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8054714F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.19453F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Size = new Size(558, 280);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lv_p2_type
            // 
            lv_p2_type.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lv_p2_type.Columns.AddRange(new ColumnHeader[] { lv_p2_type_machine, lv_p2_type_desc });
            lv_p2_type.FullRowSelect = true;
            lv_p2_type.GridLines = true;
            lv_p2_type.Location = new Point(5, 48);
            lv_p2_type.Margin = new Padding(5, 4, 5, 4);
            lv_p2_type.MultiSelect = false;
            lv_p2_type.Name = "lv_p2_type";
            lv_p2_type.ShowGroups = false;
            lv_p2_type.Size = new Size(548, 228);
            lv_p2_type.TabIndex = 4;
            lv_p2_type.TileSize = new Size(30, 30);
            lv_p2_type.UseCompatibleStateImageBehavior = false;
            lv_p2_type.View = View.Details;
            lv_p2_type.Visible = false;
            lv_p2_type.SelectedIndexChanged += CheckNextButton;
            // 
            // lv_p2_type_machine
            // 
            lv_p2_type_machine.Text = "Machine";
            lv_p2_type_machine.Width = 100;
            // 
            // lv_p2_type_desc
            // 
            lv_p2_type_desc.Text = "Description";
            lv_p2_type_desc.Width = 443;
            // 
            // ls_p2_hardwareInfo
            // 
            ls_p2_hardwareInfo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ls_p2_hardwareInfo.AutoSize = true;
            ls_p2_hardwareInfo.Location = new Point(10, 14);
            ls_p2_hardwareInfo.Margin = new Padding(10, 9, 10, 9);
            ls_p2_hardwareInfo.Name = "ls_p2_hardwareInfo";
            ls_p2_hardwareInfo.Size = new Size(538, 15);
            ls_p2_hardwareInfo.TabIndex = 5;
            ls_p2_hardwareInfo.Text = "Choose a machine:";
            ls_p2_hardwareInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // p3_hardware
            // 
            p3_hardware.Controls.Add(sc_p3_main);
            p3_hardware.Dock = DockStyle.Fill;
            p3_hardware.Location = new Point(10, 9);
            p3_hardware.Name = "p3_hardware";
            p3_hardware.Size = new Size(574, 367);
            p3_hardware.TabIndex = 4;
            p3_hardware.Visible = false;
            // 
            // sc_p3_main
            // 
            sc_p3_main.Dock = DockStyle.Fill;
            sc_p3_main.IsSplitterFixed = true;
            sc_p3_main.Location = new Point(0, 0);
            sc_p3_main.Name = "sc_p3_main";
            sc_p3_main.Orientation = Orientation.Horizontal;
            // 
            // sc_p3_main.Panel1
            // 
            sc_p3_main.Panel1.Controls.Add(ls_p3_info);
            // 
            // sc_p3_main.Panel2
            // 
            sc_p3_main.Panel2.Controls.Add(tc_p3_main);
            sc_p3_main.Panel2.Padding = new Padding(5, 4, 5, 4);
            sc_p3_main.Size = new Size(574, 367);
            sc_p3_main.SplitterDistance = 53;
            sc_p3_main.TabIndex = 0;
            sc_p3_main.TabStop = false;
            // 
            // ls_p3_info
            // 
            ls_p3_info.Dock = DockStyle.Fill;
            ls_p3_info.Location = new Point(0, 0);
            ls_p3_info.Margin = new Padding(0);
            ls_p3_info.Name = "ls_p3_info";
            ls_p3_info.Padding = new Padding(5, 4, 5, 4);
            ls_p3_info.Size = new Size(574, 53);
            ls_p3_info.TabIndex = 1;
            ls_p3_info.Text = "Here is where you will specifiy the hardware details of the VM.";
            ls_p3_info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tc_p3_main
            // 
            tc_p3_main.Controls.Add(tp_p3_main_cpu);
            tc_p3_main.Controls.Add(tp_p3_main_graphics);
            tc_p3_main.Controls.Add(tp_p3_main_accel);
            tc_p3_main.Dock = DockStyle.Fill;
            tc_p3_main.Location = new Point(5, 4);
            tc_p3_main.Margin = new Padding(5, 4, 5, 4);
            tc_p3_main.Name = "tc_p3_main";
            tc_p3_main.SelectedIndex = 0;
            tc_p3_main.Size = new Size(564, 302);
            tc_p3_main.TabIndex = 0;
            // 
            // tp_p3_main_cpu
            // 
            tp_p3_main_cpu.BackColor = SystemColors.ControlLightLight;
            tp_p3_main_cpu.BorderStyle = BorderStyle.FixedSingle;
            tp_p3_main_cpu.Controls.Add(tlp_p3_cpu);
            tp_p3_main_cpu.Location = new Point(4, 24);
            tp_p3_main_cpu.Name = "tp_p3_main_cpu";
            tp_p3_main_cpu.Padding = new Padding(3);
            tp_p3_main_cpu.Size = new Size(556, 274);
            tp_p3_main_cpu.TabIndex = 1;
            tp_p3_main_cpu.Text = "CPU/RAM";
            // 
            // tlp_p3_cpu
            // 
            tlp_p3_cpu.ColumnCount = 2;
            tlp_p3_cpu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tlp_p3_cpu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84F));
            tlp_p3_cpu.Controls.Add(ls_p3_cpu_type, 0, 0);
            tlp_p3_cpu.Controls.Add(cb_p3_cpuType, 1, 0);
            tlp_p3_cpu.Controls.Add(ls_p3_cpu_cores, 0, 1);
            tlp_p3_cpu.Controls.Add(tlp_p3_cpu_cores, 1, 1);
            tlp_p3_cpu.Controls.Add(tlp_p3_ram, 1, 2);
            tlp_p3_cpu.Controls.Add(ls_p3_cpu_ram, 0, 2);
            tlp_p3_cpu.Dock = DockStyle.Fill;
            tlp_p3_cpu.Location = new Point(3, 3);
            tlp_p3_cpu.Margin = new Padding(5, 4, 5, 4);
            tlp_p3_cpu.Name = "tlp_p3_cpu";
            tlp_p3_cpu.Padding = new Padding(5, 9, 5, 4);
            tlp_p3_cpu.RowCount = 4;
            tlp_p3_cpu.RowStyles.Add(new RowStyle());
            tlp_p3_cpu.RowStyles.Add(new RowStyle());
            tlp_p3_cpu.RowStyles.Add(new RowStyle());
            tlp_p3_cpu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_p3_cpu.Size = new Size(548, 266);
            tlp_p3_cpu.TabIndex = 0;
            // 
            // ls_p3_cpu_type
            // 
            ls_p3_cpu_type.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p3_cpu_type.AutoSize = true;
            ls_p3_cpu_type.Location = new Point(26, 13);
            ls_p3_cpu_type.Margin = new Padding(5, 4, 5, 4);
            ls_p3_cpu_type.Name = "ls_p3_cpu_type";
            ls_p3_cpu_type.Size = new Size(60, 23);
            ls_p3_cpu_type.TabIndex = 3;
            ls_p3_cpu_type.Text = "CPU Type:";
            ls_p3_cpu_type.TextAlign = ContentAlignment.MiddleRight;
            ls_p3_cpu_type.Visible = false;
            // 
            // cb_p3_cpuType
            // 
            cb_p3_cpuType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_p3_cpuType.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p3_cpuType.FormattingEnabled = true;
            cb_p3_cpuType.Items.AddRange(new object[] { "CPU TYPE 1", "CPU TYPE 2" });
            cb_p3_cpuType.Location = new Point(101, 13);
            cb_p3_cpuType.Margin = new Padding(10, 4, 10, 4);
            cb_p3_cpuType.Name = "cb_p3_cpuType";
            cb_p3_cpuType.Size = new Size(432, 23);
            cb_p3_cpuType.TabIndex = 4;
            cb_p3_cpuType.Visible = false;
            // 
            // ls_p3_cpu_cores
            // 
            ls_p3_cpu_cores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p3_cpu_cores.AutoSize = true;
            ls_p3_cpu_cores.Location = new Point(21, 49);
            ls_p3_cpu_cores.Margin = new Padding(5, 9, 5, 9);
            ls_p3_cpu_cores.Name = "ls_p3_cpu_cores";
            ls_p3_cpu_cores.Size = new Size(65, 68);
            ls_p3_cpu_cores.TabIndex = 5;
            ls_p3_cpu_cores.Text = "Number of Cores:";
            ls_p3_cpu_cores.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlp_p3_cpu_cores
            // 
            tlp_p3_cpu_cores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlp_p3_cpu_cores.AutoSize = true;
            tlp_p3_cpu_cores.ColumnCount = 3;
            tlp_p3_cpu_cores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.76023F));
            tlp_p3_cpu_cores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.40309F));
            tlp_p3_cpu_cores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8366776F));
            tlp_p3_cpu_cores.Controls.Add(l_p3_coreBoundaryRight, 1, 1);
            tlp_p3_cpu_cores.Controls.Add(slider_p3_cores, 0, 0);
            tlp_p3_cpu_cores.Controls.Add(ls_p3_coreBoundaryLeft, 0, 1);
            tlp_p3_cpu_cores.Controls.Add(num_p3_cores, 2, 0);
            tlp_p3_cpu_cores.Location = new Point(96, 49);
            tlp_p3_cpu_cores.Margin = new Padding(5, 9, 5, 9);
            tlp_p3_cpu_cores.Name = "tlp_p3_cpu_cores";
            tlp_p3_cpu_cores.RowCount = 2;
            tlp_p3_cpu_cores.RowStyles.Add(new RowStyle());
            tlp_p3_cpu_cores.RowStyles.Add(new RowStyle());
            tlp_p3_cpu_cores.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tlp_p3_cpu_cores.Size = new Size(442, 68);
            tlp_p3_cpu_cores.TabIndex = 7;
            // 
            // l_p3_coreBoundaryRight
            // 
            l_p3_coreBoundaryRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_p3_coreBoundaryRight.AutoSize = true;
            l_p3_coreBoundaryRight.Location = new Point(280, 49);
            l_p3_coreBoundaryRight.Margin = new Padding(5, 0, 0, 4);
            l_p3_coreBoundaryRight.Name = "l_p3_coreBoundaryRight";
            l_p3_coreBoundaryRight.Size = new Size(52, 15);
            l_p3_coreBoundaryRight.TabIndex = 8;
            l_p3_coreBoundaryRight.Text = "16 Cores";
            l_p3_coreBoundaryRight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // slider_p3_cores
            // 
            slider_p3_cores.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_p3_cpu_cores.SetColumnSpan(slider_p3_cores, 2);
            slider_p3_cores.LargeChange = 1;
            slider_p3_cores.Location = new Point(5, 4);
            slider_p3_cores.Margin = new Padding(5, 4, 10, 0);
            slider_p3_cores.Maximum = 16;
            slider_p3_cores.Minimum = 1;
            slider_p3_cores.Name = "slider_p3_cores";
            slider_p3_cores.Size = new Size(317, 45);
            slider_p3_cores.TabIndex = 6;
            slider_p3_cores.TickStyle = TickStyle.Both;
            slider_p3_cores.Value = 1;
            slider_p3_cores.Scroll += tb_p3_cores_Scroll;
            // 
            // ls_p3_coreBoundaryLeft
            // 
            ls_p3_coreBoundaryLeft.AutoSize = true;
            ls_p3_coreBoundaryLeft.Location = new Point(0, 49);
            ls_p3_coreBoundaryLeft.Margin = new Padding(0, 0, 5, 4);
            ls_p3_coreBoundaryLeft.Name = "ls_p3_coreBoundaryLeft";
            ls_p3_coreBoundaryLeft.Size = new Size(41, 15);
            ls_p3_coreBoundaryLeft.TabIndex = 7;
            ls_p3_coreBoundaryLeft.Text = "1 Core";
            ls_p3_coreBoundaryLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // num_p3_cores
            // 
            num_p3_cores.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            num_p3_cores.Location = new Point(337, 13);
            num_p3_cores.Margin = new Padding(5, 4, 5, 4);
            num_p3_cores.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            num_p3_cores.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_p3_cores.Name = "num_p3_cores";
            num_p3_cores.RightToLeft = RightToLeft.No;
            num_p3_cores.Size = new Size(100, 23);
            num_p3_cores.TabIndex = 9;
            num_p3_cores.Value = new decimal(new int[] { 1, 0, 0, 0 });
            num_p3_cores.ValueChanged += num_p3_cores_ValueChanged;
            // 
            // tlp_p3_ram
            // 
            tlp_p3_ram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlp_p3_ram.AutoSize = true;
            tlp_p3_ram.ColumnCount = 3;
            tlp_p3_ram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3462524F));
            tlp_p3_ram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.64405F));
            tlp_p3_ram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0096931F));
            tlp_p3_ram.Controls.Add(l_p3_ramBoundaryRight, 1, 1);
            tlp_p3_ram.Controls.Add(slider_p3_ram, 0, 0);
            tlp_p3_ram.Controls.Add(ls_p3_ramBoundaryLeft, 0, 1);
            tlp_p3_ram.Controls.Add(num_p3_ram, 2, 0);
            tlp_p3_ram.Location = new Point(96, 135);
            tlp_p3_ram.Margin = new Padding(5, 9, 5, 9);
            tlp_p3_ram.Name = "tlp_p3_ram";
            tlp_p3_ram.RowCount = 2;
            tlp_p3_ram.RowStyles.Add(new RowStyle());
            tlp_p3_ram.RowStyles.Add(new RowStyle());
            tlp_p3_ram.Size = new Size(442, 68);
            tlp_p3_ram.TabIndex = 8;
            // 
            // l_p3_ramBoundaryRight
            // 
            l_p3_ramBoundaryRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_p3_ramBoundaryRight.AutoSize = true;
            l_p3_ramBoundaryRight.Location = new Point(294, 49);
            l_p3_ramBoundaryRight.Margin = new Padding(5, 0, 0, 4);
            l_p3_ramBoundaryRight.Name = "l_p3_ramBoundaryRight";
            l_p3_ramBoundaryRight.Size = new Size(37, 15);
            l_p3_ramBoundaryRight.TabIndex = 8;
            l_p3_ramBoundaryRight.Text = "16 GB";
            l_p3_ramBoundaryRight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // slider_p3_ram
            // 
            slider_p3_ram.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_p3_ram.SetColumnSpan(slider_p3_ram, 2);
            slider_p3_ram.LargeChange = 2048;
            slider_p3_ram.Location = new Point(5, 4);
            slider_p3_ram.Margin = new Padding(5, 4, 10, 0);
            slider_p3_ram.Maximum = 16384;
            slider_p3_ram.Minimum = 1;
            slider_p3_ram.Name = "slider_p3_ram";
            slider_p3_ram.Size = new Size(316, 45);
            slider_p3_ram.SmallChange = 1024;
            slider_p3_ram.TabIndex = 6;
            slider_p3_ram.TickFrequency = 4096;
            slider_p3_ram.TickStyle = TickStyle.Both;
            slider_p3_ram.Value = 1;
            slider_p3_ram.Scroll += slider_p3_ram_Scroll;
            // 
            // ls_p3_ramBoundaryLeft
            // 
            ls_p3_ramBoundaryLeft.AutoSize = true;
            ls_p3_ramBoundaryLeft.Location = new Point(0, 49);
            ls_p3_ramBoundaryLeft.Margin = new Padding(0, 0, 5, 4);
            ls_p3_ramBoundaryLeft.Name = "ls_p3_ramBoundaryLeft";
            ls_p3_ramBoundaryLeft.Size = new Size(34, 15);
            ls_p3_ramBoundaryLeft.TabIndex = 7;
            ls_p3_ramBoundaryLeft.Text = "1 MB";
            ls_p3_ramBoundaryLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // num_p3_ram
            // 
            num_p3_ram.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            num_p3_ram.Location = new Point(336, 13);
            num_p3_ram.Margin = new Padding(5, 4, 5, 4);
            num_p3_ram.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            num_p3_ram.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_p3_ram.Name = "num_p3_ram";
            num_p3_ram.RightToLeft = RightToLeft.No;
            num_p3_ram.Size = new Size(101, 23);
            num_p3_ram.TabIndex = 9;
            num_p3_ram.Value = new decimal(new int[] { 1, 0, 0, 0 });
            num_p3_ram.ValueChanged += num_p3_ram_ValueChanged;
            // 
            // ls_p3_cpu_ram
            // 
            ls_p3_cpu_ram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p3_cpu_ram.AutoSize = true;
            ls_p3_cpu_ram.Location = new Point(50, 135);
            ls_p3_cpu_ram.Margin = new Padding(5, 9, 5, 9);
            ls_p3_cpu_ram.Name = "ls_p3_cpu_ram";
            ls_p3_cpu_ram.Size = new Size(36, 68);
            ls_p3_cpu_ram.TabIndex = 9;
            ls_p3_cpu_ram.Text = "RAM:";
            ls_p3_cpu_ram.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tp_p3_main_graphics
            // 
            tp_p3_main_graphics.BorderStyle = BorderStyle.FixedSingle;
            tp_p3_main_graphics.Controls.Add(tlp_p3_main);
            tp_p3_main_graphics.Location = new Point(4, 24);
            tp_p3_main_graphics.Name = "tp_p3_main_graphics";
            tp_p3_main_graphics.Padding = new Padding(3);
            tp_p3_main_graphics.Size = new Size(556, 274);
            tp_p3_main_graphics.TabIndex = 3;
            tp_p3_main_graphics.Text = "Graphics/Audio";
            tp_p3_main_graphics.UseVisualStyleBackColor = true;
            // 
            // tlp_p3_main
            // 
            tlp_p3_main.ColumnCount = 1;
            tlp_p3_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_p3_main.Controls.Add(gb_p3_graphics, 0, 0);
            tlp_p3_main.Controls.Add(gb_p3_audio, 0, 1);
            tlp_p3_main.Dock = DockStyle.Fill;
            tlp_p3_main.Location = new Point(3, 3);
            tlp_p3_main.Margin = new Padding(5, 4, 5, 4);
            tlp_p3_main.Name = "tlp_p3_main";
            tlp_p3_main.Padding = new Padding(5, 9, 5, 4);
            tlp_p3_main.RowCount = 3;
            tlp_p3_main.RowStyles.Add(new RowStyle());
            tlp_p3_main.RowStyles.Add(new RowStyle());
            tlp_p3_main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_p3_main.Size = new Size(548, 266);
            tlp_p3_main.TabIndex = 1;
            // 
            // gb_p3_graphics
            // 
            gb_p3_graphics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_p3_graphics.AutoSize = true;
            gb_p3_graphics.Controls.Add(tlp_p3_graphics);
            gb_p3_graphics.Location = new Point(10, 13);
            gb_p3_graphics.Margin = new Padding(5, 4, 5, 4);
            gb_p3_graphics.Name = "gb_p3_graphics";
            gb_p3_graphics.Padding = new Padding(3, 3, 3, 7);
            gb_p3_graphics.Size = new Size(528, 65);
            gb_p3_graphics.TabIndex = 0;
            gb_p3_graphics.TabStop = false;
            gb_p3_graphics.Text = "Graphics";
            // 
            // tlp_p3_graphics
            // 
            tlp_p3_graphics.AutoSize = true;
            tlp_p3_graphics.ColumnCount = 2;
            tlp_p3_graphics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.53125F));
            tlp_p3_graphics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.46875F));
            tlp_p3_graphics.Controls.Add(cb_p3_graphics, 1, 0);
            tlp_p3_graphics.Controls.Add(ls_p3_graphics, 0, 0);
            tlp_p3_graphics.Dock = DockStyle.Fill;
            tlp_p3_graphics.Location = new Point(3, 19);
            tlp_p3_graphics.Margin = new Padding(5, 4, 5, 4);
            tlp_p3_graphics.Name = "tlp_p3_graphics";
            tlp_p3_graphics.Padding = new Padding(5, 4, 5, 4);
            tlp_p3_graphics.RowCount = 1;
            tlp_p3_graphics.RowStyles.Add(new RowStyle());
            tlp_p3_graphics.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlp_p3_graphics.Size = new Size(522, 39);
            tlp_p3_graphics.TabIndex = 0;
            // 
            // cb_p3_graphics
            // 
            cb_p3_graphics.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_p3_graphics.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p3_graphics.FormattingEnabled = true;
            cb_p3_graphics.Items.AddRange(new object[] { "" });
            cb_p3_graphics.Location = new Point(110, 8);
            cb_p3_graphics.Margin = new Padding(5, 4, 5, 4);
            cb_p3_graphics.Name = "cb_p3_graphics";
            cb_p3_graphics.Size = new Size(402, 23);
            cb_p3_graphics.TabIndex = 1;
            // 
            // ls_p3_graphics
            // 
            ls_p3_graphics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p3_graphics.AutoSize = true;
            ls_p3_graphics.Location = new Point(37, 8);
            ls_p3_graphics.Margin = new Padding(5, 4, 5, 4);
            ls_p3_graphics.Name = "ls_p3_graphics";
            ls_p3_graphics.Size = new Size(63, 23);
            ls_p3_graphics.TabIndex = 0;
            ls_p3_graphics.Text = "Controller:";
            ls_p3_graphics.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gb_p3_audio
            // 
            gb_p3_audio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_p3_audio.AutoSize = true;
            gb_p3_audio.Controls.Add(tlp_p3_audio);
            gb_p3_audio.Location = new Point(10, 86);
            gb_p3_audio.Margin = new Padding(5, 4, 5, 4);
            gb_p3_audio.Name = "gb_p3_audio";
            gb_p3_audio.Padding = new Padding(3, 3, 3, 7);
            gb_p3_audio.Size = new Size(528, 65);
            gb_p3_audio.TabIndex = 3;
            gb_p3_audio.TabStop = false;
            gb_p3_audio.Text = "Audio";
            // 
            // tlp_p3_audio
            // 
            tlp_p3_audio.AutoSize = true;
            tlp_p3_audio.ColumnCount = 2;
            tlp_p3_audio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.55469F));
            tlp_p3_audio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.44531F));
            tlp_p3_audio.Controls.Add(cb_p3_audio, 1, 0);
            tlp_p3_audio.Controls.Add(ls_p3_audio, 0, 0);
            tlp_p3_audio.Dock = DockStyle.Fill;
            tlp_p3_audio.Location = new Point(3, 19);
            tlp_p3_audio.Margin = new Padding(5, 4, 5, 4);
            tlp_p3_audio.Name = "tlp_p3_audio";
            tlp_p3_audio.Padding = new Padding(5, 4, 5, 4);
            tlp_p3_audio.RowCount = 1;
            tlp_p3_audio.RowStyles.Add(new RowStyle());
            tlp_p3_audio.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlp_p3_audio.Size = new Size(522, 39);
            tlp_p3_audio.TabIndex = 0;
            // 
            // cb_p3_audio
            // 
            cb_p3_audio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_p3_audio.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p3_audio.FormattingEnabled = true;
            cb_p3_audio.Items.AddRange(new object[] { "" });
            cb_p3_audio.Location = new Point(105, 8);
            cb_p3_audio.Margin = new Padding(5, 4, 5, 4);
            cb_p3_audio.Name = "cb_p3_audio";
            cb_p3_audio.Size = new Size(407, 23);
            cb_p3_audio.TabIndex = 3;
            // 
            // ls_p3_audio
            // 
            ls_p3_audio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p3_audio.AutoSize = true;
            ls_p3_audio.Location = new Point(53, 8);
            ls_p3_audio.Margin = new Padding(5, 4, 5, 4);
            ls_p3_audio.Name = "ls_p3_audio";
            ls_p3_audio.Size = new Size(42, 23);
            ls_p3_audio.TabIndex = 2;
            ls_p3_audio.Text = "Audio:";
            ls_p3_audio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tp_p3_main_accel
            // 
            tp_p3_main_accel.Location = new Point(4, 24);
            tp_p3_main_accel.Name = "tp_p3_main_accel";
            tp_p3_main_accel.Padding = new Padding(3);
            tp_p3_main_accel.Size = new Size(556, 274);
            tp_p3_main_accel.TabIndex = 4;
            tp_p3_main_accel.Text = "Acceleration";
            tp_p3_main_accel.UseVisualStyleBackColor = true;
            // 
            // pfin
            // 
            pfin.Controls.Add(sc_pfin_main);
            pfin.Dock = DockStyle.Fill;
            pfin.Location = new Point(10, 9);
            pfin.Name = "pfin";
            pfin.Size = new Size(574, 367);
            pfin.TabIndex = 1;
            pfin.Visible = false;
            // 
            // sc_pfin_main
            // 
            sc_pfin_main.Dock = DockStyle.Fill;
            sc_pfin_main.IsSplitterFixed = true;
            sc_pfin_main.Location = new Point(0, 0);
            sc_pfin_main.Name = "sc_pfin_main";
            sc_pfin_main.Orientation = Orientation.Horizontal;
            // 
            // sc_pfin_main.Panel1
            // 
            sc_pfin_main.Panel1.Controls.Add(ls_pfin_info);
            // 
            // sc_pfin_main.Panel2
            // 
            sc_pfin_main.Panel2.Controls.Add(tlp_pfin_main);
            sc_pfin_main.Panel2.Padding = new Padding(5, 4, 5, 4);
            sc_pfin_main.Size = new Size(574, 367);
            sc_pfin_main.SplitterDistance = 53;
            sc_pfin_main.TabIndex = 1;
            sc_pfin_main.TabStop = false;
            // 
            // ls_pfin_info
            // 
            ls_pfin_info.Dock = DockStyle.Fill;
            ls_pfin_info.Location = new Point(0, 0);
            ls_pfin_info.Margin = new Padding(0);
            ls_pfin_info.Name = "ls_pfin_info";
            ls_pfin_info.Padding = new Padding(5, 4, 5, 4);
            ls_pfin_info.Size = new Size(574, 53);
            ls_pfin_info.TabIndex = 1;
            ls_pfin_info.Text = "Confirm your VM settings.";
            ls_pfin_info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlp_pfin_main
            // 
            tlp_pfin_main.ColumnCount = 2;
            tlp_pfin_main.ColumnStyles.Add(new ColumnStyle());
            tlp_pfin_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_pfin_main.Controls.Add(ls_pfin_name, 0, 0);
            tlp_pfin_main.Controls.Add(ls_pfin_emtype, 0, 1);
            tlp_pfin_main.Controls.Add(ls_pfin_os, 0, 2);
            tlp_pfin_main.Controls.Add(l_pfin_name, 1, 0);
            tlp_pfin_main.Controls.Add(l_pfin_emType, 1, 1);
            tlp_pfin_main.Controls.Add(l_pfin_os, 1, 2);
            tlp_pfin_main.Controls.Add(ls_pfin_machine, 0, 3);
            tlp_pfin_main.Controls.Add(l_pfin_machine, 1, 3);
            tlp_pfin_main.Controls.Add(ls_pfin_ram, 0, 5);
            tlp_pfin_main.Controls.Add(l_pfin_ram, 1, 5);
            tlp_pfin_main.Controls.Add(ls_pfin_cpu, 0, 4);
            tlp_pfin_main.Controls.Add(l_pfin_cpu, 1, 4);
            tlp_pfin_main.Controls.Add(gb_pfin_diskWrapper, 0, 7);
            tlp_pfin_main.Dock = DockStyle.Fill;
            tlp_pfin_main.Location = new Point(5, 4);
            tlp_pfin_main.Name = "tlp_pfin_main";
            tlp_pfin_main.RowCount = 8;
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.Size = new Size(564, 302);
            tlp_pfin_main.TabIndex = 0;
            // 
            // ls_pfin_name
            // 
            ls_pfin_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_name.AutoSize = true;
            ls_pfin_name.Location = new Point(72, 9);
            ls_pfin_name.Margin = new Padding(10, 9, 2, 9);
            ls_pfin_name.Name = "ls_pfin_name";
            ls_pfin_name.Size = new Size(42, 15);
            ls_pfin_name.TabIndex = 0;
            ls_pfin_name.Text = "Name:";
            ls_pfin_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_pfin_emtype
            // 
            ls_pfin_emtype.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_emtype.AutoSize = true;
            ls_pfin_emtype.Location = new Point(29, 42);
            ls_pfin_emtype.Margin = new Padding(10, 9, 2, 9);
            ls_pfin_emtype.Name = "ls_pfin_emtype";
            ls_pfin_emtype.Size = new Size(85, 15);
            ls_pfin_emtype.TabIndex = 4;
            ls_pfin_emtype.Text = "Emulator Type:";
            ls_pfin_emtype.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_pfin_os
            // 
            ls_pfin_os.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_os.AutoSize = true;
            ls_pfin_os.Location = new Point(10, 75);
            ls_pfin_os.Margin = new Padding(10, 9, 2, 9);
            ls_pfin_os.Name = "ls_pfin_os";
            ls_pfin_os.Size = new Size(104, 15);
            ls_pfin_os.TabIndex = 6;
            ls_pfin_os.Text = "Operating System:";
            ls_pfin_os.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_pfin_name
            // 
            l_pfin_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_name.AutoSize = true;
            l_pfin_name.BackColor = SystemColors.ButtonHighlight;
            l_pfin_name.Location = new Point(119, 9);
            l_pfin_name.Margin = new Padding(3, 9, 10, 9);
            l_pfin_name.Name = "l_pfin_name";
            l_pfin_name.Size = new Size(435, 15);
            l_pfin_name.TabIndex = 8;
            l_pfin_name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_pfin_emType
            // 
            l_pfin_emType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_emType.AutoSize = true;
            l_pfin_emType.BackColor = SystemColors.ButtonHighlight;
            l_pfin_emType.Location = new Point(119, 42);
            l_pfin_emType.Margin = new Padding(3, 9, 10, 9);
            l_pfin_emType.Name = "l_pfin_emType";
            l_pfin_emType.Size = new Size(435, 15);
            l_pfin_emType.TabIndex = 9;
            l_pfin_emType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_pfin_os
            // 
            l_pfin_os.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_os.AutoSize = true;
            l_pfin_os.BackColor = SystemColors.ButtonHighlight;
            l_pfin_os.Location = new Point(119, 75);
            l_pfin_os.Margin = new Padding(3, 9, 10, 9);
            l_pfin_os.Name = "l_pfin_os";
            l_pfin_os.Size = new Size(435, 15);
            l_pfin_os.TabIndex = 10;
            l_pfin_os.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ls_pfin_machine
            // 
            ls_pfin_machine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_machine.AutoSize = true;
            ls_pfin_machine.Location = new Point(31, 108);
            ls_pfin_machine.Margin = new Padding(10, 9, 2, 9);
            ls_pfin_machine.Name = "ls_pfin_machine";
            ls_pfin_machine.Size = new Size(83, 15);
            ls_pfin_machine.TabIndex = 11;
            ls_pfin_machine.Text = "Machine Type:";
            ls_pfin_machine.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_pfin_machine
            // 
            l_pfin_machine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_machine.AutoSize = true;
            l_pfin_machine.BackColor = SystemColors.ButtonHighlight;
            l_pfin_machine.Location = new Point(119, 108);
            l_pfin_machine.Margin = new Padding(3, 9, 10, 9);
            l_pfin_machine.Name = "l_pfin_machine";
            l_pfin_machine.Size = new Size(435, 15);
            l_pfin_machine.TabIndex = 12;
            l_pfin_machine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ls_pfin_ram
            // 
            ls_pfin_ram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_ram.AutoSize = true;
            ls_pfin_ram.Location = new Point(78, 174);
            ls_pfin_ram.Margin = new Padding(10, 9, 2, 9);
            ls_pfin_ram.Name = "ls_pfin_ram";
            ls_pfin_ram.Size = new Size(36, 15);
            ls_pfin_ram.TabIndex = 13;
            ls_pfin_ram.Text = "RAM:";
            ls_pfin_ram.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_pfin_ram
            // 
            l_pfin_ram.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_ram.AutoSize = true;
            l_pfin_ram.BackColor = SystemColors.ButtonHighlight;
            l_pfin_ram.Location = new Point(119, 174);
            l_pfin_ram.Margin = new Padding(3, 9, 10, 9);
            l_pfin_ram.Name = "l_pfin_ram";
            l_pfin_ram.Size = new Size(435, 15);
            l_pfin_ram.TabIndex = 14;
            l_pfin_ram.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ls_pfin_cpu
            // 
            ls_pfin_cpu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_cpu.AutoSize = true;
            ls_pfin_cpu.Location = new Point(48, 141);
            ls_pfin_cpu.Margin = new Padding(10, 9, 2, 9);
            ls_pfin_cpu.Name = "ls_pfin_cpu";
            ls_pfin_cpu.Size = new Size(66, 15);
            ls_pfin_cpu.TabIndex = 15;
            ls_pfin_cpu.Text = "CPU Cores:";
            ls_pfin_cpu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_pfin_cpu
            // 
            l_pfin_cpu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_cpu.AutoSize = true;
            l_pfin_cpu.BackColor = SystemColors.ButtonHighlight;
            l_pfin_cpu.Location = new Point(119, 141);
            l_pfin_cpu.Margin = new Padding(3, 9, 10, 9);
            l_pfin_cpu.Name = "l_pfin_cpu";
            l_pfin_cpu.Size = new Size(435, 15);
            l_pfin_cpu.TabIndex = 16;
            l_pfin_cpu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gb_pfin_diskWrapper
            // 
            gb_pfin_diskWrapper.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_pfin_diskWrapper.AutoSize = true;
            tlp_pfin_main.SetColumnSpan(gb_pfin_diskWrapper, 2);
            gb_pfin_diskWrapper.Controls.Add(flp_pfin_disk);
            gb_pfin_diskWrapper.Location = new Point(9, 241);
            gb_pfin_diskWrapper.Margin = new Padding(9, 3, 9, 9);
            gb_pfin_diskWrapper.Name = "gb_pfin_diskWrapper";
            gb_pfin_diskWrapper.Padding = new Padding(5, 3, 5, 8);
            gb_pfin_diskWrapper.Size = new Size(546, 52);
            gb_pfin_diskWrapper.TabIndex = 17;
            gb_pfin_diskWrapper.TabStop = false;
            gb_pfin_diskWrapper.Text = "Disk";
            // 
            // flp_pfin_disk
            // 
            flp_pfin_disk.AutoSize = true;
            flp_pfin_disk.Controls.Add(rb_pfin_createDisk);
            flp_pfin_disk.Controls.Add(rb_pfin_skipDisks);
            flp_pfin_disk.Dock = DockStyle.Fill;
            flp_pfin_disk.Location = new Point(5, 19);
            flp_pfin_disk.Name = "flp_pfin_disk";
            flp_pfin_disk.Size = new Size(536, 25);
            flp_pfin_disk.TabIndex = 0;
            // 
            // rb_pfin_createDisk
            // 
            rb_pfin_createDisk.AutoSize = true;
            rb_pfin_createDisk.Checked = true;
            rb_pfin_createDisk.Location = new Point(3, 3);
            rb_pfin_createDisk.Name = "rb_pfin_createDisk";
            rb_pfin_createDisk.Padding = new Padding(0, 0, 50, 0);
            rb_pfin_createDisk.Size = new Size(159, 19);
            rb_pfin_createDisk.TabIndex = 0;
            rb_pfin_createDisk.TabStop = true;
            rb_pfin_createDisk.Text = "Create disk now";
            rb_pfin_createDisk.UseVisualStyleBackColor = true;
            rb_pfin_createDisk.CheckedChanged += rb_pfin_createDisk_CheckedChanged;
            // 
            // rb_pfin_skipDisks
            // 
            rb_pfin_skipDisks.AutoSize = true;
            rb_pfin_skipDisks.Location = new Point(168, 3);
            rb_pfin_skipDisks.Name = "rb_pfin_skipDisks";
            rb_pfin_skipDisks.Padding = new Padding(0, 0, 50, 0);
            rb_pfin_skipDisks.Size = new Size(210, 19);
            rb_pfin_skipDisks.TabIndex = 1;
            rb_pfin_skipDisks.Text = "Skip and create disks later";
            rb_pfin_skipDisks.UseVisualStyleBackColor = true;
            rb_pfin_skipDisks.CheckedChanged += rb_pfin_skipDisks_CheckedChanged;
            // 
            // WIN_NewMachine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(594, 429);
            Controls.Add(p_main);
            Controls.Add(fpl_bottom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(610, 468);
            Name = "WIN_NewMachine";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QEMU Interface - New Machine";
            FormClosing += WIN_NewMachine_FormClosing;
            fpl_bottom.ResumeLayout(false);
            p_main.ResumeLayout(false);
            p0.ResumeLayout(false);
            sc_p0_main.Panel1.ResumeLayout(false);
            sc_p0_main.Panel2.ResumeLayout(false);
            sc_p0_main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sc_p0_main).EndInit();
            sc_p0_main.ResumeLayout(false);
            gb_p0_basic.ResumeLayout(false);
            gb_p0_basic.PerformLayout();
            tlp_p0_basic.ResumeLayout(false);
            tlp_p0_basic.PerformLayout();
            flp_p0_emType.ResumeLayout(false);
            flp_p0_emType.PerformLayout();
            flp_p0_otherEm.ResumeLayout(false);
            flp_p0_otherEm.PerformLayout();
            p1_os.ResumeLayout(false);
            sc_p1_main.Panel1.ResumeLayout(false);
            sc_p1_main.Panel2.ResumeLayout(false);
            sc_p1_main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sc_p1_main).EndInit();
            sc_p1_main.ResumeLayout(false);
            gb_p1_os.ResumeLayout(false);
            gb_p1_os.PerformLayout();
            tlp_p1_os.ResumeLayout(false);
            tlp_p1_os.PerformLayout();
            flp_p1_osType.ResumeLayout(false);
            flp_p1_osType.PerformLayout();
            flp_p1_otherOS.ResumeLayout(false);
            flp_p1_otherOS.PerformLayout();
            flp_p1_bitness.ResumeLayout(false);
            flp_p1_bitness.PerformLayout();
            p2_pcType.ResumeLayout(false);
            sc_p2_main.Panel1.ResumeLayout(false);
            sc_p2_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_p2_main).EndInit();
            sc_p2_main.ResumeLayout(false);
            gb_p2_pcType.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            p3_hardware.ResumeLayout(false);
            sc_p3_main.Panel1.ResumeLayout(false);
            sc_p3_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_p3_main).EndInit();
            sc_p3_main.ResumeLayout(false);
            tc_p3_main.ResumeLayout(false);
            tp_p3_main_cpu.ResumeLayout(false);
            tlp_p3_cpu.ResumeLayout(false);
            tlp_p3_cpu.PerformLayout();
            tlp_p3_cpu_cores.ResumeLayout(false);
            tlp_p3_cpu_cores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slider_p3_cores).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_p3_cores).EndInit();
            tlp_p3_ram.ResumeLayout(false);
            tlp_p3_ram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slider_p3_ram).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_p3_ram).EndInit();
            tp_p3_main_graphics.ResumeLayout(false);
            tlp_p3_main.ResumeLayout(false);
            tlp_p3_main.PerformLayout();
            gb_p3_graphics.ResumeLayout(false);
            gb_p3_graphics.PerformLayout();
            tlp_p3_graphics.ResumeLayout(false);
            tlp_p3_graphics.PerformLayout();
            gb_p3_audio.ResumeLayout(false);
            gb_p3_audio.PerformLayout();
            tlp_p3_audio.ResumeLayout(false);
            tlp_p3_audio.PerformLayout();
            pfin.ResumeLayout(false);
            sc_pfin_main.Panel1.ResumeLayout(false);
            sc_pfin_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_pfin_main).EndInit();
            sc_pfin_main.ResumeLayout(false);
            tlp_pfin_main.ResumeLayout(false);
            tlp_pfin_main.PerformLayout();
            gb_pfin_diskWrapper.ResumeLayout(false);
            gb_pfin_diskWrapper.PerformLayout();
            flp_pfin_disk.ResumeLayout(false);
            flp_pfin_disk.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button b_cancel;
        private Button b_next;
        private FlowLayoutPanel fpl_bottom;
        private Panel p0;
        private Button b_back;
        private Panel pfin;
        private Panel p2_pcType;
        private Label ls_p0_info;
        private TableLayoutPanel tlp_p0_basic;
        private TextBox t_p0_name;
        private FlowLayoutPanel flp_p0_emType;
        private RadioButton rb_p0_emType_x86;
        private RadioButton rb_p0_emType_PPC;
        private FlowLayoutPanel flp_p0_otherEm;
        private RadioButton rb_p0_emType_other;
        private ComboBox cb_p0_otherEm;
        private TableLayoutPanel tlp_p1_os;
        private FlowLayoutPanel flp_p1_otherOS;
        private RadioButton rb_p1_os_other;
        private ComboBox cb_p1_otherOS;
        private RadioButton rb_p1_os_win;
        private Panel p1_os;
        private Label ls_p1_info;
        private RadioButton rb_p1_os_mac;
        private RadioButton rb_p1_os_linux;
        private ComboBox cb_p1_subversion;
        private ComboBox cb_p1_version;
        private RadioButton rb_p1_bitness_32;
        private RadioButton rb_p1_bitness_64;
        private GroupBox gb_p2_pcType;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView lv_p2_type;
        private ColumnHeader lv_p2_type_machine;
        private ColumnHeader lv_p2_type_desc;
        private Panel p3_hardware;
        private TabControl tc_p3_main;
        private TabPage tp_p3_main_cpu;
        private TabPage tp_p3_main_graphics;
        private TableLayoutPanel tlp_p3_cpu;
        private ComboBox cb_p3_cpuType;
        private TrackBar slider_p3_cores;
        private Label l_p3_coreBoundaryRight;
        private Label ls_p3_coreBoundaryLeft;
        private NumericUpDown num_p3_cores;
        private Label l_p3_ramBoundaryRight;
        private TrackBar slider_p3_ram;
        private NumericUpDown num_p3_ram;
        private Label l_p1_subversion;
        private RadioButton rb_p0_emType_m68k;
        private Label l_p1_bitness;
        private FlowLayoutPanel flp_p1_bitness;
        private TableLayoutPanel tlp_p3_main;
        private TabPage tp_p3_main_accel;
        private TableLayoutPanel tlp_pfin_main;
        private Label ls_pfin_emtype;
        private Label ls_pfin_os;
        private Label l_pfin_name;
        private Label l_pfin_emType;
        private Label l_pfin_os;
        private Label l_pfin_machine;
        private RadioButton rb_p0_emType_i386;
        private Label l_pfin_ram;
        private Label l_pfin_cpu;
        private ProgressBar progressBarGeneric;
        private Label ls_p3_graphics;
        private ComboBox cb_p3_graphics;
        private GroupBox gb_p3_graphics;
        private ComboBox cb_p3_audio;
        private RadioButton rb_pfin_createDisk;
        private RadioButton rb_pfin_skipDisks;
        private GroupBox gb_pfin_diskWrapper;
    }
}