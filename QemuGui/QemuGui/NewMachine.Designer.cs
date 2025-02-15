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
            b_cancel = new Button();
            b_next = new Button();
            b_back = new Button();
            b_expert = new Button();
            p_namePage = new Panel();
            fpl_bottom = new FlowLayoutPanel();
            p_main = new Panel();
            fpl_bottom.SuspendLayout();
            p_main.SuspendLayout();
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
            fpl_bottom.Location = new Point(0, 422);
            fpl_bottom.Name = "fpl_bottom";
            fpl_bottom.Size = new Size(617, 49);
            fpl_bottom.TabIndex = 2;
            // 
            // b_cancel
            // 
            b_cancel.Location = new Point(521, 10);
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
            b_next.Location = new Point(415, 10);
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
            b_back.Location = new Point(322, 10);
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
            b_expert.Location = new Point(14, 10);
            b_expert.Margin = new Padding(5, 10, 200, 5);
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
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Margin = new Padding(0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(10);
            p_main.Size = new Size(617, 422);
            p_main.TabIndex = 3;
            // 
            // p_namePage
            // 
            p_namePage.Dock = DockStyle.Fill;
            p_namePage.Location = new Point(10, 10);
            p_namePage.Name = "p_namePage";
            p_namePage.Size = new Size(597, 402);
            p_namePage.TabIndex = 0;
            // 
            // WIN_NewMachine
            // 
            AcceptButton = b_next;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(617, 471);
            Controls.Add(p_main);
            Controls.Add(fpl_bottom);
            Name = "WIN_NewMachine";
            Text = "QEMU Interface - New Machine";
            FormClosing += WIN_NewMachine_FormClosing;
            fpl_bottom.ResumeLayout(false);
            p_main.ResumeLayout(false);
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
    }
}