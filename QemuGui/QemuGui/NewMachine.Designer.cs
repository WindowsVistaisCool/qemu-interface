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
            Label ls_p0_placeholder;
            GroupBox gb_p0_basic;
            Label ls_p0_emulator;
            Label ls_p0_name;
            FlowLayoutPanel flp_p0_emType;
            SplitContainer sc_p1_main;
            GroupBox gb_p1_os;
            Label ls_p1_bitness;
            Label ls_p1_subversion;
            Label ls_p1_version;
            FlowLayoutPanel flp_p1_osType;
            Label ls_p0_osName;
            FlowLayoutPanel flp_p1_bitness;
            Panel panel2;
            Panel panel1;
            b_cancel = new Button();
            b_next = new Button();
            b_back = new Button();
            b_expert = new Button();
            p0 = new Panel();
            ls_p0info = new Label();
            tlp_p0_basic = new TableLayoutPanel();
            t_p0_name = new TextBox();
            rb_p0_emType_x86 = new RadioButton();
            rb_p0_emType_PPC = new RadioButton();
            flp_p0_otherEm = new FlowLayoutPanel();
            rb_p0_emType_other = new RadioButton();
            cb_p0_otherEm = new ComboBox();
            p1 = new Panel();
            ls_p1info = new Label();
            tlp_p1_os = new TableLayoutPanel();
            rb_p1_os_win = new RadioButton();
            rb_p1_os_mac = new RadioButton();
            rb_p1_os_linux = new RadioButton();
            flp_p1_otherOS = new FlowLayoutPanel();
            rb_p1_os_other = new RadioButton();
            cb_p1_otherOS = new ComboBox();
            cb_p1_subversion = new ComboBox();
            cb_p1_version = new ComboBox();
            rb_p1_bitness_32 = new RadioButton();
            rb_p1_bitness_64 = new RadioButton();
            p_diskPage = new Panel();
            p_finishPage = new Panel();
            fpl_bottom = new FlowLayoutPanel();
            p_main = new Panel();
            sc_p0_main = new SplitContainer();
            ls_p0_placeholder = new Label();
            gb_p0_basic = new GroupBox();
            ls_p0_emulator = new Label();
            ls_p0_name = new Label();
            flp_p0_emType = new FlowLayoutPanel();
            sc_p1_main = new SplitContainer();
            gb_p1_os = new GroupBox();
            ls_p1_bitness = new Label();
            ls_p1_subversion = new Label();
            ls_p1_version = new Label();
            flp_p1_osType = new FlowLayoutPanel();
            ls_p0_osName = new Label();
            flp_p1_bitness = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1 = new Panel();
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
            p_diskPage.SuspendLayout();
            p_finishPage.SuspendLayout();
            SuspendLayout();
            // 
            // fpl_bottom
            // 
            fpl_bottom.AutoSize = true;
            fpl_bottom.BackColor = SystemColors.ControlLight;
            fpl_bottom.Controls.Add(b_cancel);
            fpl_bottom.Controls.Add(b_next);
            fpl_bottom.Controls.Add(b_back);
            fpl_bottom.Controls.Add(b_expert);
            fpl_bottom.Dock = DockStyle.Bottom;
            fpl_bottom.FlowDirection = FlowDirection.RightToLeft;
            fpl_bottom.Location = new Point(0, 434);
            fpl_bottom.Name = "fpl_bottom";
            fpl_bottom.Size = new Size(523, 49);
            fpl_bottom.TabIndex = 2;
            // 
            // b_cancel
            // 
            b_cancel.Location = new Point(427, 10);
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
            b_next.Location = new Point(321, 10);
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
            b_back.Location = new Point(228, 10);
            b_back.Margin = new Padding(5, 10, 5, 10);
            b_back.Name = "b_back";
            b_back.Size = new Size(83, 29);
            b_back.TabIndex = 2;
            b_back.Text = "< Back";
            b_back.UseVisualStyleBackColor = true;
            b_back.Click += b_back_Click;
            // 
            // b_expert
            // 
            b_expert.Enabled = false;
            b_expert.Location = new Point(20, 10);
            b_expert.Margin = new Padding(5, 10, 100, 5);
            b_expert.Name = "b_expert";
            b_expert.Size = new Size(103, 29);
            b_expert.TabIndex = 3;
            b_expert.Text = "Expert Mode";
            b_expert.UseVisualStyleBackColor = true;
            // 
            // p_main
            // 
            p_main.BackColor = SystemColors.Control;
            p_main.Controls.Add(p0);
            p_main.Controls.Add(p1);
            p_main.Controls.Add(p_diskPage);
            p_main.Controls.Add(p_finishPage);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Margin = new Padding(0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(10);
            p_main.Size = new Size(523, 434);
            p_main.TabIndex = 3;
            // 
            // p0
            // 
            p0.Controls.Add(sc_p0_main);
            p0.Dock = DockStyle.Fill;
            p0.Location = new Point(10, 10);
            p0.Name = "p0";
            p0.Size = new Size(503, 414);
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
            sc_p0_main.Panel1.Controls.Add(ls_p0info);
            sc_p0_main.Panel1.Padding = new Padding(5);
            // 
            // sc_p0_main.Panel2
            // 
            sc_p0_main.Panel2.Controls.Add(ls_p0_placeholder);
            sc_p0_main.Panel2.Controls.Add(gb_p0_basic);
            sc_p0_main.Panel2.Padding = new Padding(5);
            sc_p0_main.Size = new Size(503, 414);
            sc_p0_main.SplitterDistance = 57;
            sc_p0_main.TabIndex = 0;
            // 
            // ls_p0info
            // 
            ls_p0info.Dock = DockStyle.Fill;
            ls_p0info.Location = new Point(5, 5);
            ls_p0info.Margin = new Padding(0);
            ls_p0info.Name = "ls_p0info";
            ls_p0info.Padding = new Padding(5);
            ls_p0info.Size = new Size(493, 47);
            ls_p0info.TabIndex = 0;
            ls_p0info.Text = "Here is where you will choose the type and name of your VM.";
            ls_p0info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ls_p0_placeholder
            // 
            ls_p0_placeholder.AutoSize = true;
            ls_p0_placeholder.Dock = DockStyle.Top;
            ls_p0_placeholder.Font = new Font("Segoe UI", 4F);
            ls_p0_placeholder.Location = new Point(5, 139);
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
            gb_p0_basic.Size = new Size(493, 134);
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
            tlp_p0_basic.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_p0_basic.Size = new Size(483, 106);
            tlp_p0_basic.TabIndex = 0;
            // 
            // ls_p0_emulator
            // 
            ls_p0_emulator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p0_emulator.AutoSize = true;
            ls_p0_emulator.Location = new Point(38, 40);
            ls_p0_emulator.Margin = new Padding(5);
            ls_p0_emulator.Name = "ls_p0_emulator";
            ls_p0_emulator.Size = new Size(63, 61);
            ls_p0_emulator.TabIndex = 2;
            ls_p0_emulator.Text = "Emulator:";
            ls_p0_emulator.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_p0_name
            // 
            ls_p0_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p0_name.AutoSize = true;
            ls_p0_name.Location = new Point(55, 5);
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
            t_p0_name.Location = new Point(111, 5);
            t_p0_name.Margin = new Padding(5);
            t_p0_name.Name = "t_p0_name";
            t_p0_name.Size = new Size(367, 25);
            t_p0_name.TabIndex = 1;
            t_p0_name.Text = "debug my beloved";
            t_p0_name.TextChanged += checkNextButtonEnabled;
            // 
            // flp_p0_emType
            // 
            flp_p0_emType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flp_p0_emType.AutoSize = true;
            flp_p0_emType.BorderStyle = BorderStyle.FixedSingle;
            flp_p0_emType.Controls.Add(rb_p0_emType_x86);
            flp_p0_emType.Controls.Add(rb_p0_emType_PPC);
            flp_p0_emType.Controls.Add(flp_p0_otherEm);
            flp_p0_emType.Location = new Point(109, 38);
            flp_p0_emType.Name = "flp_p0_emType";
            flp_p0_emType.Padding = new Padding(5, 5, 5, 0);
            flp_p0_emType.Size = new Size(371, 65);
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
            // rb_p0_emType_PPC
            // 
            rb_p0_emType_PPC.AutoSize = true;
            rb_p0_emType_PPC.Location = new Point(168, 8);
            rb_p0_emType_PPC.Name = "rb_p0_emType_PPC";
            rb_p0_emType_PPC.Size = new Size(119, 21);
            rb_p0_emType_PPC.TabIndex = 1;
            rb_p0_emType_PPC.Text = "QEMU PowerPC";
            rb_p0_emType_PPC.UseVisualStyleBackColor = true;
            rb_p0_emType_PPC.CheckedChanged += rb_p0_emType_PPC_CheckedChanged;
            // 
            // flp_p0_otherEm
            // 
            flp_p0_otherEm.AutoSize = true;
            flp_p0_otherEm.Controls.Add(rb_p0_emType_other);
            flp_p0_otherEm.Controls.Add(cb_p0_otherEm);
            flp_p0_otherEm.Dock = DockStyle.Fill;
            flp_p0_otherEm.Enabled = false;
            flp_p0_otherEm.Location = new Point(8, 32);
            flp_p0_otherEm.Margin = new Padding(3, 0, 0, 0);
            flp_p0_otherEm.Name = "flp_p0_otherEm";
            flp_p0_otherEm.Size = new Size(351, 31);
            flp_p0_otherEm.TabIndex = 2;
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
            // p1
            // 
            p1.Controls.Add(sc_p1_main);
            p1.Dock = DockStyle.Fill;
            p1.Location = new Point(10, 10);
            p1.Margin = new Padding(0);
            p1.Name = "p1";
            p1.Size = new Size(503, 414);
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
            sc_p1_main.Panel1.Controls.Add(ls_p1info);
            // 
            // sc_p1_main.Panel2
            // 
            sc_p1_main.Panel2.Controls.Add(gb_p1_os);
            sc_p1_main.Size = new Size(503, 414);
            sc_p1_main.SplitterDistance = 57;
            sc_p1_main.TabIndex = 2;
            // 
            // ls_p1info
            // 
            ls_p1info.Dock = DockStyle.Fill;
            ls_p1info.Location = new Point(0, 0);
            ls_p1info.Margin = new Padding(0);
            ls_p1info.Name = "ls_p1info";
            ls_p1info.Padding = new Padding(5);
            ls_p1info.Size = new Size(503, 57);
            ls_p1info.TabIndex = 1;
            ls_p1info.Text = "Here is where you will choose the Operating System and Hardware of the VM.";
            ls_p1info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gb_p1_os
            // 
            gb_p1_os.AutoSize = true;
            gb_p1_os.Controls.Add(tlp_p1_os);
            gb_p1_os.Dock = DockStyle.Top;
            gb_p1_os.Location = new Point(0, 0);
            gb_p1_os.Margin = new Padding(5);
            gb_p1_os.Name = "gb_p1_os";
            gb_p1_os.Padding = new Padding(5);
            gb_p1_os.Size = new Size(503, 206);
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
            tlp_p1_os.Controls.Add(ls_p1_bitness, 0, 3);
            tlp_p1_os.Controls.Add(ls_p1_subversion, 0, 2);
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
            tlp_p1_os.Size = new Size(493, 178);
            tlp_p1_os.TabIndex = 1;
            // 
            // ls_p1_bitness
            // 
            ls_p1_bitness.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p1_bitness.AutoSize = true;
            ls_p1_bitness.Location = new Point(52, 146);
            ls_p1_bitness.Margin = new Padding(5);
            ls_p1_bitness.Name = "ls_p1_bitness";
            ls_p1_bitness.Size = new Size(51, 27);
            ls_p1_bitness.TabIndex = 9;
            ls_p1_bitness.Text = "Bitness:";
            ls_p1_bitness.TextAlign = ContentAlignment.MiddleRight;
            ls_p1_bitness.Visible = false;
            // 
            // ls_p1_subversion
            // 
            ls_p1_subversion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p1_subversion.AutoSize = true;
            ls_p1_subversion.Location = new Point(22, 111);
            ls_p1_subversion.Margin = new Padding(5);
            ls_p1_subversion.Name = "ls_p1_subversion";
            ls_p1_subversion.Size = new Size(81, 25);
            ls_p1_subversion.TabIndex = 6;
            ls_p1_subversion.Text = "Sub-Version:";
            ls_p1_subversion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ls_p1_version
            // 
            ls_p1_version.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ls_p1_version.AutoSize = true;
            ls_p1_version.Location = new Point(49, 76);
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
            flp_p1_osType.Location = new Point(111, 3);
            flp_p1_osType.Name = "flp_p1_osType";
            flp_p1_osType.Padding = new Padding(5, 5, 5, 0);
            flp_p1_osType.Size = new Size(379, 65);
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
            flp_p1_otherOS.Enabled = false;
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
            ls_p0_osName.Location = new Point(36, 5);
            ls_p0_osName.Margin = new Padding(5);
            ls_p0_osName.Name = "ls_p0_osName";
            ls_p0_osName.Size = new Size(67, 61);
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
            cb_p1_subversion.Location = new Point(113, 111);
            cb_p1_subversion.Margin = new Padding(5);
            cb_p1_subversion.Name = "cb_p1_subversion";
            cb_p1_subversion.Size = new Size(375, 25);
            cb_p1_subversion.TabIndex = 7;
            // 
            // cb_p1_version
            // 
            cb_p1_version.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_p1_version.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p1_version.FormattingEnabled = true;
            cb_p1_version.Items.AddRange(new object[] { "" });
            cb_p1_version.Location = new Point(113, 76);
            cb_p1_version.Margin = new Padding(5);
            cb_p1_version.Name = "cb_p1_version";
            cb_p1_version.Size = new Size(375, 25);
            cb_p1_version.TabIndex = 8;
            cb_p1_version.SelectedIndexChanged += loadOSMinorVersions;
            // 
            // flp_p1_bitness
            // 
            flp_p1_bitness.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flp_p1_bitness.AutoSize = true;
            flp_p1_bitness.Controls.Add(rb_p1_bitness_32);
            flp_p1_bitness.Controls.Add(rb_p1_bitness_64);
            flp_p1_bitness.Location = new Point(113, 146);
            flp_p1_bitness.Margin = new Padding(5);
            flp_p1_bitness.Name = "flp_p1_bitness";
            flp_p1_bitness.Size = new Size(375, 27);
            flp_p1_bitness.TabIndex = 10;
            flp_p1_bitness.Visible = false;
            // 
            // rb_p1_bitness_32
            // 
            rb_p1_bitness_32.AutoSize = true;
            rb_p1_bitness_32.Location = new Point(3, 3);
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
            rb_p1_bitness_64.Location = new Point(146, 3);
            rb_p1_bitness_64.Name = "rb_p1_bitness_64";
            rb_p1_bitness_64.Size = new Size(90, 21);
            rb_p1_bitness_64.TabIndex = 1;
            rb_p1_bitness_64.TabStop = true;
            rb_p1_bitness_64.Text = "64 Bit (x64)";
            rb_p1_bitness_64.UseVisualStyleBackColor = true;
            // 
            // p_diskPage
            // 
            p_diskPage.Controls.Add(panel2);
            p_diskPage.Dock = DockStyle.Fill;
            p_diskPage.Location = new Point(10, 10);
            p_diskPage.Margin = new Padding(0);
            p_diskPage.Name = "p_diskPage";
            p_diskPage.Size = new Size(503, 414);
            p_diskPage.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(503, 414);
            panel2.TabIndex = 4;
            // 
            // p_finishPage
            // 
            p_finishPage.Controls.Add(panel1);
            p_finishPage.Dock = DockStyle.Fill;
            p_finishPage.Location = new Point(10, 10);
            p_finishPage.Name = "p_finishPage";
            p_finishPage.Size = new Size(503, 414);
            p_finishPage.TabIndex = 1;
            p_finishPage.Visible = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 414);
            panel1.TabIndex = 3;
            // 
            // WIN_NewMachine
            // 
            AcceptButton = b_next;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(523, 483);
            Controls.Add(p_main);
            Controls.Add(fpl_bottom);
            Name = "WIN_NewMachine";
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
            p_diskPage.ResumeLayout(false);
            p_finishPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button b_cancel;
        private Button b_next;
        private FlowLayoutPanel fpl_bottom;
        private Panel p0;
        private Button b_back;
        private Button b_expert;
        private Panel p_finishPage;
        private Panel p_diskPage;
        private Label ls_p0info;
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
        private Label ls_p1info;
        private RadioButton rb_p1_os_mac;
        private RadioButton rb_p1_os_linux;
        private ComboBox cb_p1_subversion;
        private ComboBox cb_p1_version;
        private RadioButton rb_p1_bitness_32;
        private RadioButton rb_p1_bitness_64;
    }
}