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
            TableLayoutPanel p0_tlp_main;
            Label ls_p0id;
            TableLayoutPanel p_finishPage_tlp_main;
            Label ls_p2id;
            TableLayoutPanel p1_tlp_main;
            Label ls_p1id;
            b_cancel = new Button();
            b_next = new Button();
            b_back = new Button();
            b_expert = new Button();
            p_namePage = new Panel();
            p_finishPage = new Panel();
            p_diskPage = new Panel();
            fpl_bottom = new FlowLayoutPanel();
            p_main = new Panel();
            p0_tlp_main = new TableLayoutPanel();
            ls_p0id = new Label();
            p_finishPage_tlp_main = new TableLayoutPanel();
            ls_p2id = new Label();
            p1_tlp_main = new TableLayoutPanel();
            ls_p1id = new Label();
            fpl_bottom.SuspendLayout();
            p_main.SuspendLayout();
            p_namePage.SuspendLayout();
            p0_tlp_main.SuspendLayout();
            p_finishPage.SuspendLayout();
            p_finishPage_tlp_main.SuspendLayout();
            p_diskPage.SuspendLayout();
            p1_tlp_main.SuspendLayout();
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
            p_main.Controls.Add(p_namePage);
            p_main.Controls.Add(p_finishPage);
            p_main.Controls.Add(p_diskPage);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Margin = new Padding(0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(10);
            p_main.Size = new Size(523, 434);
            p_main.TabIndex = 3;
            // 
            // p_namePage
            // 
            p_namePage.Controls.Add(p0_tlp_main);
            p_namePage.Dock = DockStyle.Fill;
            p_namePage.Location = new Point(10, 10);
            p_namePage.Name = "p_namePage";
            p_namePage.Size = new Size(503, 414);
            p_namePage.TabIndex = 0;
            // 
            // p0_tlp_main
            // 
            p0_tlp_main.ColumnCount = 2;
            p0_tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            p0_tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            p0_tlp_main.Controls.Add(ls_p0id, 0, 0);
            p0_tlp_main.Dock = DockStyle.Fill;
            p0_tlp_main.Location = new Point(0, 0);
            p0_tlp_main.Margin = new Padding(0);
            p0_tlp_main.Name = "p0_tlp_main";
            p0_tlp_main.Padding = new Padding(5);
            p0_tlp_main.RowCount = 3;
            p0_tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 11.85984F));
            p0_tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 54.8068275F));
            p0_tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            p0_tlp_main.Size = new Size(503, 414);
            p0_tlp_main.TabIndex = 0;
            // 
            // ls_p0id
            // 
            ls_p0id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ls_p0id.AutoSize = true;
            p0_tlp_main.SetColumnSpan(ls_p0id, 2);
            ls_p0id.Location = new Point(8, 5);
            ls_p0id.Name = "ls_p0id";
            ls_p0id.Size = new Size(487, 47);
            ls_p0id.TabIndex = 0;
            ls_p0id.Text = "this is panel 0 start page";
            ls_p0id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p_finishPage
            // 
            p_finishPage.Controls.Add(p_finishPage_tlp_main);
            p_finishPage.Dock = DockStyle.Fill;
            p_finishPage.Location = new Point(10, 10);
            p_finishPage.Name = "p_finishPage";
            p_finishPage.Size = new Size(503, 414);
            p_finishPage.TabIndex = 1;
            p_finishPage.Visible = false;
            // 
            // p_finishPage_tlp_main
            // 
            p_finishPage_tlp_main.ColumnCount = 2;
            p_finishPage_tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            p_finishPage_tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            p_finishPage_tlp_main.Controls.Add(ls_p2id, 0, 0);
            p_finishPage_tlp_main.Dock = DockStyle.Fill;
            p_finishPage_tlp_main.Location = new Point(0, 0);
            p_finishPage_tlp_main.Margin = new Padding(0);
            p_finishPage_tlp_main.Name = "p_finishPage_tlp_main";
            p_finishPage_tlp_main.Padding = new Padding(5);
            p_finishPage_tlp_main.RowCount = 3;
            p_finishPage_tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 11.85984F));
            p_finishPage_tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 54.8068275F));
            p_finishPage_tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            p_finishPage_tlp_main.Size = new Size(503, 414);
            p_finishPage_tlp_main.TabIndex = 1;
            // 
            // ls_p2id
            // 
            ls_p2id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ls_p2id.AutoSize = true;
            p_finishPage_tlp_main.SetColumnSpan(ls_p2id, 2);
            ls_p2id.Location = new Point(8, 5);
            ls_p2id.Name = "ls_p2id";
            ls_p2id.Size = new Size(487, 47);
            ls_p2id.TabIndex = 0;
            ls_p2id.Text = "this is panel 2 finish page";
            ls_p2id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p_diskPage
            // 
            p_diskPage.Controls.Add(p1_tlp_main);
            p_diskPage.Dock = DockStyle.Fill;
            p_diskPage.Location = new Point(10, 10);
            p_diskPage.Margin = new Padding(0);
            p_diskPage.Name = "p_diskPage";
            p_diskPage.Size = new Size(503, 414);
            p_diskPage.TabIndex = 1;
            // 
            // p1_tlp_main
            // 
            p1_tlp_main.ColumnCount = 2;
            p1_tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            p1_tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            p1_tlp_main.Controls.Add(ls_p1id, 0, 0);
            p1_tlp_main.Dock = DockStyle.Fill;
            p1_tlp_main.Location = new Point(0, 0);
            p1_tlp_main.Margin = new Padding(0);
            p1_tlp_main.Name = "p1_tlp_main";
            p1_tlp_main.Padding = new Padding(5);
            p1_tlp_main.RowCount = 3;
            p1_tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 11.85984F));
            p1_tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 54.8068275F));
            p1_tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            p1_tlp_main.Size = new Size(503, 414);
            p1_tlp_main.TabIndex = 2;
            // 
            // ls_p1id
            // 
            ls_p1id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ls_p1id.AutoSize = true;
            p1_tlp_main.SetColumnSpan(ls_p1id, 2);
            ls_p1id.Location = new Point(8, 5);
            ls_p1id.Name = "ls_p1id";
            ls_p1id.Size = new Size(487, 47);
            ls_p1id.TabIndex = 0;
            ls_p1id.Text = "this is panel 1 for hard drives";
            ls_p1id.TextAlign = ContentAlignment.MiddleCenter;
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
            p_namePage.ResumeLayout(false);
            p0_tlp_main.ResumeLayout(false);
            p0_tlp_main.PerformLayout();
            p_finishPage.ResumeLayout(false);
            p_finishPage_tlp_main.ResumeLayout(false);
            p_finishPage_tlp_main.PerformLayout();
            p_diskPage.ResumeLayout(false);
            p1_tlp_main.ResumeLayout(false);
            p1_tlp_main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button b_cancel;
        private Button b_next;
        private FlowLayoutPanel fpl_bottom;
        private Panel p_namePage;
        private Button b_back;
        private Button b_expert;
        private Panel p_finishPage;
        private Panel p_diskPage;
    }
}