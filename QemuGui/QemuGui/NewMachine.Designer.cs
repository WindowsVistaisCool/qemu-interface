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
            SplitContainer sc_pfin_main;
            Label ls_pfin_info;
            Label ls_pfin_name;
            Label ls_pfin_emtype;
            Label ls_pfin_os;
            Label ls_pfin_machine;
            Label ls_pfin_ram;
            Label label2;
            SplitContainer sc_p3_main;
            Label ls_p3_info;
            Label ls_p3_cpu_type;
            Label ls_p3_cpu_cores;
            TableLayoutPanel tlp_p3_cpu_cores;
            Label ls_p3_coreBoundaryLeft;
            TableLayoutPanel tlp_p3_ram;
            Label ls_p3_ramBoundaryLeft;
            Label ls_p3_cpu_ram;
            SplitContainer sc_p1_main;
            Label ls_p1_info;
            GroupBox gb_p1_os;
            Label ls_p1_version;
            FlowLayoutPanel flp_p1_osType;
            Label ls_p0_osName;
            SplitContainer sc_p0_main;
            Label ls_p0_info;
            Label ls_p0_placeholder;
            GroupBox gb_p0_basic;
            Label ls_p0_emulator;
            Label ls_p0_name;
            FlowLayoutPanel flp_p0_emType;
            SplitContainer sc_p2_main;
            Label ls_p2_info;
            Label label1;
            b_cancel = new Button();
            b_next = new Button();
            b_back = new Button();
            pfin = new Panel();
            tlp_pfin_main = new TableLayoutPanel();
            l_pfin_name = new Label();
            l_pfin_emType = new Label();
            l_pfin_os = new Label();
            l_pfin_machine = new Label();
            l_pfin_ram = new Label();
            l_pfin_cpu = new Label();
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
            tlp_p3_graphics = new TableLayoutPanel();
            tp_p3_main_accel = new TabPage();
            p1 = new Panel();
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
            p2_pcType = new Panel();
            gb_p1_hardware = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lv_p2_type = new ListView();
            lv_p2_type_machine = new ColumnHeader();
            lv_p2_type_desc = new ColumnHeader();
            fpl_bottom = new FlowLayoutPanel();
            p_main = new Panel();
            sc_pfin_main = new SplitContainer();
            ls_pfin_info = new Label();
            ls_pfin_name = new Label();
            ls_pfin_emtype = new Label();
            ls_pfin_os = new Label();
            ls_pfin_machine = new Label();
            ls_pfin_ram = new Label();
            label2 = new Label();
            sc_p3_main = new SplitContainer();
            ls_p3_info = new Label();
            ls_p3_cpu_type = new Label();
            ls_p3_cpu_cores = new Label();
            tlp_p3_cpu_cores = new TableLayoutPanel();
            ls_p3_coreBoundaryLeft = new Label();
            tlp_p3_ram = new TableLayoutPanel();
            ls_p3_ramBoundaryLeft = new Label();
            ls_p3_cpu_ram = new Label();
            sc_p1_main = new SplitContainer();
            ls_p1_info = new Label();
            gb_p1_os = new GroupBox();
            ls_p1_version = new Label();
            flp_p1_osType = new FlowLayoutPanel();
            ls_p0_osName = new Label();
            sc_p0_main = new SplitContainer();
            ls_p0_info = new Label();
            ls_p0_placeholder = new Label();
            gb_p0_basic = new GroupBox();
            ls_p0_emulator = new Label();
            ls_p0_name = new Label();
            flp_p0_emType = new FlowLayoutPanel();
            sc_p2_main = new SplitContainer();
            ls_p2_info = new Label();
            label1 = new Label();
            fpl_bottom.SuspendLayout();
            p_main.SuspendLayout();
            pfin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_pfin_main).BeginInit();
            sc_pfin_main.Panel1.SuspendLayout();
            sc_pfin_main.Panel2.SuspendLayout();
            sc_pfin_main.SuspendLayout();
            tlp_pfin_main.SuspendLayout();
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
            p1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_p1_main).BeginInit();
            sc_p1_main.Panel1.SuspendLayout();
            sc_p1_main.Panel2.SuspendLayout();
            sc_p1_main.SuspendLayout();
            gb_p1_os.SuspendLayout();
            tlp_p1_os.SuspendLayout();
            flp_p1_osType.SuspendLayout();
            flp_p1_otherOS.SuspendLayout();
            flp_p1_bitness.SuspendLayout();
            p0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_p0_main).BeginInit();
            sc_p0_main.Panel1.SuspendLayout();
            sc_p0_main.Panel2.SuspendLayout();
            sc_p0_main.SuspendLayout();
            gb_p0_basic.SuspendLayout();
            tlp_p0_basic.SuspendLayout();
            flp_p0_emType.SuspendLayout();
            flp_p0_otherEm.SuspendLayout();
            p2_pcType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_p2_main).BeginInit();
            sc_p2_main.Panel1.SuspendLayout();
            sc_p2_main.Panel2.SuspendLayout();
            sc_p2_main.SuspendLayout();
            gb_p1_hardware.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // fpl_bottom
            // 
            fpl_bottom.AutoSize = true;
            fpl_bottom.BackColor = SystemColors.ControlLight;
            fpl_bottom.Controls.Add(b_cancel);
            fpl_bottom.Controls.Add(b_next);
            fpl_bottom.Controls.Add(b_back);
            fpl_bottom.Dock = DockStyle.Bottom;
            fpl_bottom.FlowDirection = FlowDirection.RightToLeft;
            fpl_bottom.Location = new Point(0, 434);
            fpl_bottom.Name = "fpl_bottom";
            fpl_bottom.Size = new Size(593, 49);
            fpl_bottom.TabIndex = 2;
            // 
            // b_cancel
            // 
            b_cancel.Location = new Point(497, 10);
            b_cancel.Margin = new Padding(5, 10, 10, 10);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(86, 29);
            b_cancel.TabIndex = 1;
            b_cancel.Text = "Cancel";
            b_cancel.UseVisualStyleBackColor = true;
            b_cancel.Click += b_cancel_Click;
            // 
            // b_next
            // 
            b_next.Enabled = false;
            b_next.Location = new Point(391, 10);
            b_next.Margin = new Padding(5, 10, 15, 10);
            b_next.Name = "b_next";
            b_next.Size = new Size(86, 29);
            b_next.TabIndex = 0;
            b_next.Text = "Next >";
            b_next.UseVisualStyleBackColor = true;
            b_next.Click += b_next_Click;
            // 
            // b_back
            // 
            b_back.Enabled = false;
            b_back.Location = new Point(298, 10);
            b_back.Margin = new Padding(5, 10, 5, 10);
            b_back.Name = "b_back";
            b_back.Size = new Size(83, 29);
            b_back.TabIndex = 2;
            b_back.Text = "< Back";
            b_back.UseVisualStyleBackColor = true;
            b_back.Click += b_back_Click;
            // 
            // p_main
            // 
            p_main.BackColor = SystemColors.Control;
            p_main.Controls.Add(pfin);
            p_main.Controls.Add(p3_hardware);
            p_main.Controls.Add(p1);
            p_main.Controls.Add(p0);
            p_main.Controls.Add(p2_pcType);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Margin = new Padding(0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(10);
            p_main.Size = new Size(593, 434);
            p_main.TabIndex = 3;
            // 
            // pfin
            // 
            pfin.Controls.Add(sc_pfin_main);
            pfin.Dock = DockStyle.Fill;
            pfin.Location = new Point(10, 10);
            pfin.Name = "pfin";
            pfin.Size = new Size(573, 414);
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
            sc_pfin_main.Panel2.Padding = new Padding(5);
            sc_pfin_main.Size = new Size(573, 414);
            sc_pfin_main.SplitterDistance = 63;
            sc_pfin_main.SplitterWidth = 5;
            sc_pfin_main.TabIndex = 1;
            // 
            // ls_pfin_info
            // 
            ls_pfin_info.Dock = DockStyle.Fill;
            ls_pfin_info.Location = new Point(0, 0);
            ls_pfin_info.Margin = new Padding(0);
            ls_pfin_info.Name = "ls_pfin_info";
            ls_pfin_info.Padding = new Padding(5);
            ls_pfin_info.Size = new Size(573, 63);
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
            tlp_pfin_main.Controls.Add(label2, 0, 4);
            tlp_pfin_main.Controls.Add(l_pfin_cpu, 1, 4);
            tlp_pfin_main.Dock = DockStyle.Fill;
            tlp_pfin_main.Location = new Point(5, 5);
            tlp_pfin_main.Name = "tlp_pfin_main";
            tlp_pfin_main.RowCount = 7;
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle());
            tlp_pfin_main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_pfin_main.Size = new Size(563, 336);
            tlp_pfin_main.TabIndex = 0;
            // 
            // ls_pfin_name
            // 
            ls_pfin_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_name.AutoSize = true;
            ls_pfin_name.Location = new Point(79, 10);
            ls_pfin_name.Margin = new Padding(10, 10, 2, 10);
            ls_pfin_name.Name = "ls_pfin_name";
            ls_pfin_name.Size = new Size(46, 17);
            ls_pfin_name.TabIndex = 0;
            ls_pfin_name.Text = "Name:";
            ls_pfin_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_pfin_emtype
            // 
            ls_pfin_emtype.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_emtype.AutoSize = true;
            ls_pfin_emtype.Location = new Point(31, 47);
            ls_pfin_emtype.Margin = new Padding(10, 10, 2, 10);
            ls_pfin_emtype.Name = "ls_pfin_emtype";
            ls_pfin_emtype.Size = new Size(94, 17);
            ls_pfin_emtype.TabIndex = 4;
            ls_pfin_emtype.Text = "Emulator Type:";
            ls_pfin_emtype.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_pfin_os
            // 
            ls_pfin_os.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_os.AutoSize = true;
            ls_pfin_os.Location = new Point(10, 84);
            ls_pfin_os.Margin = new Padding(10, 10, 2, 10);
            ls_pfin_os.Name = "ls_pfin_os";
            ls_pfin_os.Size = new Size(115, 17);
            ls_pfin_os.TabIndex = 6;
            ls_pfin_os.Text = "Operating System:";
            ls_pfin_os.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_pfin_name
            // 
            l_pfin_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_name.AutoSize = true;
            l_pfin_name.BackColor = SystemColors.ButtonHighlight;
            l_pfin_name.Location = new Point(130, 10);
            l_pfin_name.Margin = new Padding(3, 10, 10, 10);
            l_pfin_name.Name = "l_pfin_name";
            l_pfin_name.Size = new Size(423, 17);
            l_pfin_name.TabIndex = 8;
            l_pfin_name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_pfin_emType
            // 
            l_pfin_emType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_emType.AutoSize = true;
            l_pfin_emType.BackColor = SystemColors.ButtonHighlight;
            l_pfin_emType.Location = new Point(130, 47);
            l_pfin_emType.Margin = new Padding(3, 10, 10, 10);
            l_pfin_emType.Name = "l_pfin_emType";
            l_pfin_emType.Size = new Size(423, 17);
            l_pfin_emType.TabIndex = 9;
            l_pfin_emType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_pfin_os
            // 
            l_pfin_os.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_os.AutoSize = true;
            l_pfin_os.BackColor = SystemColors.ButtonHighlight;
            l_pfin_os.Location = new Point(130, 84);
            l_pfin_os.Margin = new Padding(3, 10, 10, 10);
            l_pfin_os.Name = "l_pfin_os";
            l_pfin_os.Size = new Size(423, 17);
            l_pfin_os.TabIndex = 10;
            l_pfin_os.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ls_pfin_machine
            // 
            ls_pfin_machine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_machine.AutoSize = true;
            ls_pfin_machine.Location = new Point(34, 121);
            ls_pfin_machine.Margin = new Padding(10, 10, 2, 10);
            ls_pfin_machine.Name = "ls_pfin_machine";
            ls_pfin_machine.Size = new Size(91, 17);
            ls_pfin_machine.TabIndex = 11;
            ls_pfin_machine.Text = "Machine Type:";
            ls_pfin_machine.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_pfin_machine
            // 
            l_pfin_machine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_machine.AutoSize = true;
            l_pfin_machine.BackColor = SystemColors.ButtonHighlight;
            l_pfin_machine.Location = new Point(130, 121);
            l_pfin_machine.Margin = new Padding(3, 10, 10, 10);
            l_pfin_machine.Name = "l_pfin_machine";
            l_pfin_machine.Size = new Size(423, 17);
            l_pfin_machine.TabIndex = 12;
            l_pfin_machine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ls_pfin_ram
            // 
            ls_pfin_ram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_pfin_ram.AutoSize = true;
            ls_pfin_ram.Location = new Point(86, 195);
            ls_pfin_ram.Margin = new Padding(10, 10, 2, 10);
            ls_pfin_ram.Name = "ls_pfin_ram";
            ls_pfin_ram.Size = new Size(39, 17);
            ls_pfin_ram.TabIndex = 13;
            ls_pfin_ram.Text = "RAM:";
            ls_pfin_ram.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_pfin_ram
            // 
            l_pfin_ram.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_ram.AutoSize = true;
            l_pfin_ram.BackColor = SystemColors.ButtonHighlight;
            l_pfin_ram.Location = new Point(130, 195);
            l_pfin_ram.Margin = new Padding(3, 10, 10, 10);
            l_pfin_ram.Name = "l_pfin_ram";
            l_pfin_ram.Size = new Size(423, 17);
            l_pfin_ram.TabIndex = 14;
            l_pfin_ram.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(52, 158);
            label2.Margin = new Padding(10, 10, 2, 10);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 15;
            label2.Text = "CPU Cores:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_pfin_cpu
            // 
            l_pfin_cpu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_pfin_cpu.AutoSize = true;
            l_pfin_cpu.BackColor = SystemColors.ButtonHighlight;
            l_pfin_cpu.Location = new Point(130, 158);
            l_pfin_cpu.Margin = new Padding(3, 10, 10, 10);
            l_pfin_cpu.Name = "l_pfin_cpu";
            l_pfin_cpu.Size = new Size(423, 17);
            l_pfin_cpu.TabIndex = 16;
            l_pfin_cpu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // p3_hardware
            // 
            p3_hardware.Controls.Add(sc_p3_main);
            p3_hardware.Dock = DockStyle.Fill;
            p3_hardware.Location = new Point(10, 10);
            p3_hardware.Name = "p3_hardware";
            p3_hardware.Size = new Size(573, 414);
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
            sc_p3_main.Panel2.Padding = new Padding(5);
            sc_p3_main.Size = new Size(573, 414);
            sc_p3_main.SplitterDistance = 63;
            sc_p3_main.SplitterWidth = 5;
            sc_p3_main.TabIndex = 0;
            // 
            // ls_p3_info
            // 
            ls_p3_info.Dock = DockStyle.Fill;
            ls_p3_info.Location = new Point(0, 0);
            ls_p3_info.Margin = new Padding(0);
            ls_p3_info.Name = "ls_p3_info";
            ls_p3_info.Padding = new Padding(5);
            ls_p3_info.Size = new Size(573, 63);
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
            tc_p3_main.Location = new Point(5, 5);
            tc_p3_main.Margin = new Padding(5);
            tc_p3_main.Name = "tc_p3_main";
            tc_p3_main.SelectedIndex = 0;
            tc_p3_main.Size = new Size(563, 336);
            tc_p3_main.TabIndex = 0;
            // 
            // tp_p3_main_cpu
            // 
            tp_p3_main_cpu.BackColor = SystemColors.ControlLightLight;
            tp_p3_main_cpu.BorderStyle = BorderStyle.FixedSingle;
            tp_p3_main_cpu.Controls.Add(tlp_p3_cpu);
            tp_p3_main_cpu.Location = new Point(4, 26);
            tp_p3_main_cpu.Name = "tp_p3_main_cpu";
            tp_p3_main_cpu.Padding = new Padding(3);
            tp_p3_main_cpu.Size = new Size(555, 306);
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
            tlp_p3_cpu.Margin = new Padding(5);
            tlp_p3_cpu.Name = "tlp_p3_cpu";
            tlp_p3_cpu.Padding = new Padding(5, 10, 5, 5);
            tlp_p3_cpu.RowCount = 4;
            tlp_p3_cpu.RowStyles.Add(new RowStyle());
            tlp_p3_cpu.RowStyles.Add(new RowStyle());
            tlp_p3_cpu.RowStyles.Add(new RowStyle());
            tlp_p3_cpu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_p3_cpu.Size = new Size(547, 298);
            tlp_p3_cpu.TabIndex = 0;
            // 
            // ls_p3_cpu_type
            // 
            ls_p3_cpu_type.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p3_cpu_type.AutoSize = true;
            ls_p3_cpu_type.Location = new Point(19, 15);
            ls_p3_cpu_type.Margin = new Padding(5);
            ls_p3_cpu_type.Name = "ls_p3_cpu_type";
            ls_p3_cpu_type.Size = new Size(66, 25);
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
            cb_p3_cpuType.Location = new Point(100, 15);
            cb_p3_cpuType.Margin = new Padding(10, 5, 10, 5);
            cb_p3_cpuType.Name = "cb_p3_cpuType";
            cb_p3_cpuType.Size = new Size(432, 25);
            cb_p3_cpuType.TabIndex = 4;
            cb_p3_cpuType.Visible = false;
            // 
            // ls_p3_cpu_cores
            // 
            ls_p3_cpu_cores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p3_cpu_cores.AutoSize = true;
            ls_p3_cpu_cores.Location = new Point(13, 55);
            ls_p3_cpu_cores.Margin = new Padding(5, 10, 5, 10);
            ls_p3_cpu_cores.Name = "ls_p3_cpu_cores";
            ls_p3_cpu_cores.Size = new Size(72, 77);
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
            tlp_p3_cpu_cores.Location = new Point(95, 55);
            tlp_p3_cpu_cores.Margin = new Padding(5, 10, 5, 10);
            tlp_p3_cpu_cores.Name = "tlp_p3_cpu_cores";
            tlp_p3_cpu_cores.RowCount = 2;
            tlp_p3_cpu_cores.RowStyles.Add(new RowStyle());
            tlp_p3_cpu_cores.RowStyles.Add(new RowStyle());
            tlp_p3_cpu_cores.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_p3_cpu_cores.Size = new Size(442, 77);
            tlp_p3_cpu_cores.TabIndex = 7;
            // 
            // l_p3_coreBoundaryRight
            // 
            l_p3_coreBoundaryRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_p3_coreBoundaryRight.AutoSize = true;
            l_p3_coreBoundaryRight.Location = new Point(272, 55);
            l_p3_coreBoundaryRight.Margin = new Padding(5, 0, 0, 5);
            l_p3_coreBoundaryRight.Name = "l_p3_coreBoundaryRight";
            l_p3_coreBoundaryRight.Size = new Size(60, 17);
            l_p3_coreBoundaryRight.TabIndex = 8;
            l_p3_coreBoundaryRight.Text = "16 Cores";
            l_p3_coreBoundaryRight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // slider_p3_cores
            // 
            slider_p3_cores.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_p3_cpu_cores.SetColumnSpan(slider_p3_cores, 2);
            slider_p3_cores.LargeChange = 1;
            slider_p3_cores.Location = new Point(5, 5);
            slider_p3_cores.Margin = new Padding(5, 5, 10, 0);
            slider_p3_cores.Maximum = 16;
            slider_p3_cores.Minimum = 1;
            slider_p3_cores.Name = "slider_p3_cores";
            slider_p3_cores.Size = new Size(317, 50);
            slider_p3_cores.TabIndex = 6;
            slider_p3_cores.TickStyle = TickStyle.Both;
            slider_p3_cores.Value = 1;
            slider_p3_cores.Scroll += tb_p3_cores_Scroll;
            // 
            // ls_p3_coreBoundaryLeft
            // 
            ls_p3_coreBoundaryLeft.AutoSize = true;
            ls_p3_coreBoundaryLeft.Location = new Point(0, 55);
            ls_p3_coreBoundaryLeft.Margin = new Padding(0, 0, 5, 5);
            ls_p3_coreBoundaryLeft.Name = "ls_p3_coreBoundaryLeft";
            ls_p3_coreBoundaryLeft.Size = new Size(47, 17);
            ls_p3_coreBoundaryLeft.TabIndex = 7;
            ls_p3_coreBoundaryLeft.Text = "1 Core";
            ls_p3_coreBoundaryLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // num_p3_cores
            // 
            num_p3_cores.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            num_p3_cores.Location = new Point(337, 15);
            num_p3_cores.Margin = new Padding(5);
            num_p3_cores.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            num_p3_cores.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_p3_cores.Name = "num_p3_cores";
            num_p3_cores.RightToLeft = RightToLeft.No;
            num_p3_cores.Size = new Size(100, 25);
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
            tlp_p3_ram.Location = new Point(95, 152);
            tlp_p3_ram.Margin = new Padding(5, 10, 5, 10);
            tlp_p3_ram.Name = "tlp_p3_ram";
            tlp_p3_ram.RowCount = 2;
            tlp_p3_ram.RowStyles.Add(new RowStyle());
            tlp_p3_ram.RowStyles.Add(new RowStyle());
            tlp_p3_ram.Size = new Size(442, 77);
            tlp_p3_ram.TabIndex = 8;
            // 
            // l_p3_ramBoundaryRight
            // 
            l_p3_ramBoundaryRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_p3_ramBoundaryRight.AutoSize = true;
            l_p3_ramBoundaryRight.Location = new Point(289, 55);
            l_p3_ramBoundaryRight.Margin = new Padding(5, 0, 0, 5);
            l_p3_ramBoundaryRight.Name = "l_p3_ramBoundaryRight";
            l_p3_ramBoundaryRight.Size = new Size(42, 17);
            l_p3_ramBoundaryRight.TabIndex = 8;
            l_p3_ramBoundaryRight.Text = "16 GB";
            l_p3_ramBoundaryRight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // slider_p3_ram
            // 
            slider_p3_ram.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_p3_ram.SetColumnSpan(slider_p3_ram, 2);
            slider_p3_ram.LargeChange = 2048;
            slider_p3_ram.Location = new Point(5, 5);
            slider_p3_ram.Margin = new Padding(5, 5, 10, 0);
            slider_p3_ram.Maximum = 16384;
            slider_p3_ram.Minimum = 1;
            slider_p3_ram.Name = "slider_p3_ram";
            slider_p3_ram.Size = new Size(316, 50);
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
            ls_p3_ramBoundaryLeft.Location = new Point(0, 55);
            ls_p3_ramBoundaryLeft.Margin = new Padding(0, 0, 5, 5);
            ls_p3_ramBoundaryLeft.Name = "ls_p3_ramBoundaryLeft";
            ls_p3_ramBoundaryLeft.Size = new Size(38, 17);
            ls_p3_ramBoundaryLeft.TabIndex = 7;
            ls_p3_ramBoundaryLeft.Text = "1 MB";
            ls_p3_ramBoundaryLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // num_p3_ram
            // 
            num_p3_ram.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            num_p3_ram.Location = new Point(336, 15);
            num_p3_ram.Margin = new Padding(5);
            num_p3_ram.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            num_p3_ram.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_p3_ram.Name = "num_p3_ram";
            num_p3_ram.RightToLeft = RightToLeft.No;
            num_p3_ram.Size = new Size(101, 25);
            num_p3_ram.TabIndex = 9;
            num_p3_ram.Value = new decimal(new int[] { 1, 0, 0, 0 });
            num_p3_ram.ValueChanged += num_p3_ram_ValueChanged;
            // 
            // ls_p3_cpu_ram
            // 
            ls_p3_cpu_ram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p3_cpu_ram.AutoSize = true;
            ls_p3_cpu_ram.Location = new Point(46, 152);
            ls_p3_cpu_ram.Margin = new Padding(5, 10, 5, 10);
            ls_p3_cpu_ram.Name = "ls_p3_cpu_ram";
            ls_p3_cpu_ram.Size = new Size(39, 77);
            ls_p3_cpu_ram.TabIndex = 9;
            ls_p3_cpu_ram.Text = "RAM:";
            ls_p3_cpu_ram.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tp_p3_main_graphics
            // 
            tp_p3_main_graphics.BorderStyle = BorderStyle.FixedSingle;
            tp_p3_main_graphics.Controls.Add(tlp_p3_graphics);
            tp_p3_main_graphics.Location = new Point(4, 26);
            tp_p3_main_graphics.Name = "tp_p3_main_graphics";
            tp_p3_main_graphics.Padding = new Padding(3);
            tp_p3_main_graphics.Size = new Size(555, 306);
            tp_p3_main_graphics.TabIndex = 3;
            tp_p3_main_graphics.Text = "Graphics/Audio";
            tp_p3_main_graphics.UseVisualStyleBackColor = true;
            // 
            // tlp_p3_graphics
            // 
            tlp_p3_graphics.ColumnCount = 2;
            tlp_p3_graphics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tlp_p3_graphics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84F));
            tlp_p3_graphics.Dock = DockStyle.Fill;
            tlp_p3_graphics.Location = new Point(3, 3);
            tlp_p3_graphics.Margin = new Padding(5);
            tlp_p3_graphics.Name = "tlp_p3_graphics";
            tlp_p3_graphics.Padding = new Padding(5, 10, 5, 5);
            tlp_p3_graphics.RowCount = 4;
            tlp_p3_graphics.RowStyles.Add(new RowStyle(SizeType.Percent, 26.3077488F));
            tlp_p3_graphics.RowStyles.Add(new RowStyle(SizeType.Percent, 26.3077488F));
            tlp_p3_graphics.RowStyles.Add(new RowStyle(SizeType.Percent, 26.3077488F));
            tlp_p3_graphics.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0767574F));
            tlp_p3_graphics.Size = new Size(547, 298);
            tlp_p3_graphics.TabIndex = 1;
            // 
            // tp_p3_main_accel
            // 
            tp_p3_main_accel.Location = new Point(4, 26);
            tp_p3_main_accel.Name = "tp_p3_main_accel";
            tp_p3_main_accel.Padding = new Padding(3);
            tp_p3_main_accel.Size = new Size(555, 306);
            tp_p3_main_accel.TabIndex = 4;
            tp_p3_main_accel.Text = "Acceleration";
            tp_p3_main_accel.UseVisualStyleBackColor = true;
            // 
            // p1
            // 
            p1.Controls.Add(sc_p1_main);
            p1.Dock = DockStyle.Fill;
            p1.Location = new Point(10, 10);
            p1.Name = "p1";
            p1.Size = new Size(573, 414);
            p1.TabIndex = 3;
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
            sc_p1_main.Panel2.Padding = new Padding(5);
            sc_p1_main.Size = new Size(573, 414);
            sc_p1_main.SplitterDistance = 63;
            sc_p1_main.SplitterWidth = 5;
            sc_p1_main.TabIndex = 2;
            // 
            // ls_p1_info
            // 
            ls_p1_info.Dock = DockStyle.Fill;
            ls_p1_info.Location = new Point(0, 0);
            ls_p1_info.Margin = new Padding(0);
            ls_p1_info.Name = "ls_p1_info";
            ls_p1_info.Padding = new Padding(5);
            ls_p1_info.Size = new Size(573, 63);
            ls_p1_info.TabIndex = 1;
            ls_p1_info.Text = "Here is where you will choose the Operating System of the VM.";
            ls_p1_info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gb_p1_os
            // 
            gb_p1_os.AutoSize = true;
            gb_p1_os.Controls.Add(tlp_p1_os);
            gb_p1_os.Dock = DockStyle.Top;
            gb_p1_os.Location = new Point(5, 5);
            gb_p1_os.Margin = new Padding(5);
            gb_p1_os.Name = "gb_p1_os";
            gb_p1_os.Padding = new Padding(5);
            gb_p1_os.Size = new Size(563, 219);
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
            tlp_p1_os.Controls.Add(ls_p0_osName, 0, 0);
            tlp_p1_os.Controls.Add(cb_p1_subversion, 1, 2);
            tlp_p1_os.Controls.Add(cb_p1_version, 1, 1);
            tlp_p1_os.Controls.Add(flp_p1_bitness, 1, 3);
            tlp_p1_os.Dock = DockStyle.Fill;
            tlp_p1_os.Location = new Point(5, 23);
            tlp_p1_os.Name = "tlp_p1_os";
            tlp_p1_os.RowCount = 5;
            tlp_p1_os.RowStyles.Add(new RowStyle());
            tlp_p1_os.RowStyles.Add(new RowStyle());
            tlp_p1_os.RowStyles.Add(new RowStyle());
            tlp_p1_os.RowStyles.Add(new RowStyle());
            tlp_p1_os.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_p1_os.Size = new Size(553, 191);
            tlp_p1_os.TabIndex = 1;
            // 
            // l_p1_bitness
            // 
            l_p1_bitness.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            l_p1_bitness.AutoSize = true;
            l_p1_bitness.Location = new Point(65, 151);
            l_p1_bitness.Margin = new Padding(5);
            l_p1_bitness.Name = "l_p1_bitness";
            l_p1_bitness.Size = new Size(51, 35);
            l_p1_bitness.TabIndex = 9;
            l_p1_bitness.Text = "Bitness:";
            l_p1_bitness.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_p1_subversion
            // 
            l_p1_subversion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            l_p1_subversion.AutoSize = true;
            l_p1_subversion.Location = new Point(35, 116);
            l_p1_subversion.Margin = new Padding(5);
            l_p1_subversion.Name = "l_p1_subversion";
            l_p1_subversion.Size = new Size(81, 25);
            l_p1_subversion.TabIndex = 6;
            l_p1_subversion.Text = "Sub-Version:";
            l_p1_subversion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_p1_version
            // 
            ls_p1_version.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p1_version.AutoSize = true;
            ls_p1_version.Location = new Point(62, 81);
            ls_p1_version.Margin = new Padding(5);
            ls_p1_version.Name = "ls_p1_version";
            ls_p1_version.Size = new Size(54, 25);
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
            flp_p1_osType.Padding = new Padding(5);
            flp_p1_osType.Size = new Size(426, 70);
            flp_p1_osType.TabIndex = 3;
            // 
            // rb_p1_os_win
            // 
            rb_p1_os_win.AutoSize = true;
            rb_p1_os_win.Checked = true;
            rb_p1_os_win.Location = new Point(8, 8);
            rb_p1_os_win.Margin = new Padding(3, 3, 50, 3);
            rb_p1_os_win.Name = "rb_p1_os_win";
            rb_p1_os_win.Size = new Size(79, 21);
            rb_p1_os_win.TabIndex = 6;
            rb_p1_os_win.TabStop = true;
            rb_p1_os_win.Text = "Windows";
            rb_p1_os_win.UseVisualStyleBackColor = true;
            rb_p1_os_win.CheckedChanged += loadOSVersions;
            // 
            // rb_p1_os_mac
            // 
            rb_p1_os_mac.AutoSize = true;
            rb_p1_os_mac.Location = new Point(140, 8);
            rb_p1_os_mac.Margin = new Padding(3, 3, 50, 3);
            rb_p1_os_mac.Name = "rb_p1_os_mac";
            rb_p1_os_mac.Size = new Size(68, 21);
            rb_p1_os_mac.TabIndex = 7;
            rb_p1_os_mac.TabStop = true;
            rb_p1_os_mac.Text = "MacOS";
            rb_p1_os_mac.UseVisualStyleBackColor = true;
            rb_p1_os_mac.CheckedChanged += loadOSVersions;
            // 
            // rb_p1_os_linux
            // 
            rb_p1_os_linux.AutoSize = true;
            rb_p1_os_linux.Location = new Point(261, 8);
            rb_p1_os_linux.Name = "rb_p1_os_linux";
            rb_p1_os_linux.Size = new Size(55, 21);
            rb_p1_os_linux.TabIndex = 8;
            rb_p1_os_linux.TabStop = true;
            rb_p1_os_linux.Text = "Linux";
            rb_p1_os_linux.UseVisualStyleBackColor = true;
            rb_p1_os_linux.CheckedChanged += loadOSVersions;
            // 
            // flp_p1_otherOS
            // 
            flp_p1_otherOS.AutoSize = true;
            flp_p1_otherOS.Controls.Add(rb_p1_os_other);
            flp_p1_otherOS.Controls.Add(cb_p1_otherOS);
            flp_p1_otherOS.Dock = DockStyle.Fill;
            flp_p1_otherOS.Location = new Point(8, 32);
            flp_p1_otherOS.Margin = new Padding(3, 0, 0, 0);
            flp_p1_otherOS.Name = "flp_p1_otherOS";
            flp_p1_otherOS.Size = new Size(358, 31);
            flp_p1_otherOS.TabIndex = 2;
            flp_p1_otherOS.Visible = false;
            // 
            // rb_p1_os_other
            // 
            rb_p1_os_other.AutoSize = true;
            rb_p1_os_other.Location = new Point(0, 5);
            rb_p1_os_other.Margin = new Padding(0, 5, 3, 3);
            rb_p1_os_other.Name = "rb_p1_os_other";
            rb_p1_os_other.Size = new Size(66, 21);
            rb_p1_os_other.TabIndex = 1;
            rb_p1_os_other.Text = "Other: ";
            rb_p1_os_other.UseVisualStyleBackColor = true;
            rb_p1_os_other.CheckedChanged += loadOSVersions;
            // 
            // cb_p1_otherOS
            // 
            cb_p1_otherOS.FormattingEnabled = true;
            cb_p1_otherOS.Items.AddRange(new object[] { "window", "bsd", "uhhh hi everyone" });
            cb_p1_otherOS.Location = new Point(72, 3);
            cb_p1_otherOS.Name = "cb_p1_otherOS";
            cb_p1_otherOS.Size = new Size(283, 25);
            cb_p1_otherOS.TabIndex = 1;
            // 
            // ls_p0_osName
            // 
            ls_p0_osName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p0_osName.AutoSize = true;
            ls_p0_osName.Location = new Point(49, 5);
            ls_p0_osName.Margin = new Padding(5);
            ls_p0_osName.Name = "ls_p0_osName";
            ls_p0_osName.Size = new Size(67, 66);
            ls_p0_osName.TabIndex = 4;
            ls_p0_osName.Text = "Operating System:";
            ls_p0_osName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cb_p1_subversion
            // 
            cb_p1_subversion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_p1_subversion.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p1_subversion.Enabled = false;
            cb_p1_subversion.FormattingEnabled = true;
            cb_p1_subversion.Location = new Point(126, 116);
            cb_p1_subversion.Margin = new Padding(5);
            cb_p1_subversion.Name = "cb_p1_subversion";
            cb_p1_subversion.Size = new Size(422, 25);
            cb_p1_subversion.TabIndex = 7;
            // 
            // cb_p1_version
            // 
            cb_p1_version.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_p1_version.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p1_version.FormattingEnabled = true;
            cb_p1_version.Items.AddRange(new object[] { "" });
            cb_p1_version.Location = new Point(126, 81);
            cb_p1_version.Margin = new Padding(5);
            cb_p1_version.Name = "cb_p1_version";
            cb_p1_version.Size = new Size(422, 25);
            cb_p1_version.TabIndex = 8;
            cb_p1_version.SelectedIndexChanged += loadOSMinorVersions;
            // 
            // flp_p1_bitness
            // 
            flp_p1_bitness.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flp_p1_bitness.AutoSize = true;
            flp_p1_bitness.BorderStyle = BorderStyle.FixedSingle;
            flp_p1_bitness.Controls.Add(rb_p1_bitness_32);
            flp_p1_bitness.Controls.Add(rb_p1_bitness_64);
            flp_p1_bitness.Location = new Point(124, 149);
            flp_p1_bitness.Name = "flp_p1_bitness";
            flp_p1_bitness.Padding = new Padding(5);
            flp_p1_bitness.Size = new Size(426, 39);
            flp_p1_bitness.TabIndex = 10;
            // 
            // rb_p1_bitness_32
            // 
            rb_p1_bitness_32.AutoSize = true;
            rb_p1_bitness_32.Location = new Point(8, 8);
            rb_p1_bitness_32.Margin = new Padding(3, 3, 50, 3);
            rb_p1_bitness_32.Name = "rb_p1_bitness_32";
            rb_p1_bitness_32.Size = new Size(90, 21);
            rb_p1_bitness_32.TabIndex = 0;
            rb_p1_bitness_32.Text = "32 Bit (x86)";
            rb_p1_bitness_32.UseVisualStyleBackColor = true;
            // 
            // rb_p1_bitness_64
            // 
            rb_p1_bitness_64.AutoSize = true;
            rb_p1_bitness_64.Checked = true;
            rb_p1_bitness_64.Location = new Point(151, 8);
            rb_p1_bitness_64.Name = "rb_p1_bitness_64";
            rb_p1_bitness_64.Size = new Size(90, 21);
            rb_p1_bitness_64.TabIndex = 1;
            rb_p1_bitness_64.TabStop = true;
            rb_p1_bitness_64.Text = "64 Bit (x64)";
            rb_p1_bitness_64.UseVisualStyleBackColor = true;
            // 
            // p0
            // 
            p0.Controls.Add(sc_p0_main);
            p0.Dock = DockStyle.Fill;
            p0.Location = new Point(10, 10);
            p0.Name = "p0";
            p0.Size = new Size(573, 414);
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
            sc_p0_main.Panel1.Padding = new Padding(5);
            // 
            // sc_p0_main.Panel2
            // 
            sc_p0_main.Panel2.Controls.Add(ls_p0_placeholder);
            sc_p0_main.Panel2.Controls.Add(gb_p0_basic);
            sc_p0_main.Panel2.Padding = new Padding(5);
            sc_p0_main.Size = new Size(573, 414);
            sc_p0_main.SplitterDistance = 63;
            sc_p0_main.SplitterWidth = 5;
            sc_p0_main.TabIndex = 0;
            // 
            // ls_p0_info
            // 
            ls_p0_info.Dock = DockStyle.Fill;
            ls_p0_info.Location = new Point(5, 5);
            ls_p0_info.Margin = new Padding(0);
            ls_p0_info.Name = "ls_p0_info";
            ls_p0_info.Padding = new Padding(5);
            ls_p0_info.Size = new Size(563, 53);
            ls_p0_info.TabIndex = 0;
            ls_p0_info.Text = "Here is where you will choose the type and name of your VM.";
            ls_p0_info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ls_p0_placeholder
            // 
            ls_p0_placeholder.AutoSize = true;
            ls_p0_placeholder.Dock = DockStyle.Top;
            ls_p0_placeholder.Font = new Font("Segoe UI", 4F);
            ls_p0_placeholder.Location = new Point(5, 171);
            ls_p0_placeholder.Name = "ls_p0_placeholder";
            ls_p0_placeholder.Size = new Size(0, 8);
            ls_p0_placeholder.TabIndex = 2;
            // 
            // gb_p0_basic
            // 
            gb_p0_basic.AutoSize = true;
            gb_p0_basic.Controls.Add(tlp_p0_basic);
            gb_p0_basic.Dock = DockStyle.Top;
            gb_p0_basic.Location = new Point(5, 5);
            gb_p0_basic.Margin = new Padding(5);
            gb_p0_basic.Name = "gb_p0_basic";
            gb_p0_basic.Padding = new Padding(5);
            gb_p0_basic.RightToLeft = RightToLeft.No;
            gb_p0_basic.Size = new Size(563, 166);
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
            tlp_p0_basic.Location = new Point(5, 23);
            tlp_p0_basic.Name = "tlp_p0_basic";
            tlp_p0_basic.RowCount = 2;
            tlp_p0_basic.RowStyles.Add(new RowStyle());
            tlp_p0_basic.RowStyles.Add(new RowStyle());
            tlp_p0_basic.Size = new Size(553, 138);
            tlp_p0_basic.TabIndex = 0;
            // 
            // ls_p0_emulator
            // 
            ls_p0_emulator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p0_emulator.AutoSize = true;
            ls_p0_emulator.Location = new Point(53, 40);
            ls_p0_emulator.Margin = new Padding(5);
            ls_p0_emulator.Name = "ls_p0_emulator";
            ls_p0_emulator.Size = new Size(63, 93);
            ls_p0_emulator.TabIndex = 2;
            ls_p0_emulator.Text = "Emulator:";
            ls_p0_emulator.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_p0_name
            // 
            ls_p0_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p0_name.AutoSize = true;
            ls_p0_name.Location = new Point(70, 5);
            ls_p0_name.Margin = new Padding(5);
            ls_p0_name.Name = "ls_p0_name";
            ls_p0_name.Size = new Size(46, 25);
            ls_p0_name.TabIndex = 0;
            ls_p0_name.Text = "Name:";
            ls_p0_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // t_p0_name
            // 
            t_p0_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            t_p0_name.Location = new Point(126, 5);
            t_p0_name.Margin = new Padding(5);
            t_p0_name.Name = "t_p0_name";
            t_p0_name.Size = new Size(422, 25);
            t_p0_name.TabIndex = 1;
            t_p0_name.Text = "Meee and my debug";
            t_p0_name.TextChanged += checkNextButtonEnabled;
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
            flp_p0_emType.Location = new Point(124, 38);
            flp_p0_emType.Name = "flp_p0_emType";
            flp_p0_emType.Padding = new Padding(5);
            flp_p0_emType.Size = new Size(426, 97);
            flp_p0_emType.TabIndex = 3;
            // 
            // rb_p0_emType_x86
            // 
            rb_p0_emType_x86.AutoSize = true;
            rb_p0_emType_x86.Checked = true;
            rb_p0_emType_x86.Location = new Point(8, 8);
            rb_p0_emType_x86.Margin = new Padding(3, 3, 50, 3);
            rb_p0_emType_x86.Name = "rb_p0_emType_x86";
            rb_p0_emType_x86.Size = new Size(107, 21);
            rb_p0_emType_x86.TabIndex = 0;
            rb_p0_emType_x86.TabStop = true;
            rb_p0_emType_x86.Text = "QEMU x86-64";
            rb_p0_emType_x86.UseVisualStyleBackColor = true;
            rb_p0_emType_x86.CheckedChanged += rb_p0_emType_x86_CheckedChanged;
            // 
            // rb_p0_emType_i386
            // 
            rb_p0_emType_i386.AutoSize = true;
            rb_p0_emType_i386.Location = new Point(168, 8);
            rb_p0_emType_i386.Margin = new Padding(3, 3, 100, 3);
            rb_p0_emType_i386.Name = "rb_p0_emType_i386";
            rb_p0_emType_i386.Size = new Size(92, 21);
            rb_p0_emType_i386.TabIndex = 3;
            rb_p0_emType_i386.Text = "QEMU i386";
            rb_p0_emType_i386.UseVisualStyleBackColor = true;
            rb_p0_emType_i386.CheckedChanged += rb_p0_emType_i386_CheckedChanged;
            // 
            // rb_p0_emType_PPC
            // 
            rb_p0_emType_PPC.AutoSize = true;
            rb_p0_emType_PPC.Location = new Point(8, 35);
            rb_p0_emType_PPC.Margin = new Padding(3, 3, 37, 3);
            rb_p0_emType_PPC.Name = "rb_p0_emType_PPC";
            rb_p0_emType_PPC.Size = new Size(119, 21);
            rb_p0_emType_PPC.TabIndex = 1;
            rb_p0_emType_PPC.Text = "QEMU PowerPC";
            rb_p0_emType_PPC.UseVisualStyleBackColor = true;
            rb_p0_emType_PPC.CheckedChanged += rb_p0_emType_PPC_CheckedChanged;
            // 
            // rb_p0_emType_m68k
            // 
            rb_p0_emType_m68k.AutoSize = true;
            rb_p0_emType_m68k.Location = new Point(167, 35);
            rb_p0_emType_m68k.Margin = new Padding(3, 3, 50, 3);
            rb_p0_emType_m68k.Name = "rb_p0_emType_m68k";
            rb_p0_emType_m68k.Size = new Size(102, 21);
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
            flp_p0_otherEm.Location = new Point(8, 59);
            flp_p0_otherEm.Margin = new Padding(3, 0, 0, 0);
            flp_p0_otherEm.Name = "flp_p0_otherEm";
            flp_p0_otherEm.Size = new Size(351, 31);
            flp_p0_otherEm.TabIndex = 2;
            flp_p0_otherEm.Visible = false;
            // 
            // rb_p0_emType_other
            // 
            rb_p0_emType_other.AutoSize = true;
            rb_p0_emType_other.Location = new Point(0, 5);
            rb_p0_emType_other.Margin = new Padding(0, 5, 3, 3);
            rb_p0_emType_other.Name = "rb_p0_emType_other";
            rb_p0_emType_other.Size = new Size(66, 21);
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
            cb_p0_otherEm.Location = new Point(72, 3);
            cb_p0_otherEm.Name = "cb_p0_otherEm";
            cb_p0_otherEm.Size = new Size(276, 25);
            cb_p0_otherEm.TabIndex = 1;
            cb_p0_otherEm.SelectedIndexChanged += cb_p0_otherEm_SelectedIndexChanged;
            // 
            // p2_pcType
            // 
            p2_pcType.Controls.Add(sc_p2_main);
            p2_pcType.Dock = DockStyle.Fill;
            p2_pcType.Location = new Point(10, 10);
            p2_pcType.Margin = new Padding(0);
            p2_pcType.Name = "p2_pcType";
            p2_pcType.Size = new Size(573, 414);
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
            // 
            // sc_p2_main.Panel2
            // 
            sc_p2_main.Panel2.Controls.Add(gb_p1_hardware);
            sc_p2_main.Panel2.Padding = new Padding(5);
            sc_p2_main.Size = new Size(573, 414);
            sc_p2_main.SplitterDistance = 63;
            sc_p2_main.SplitterWidth = 5;
            sc_p2_main.TabIndex = 0;
            // 
            // ls_p2_info
            // 
            ls_p2_info.Dock = DockStyle.Fill;
            ls_p2_info.Location = new Point(0, 0);
            ls_p2_info.Margin = new Padding(0);
            ls_p2_info.Name = "ls_p2_info";
            ls_p2_info.Padding = new Padding(5);
            ls_p2_info.Size = new Size(573, 63);
            ls_p2_info.TabIndex = 1;
            ls_p2_info.Text = "Here is where you will choose the hardware for your VM.";
            ls_p2_info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gb_p1_hardware
            // 
            gb_p1_hardware.Controls.Add(tableLayoutPanel1);
            gb_p1_hardware.Dock = DockStyle.Fill;
            gb_p1_hardware.Location = new Point(5, 5);
            gb_p1_hardware.Name = "gb_p1_hardware";
            gb_p1_hardware.Size = new Size(563, 336);
            gb_p1_hardware.TabIndex = 0;
            gb_p1_hardware.TabStop = false;
            gb_p1_hardware.Text = "Hardware";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.84546F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lv_p2_type, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8054714F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.19453F));
            tableLayoutPanel1.Size = new Size(557, 312);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(5, 16);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(547, 17);
            label1.TabIndex = 3;
            label1.Text = "Choose a PC type:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lv_p2_type
            // 
            lv_p2_type.Columns.AddRange(new ColumnHeader[] { lv_p2_type_machine, lv_p2_type_desc });
            lv_p2_type.FullRowSelect = true;
            lv_p2_type.GridLines = true;
            lv_p2_type.Location = new Point(5, 54);
            lv_p2_type.Margin = new Padding(5);
            lv_p2_type.MultiSelect = false;
            lv_p2_type.Name = "lv_p2_type";
            lv_p2_type.ShowGroups = false;
            lv_p2_type.Size = new Size(533, 249);
            lv_p2_type.TabIndex = 4;
            lv_p2_type.TileSize = new Size(30, 30);
            lv_p2_type.UseCompatibleStateImageBehavior = false;
            lv_p2_type.View = View.Details;
            lv_p2_type.SelectedIndexChanged += checkNextButtonEnabled;
            // 
            // lv_p2_type_machine
            // 
            lv_p2_type_machine.Text = "Machine";
            lv_p2_type_machine.Width = 100;
            // 
            // lv_p2_type_desc
            // 
            lv_p2_type_desc.Text = "Description";
            lv_p2_type_desc.Width = 429;
            // 
            // WIN_NewMachine
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(593, 483);
            Controls.Add(p_main);
            Controls.Add(fpl_bottom);
            MinimumSize = new Size(595, 522);
            Name = "WIN_NewMachine";
            Text = "QEMU Interface - New Machine";
            FormClosing += WIN_NewMachine_FormClosing;
            fpl_bottom.ResumeLayout(false);
            p_main.ResumeLayout(false);
            pfin.ResumeLayout(false);
            sc_pfin_main.Panel1.ResumeLayout(false);
            sc_pfin_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_pfin_main).EndInit();
            sc_pfin_main.ResumeLayout(false);
            tlp_pfin_main.ResumeLayout(false);
            tlp_pfin_main.PerformLayout();
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
            p1.ResumeLayout(false);
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
            p2_pcType.ResumeLayout(false);
            sc_p2_main.Panel1.ResumeLayout(false);
            sc_p2_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_p2_main).EndInit();
            sc_p2_main.ResumeLayout(false);
            gb_p1_hardware.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Panel p1;
        private Label ls_p1_info;
        private RadioButton rb_p1_os_mac;
        private RadioButton rb_p1_os_linux;
        private ComboBox cb_p1_subversion;
        private ComboBox cb_p1_version;
        private RadioButton rb_p1_bitness_32;
        private RadioButton rb_p1_bitness_64;
        private GroupBox gb_p1_hardware;
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
        private TableLayoutPanel tlp_p3_graphics;
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
    }
}