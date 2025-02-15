namespace QEMUInterface
{
    partial class WIN_MachineSettings
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
            FlowLayoutPanel flp_bottom;
            b_ok = new Button();
            b_cancel = new Button();
            flp_bottom = new FlowLayoutPanel();
            flp_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // flp_bottom
            // 
            flp_bottom.AutoSize = true;
            flp_bottom.BackColor = SystemColors.ControlLight;
            flp_bottom.Controls.Add(b_ok);
            flp_bottom.Controls.Add(b_cancel);
            flp_bottom.Dock = DockStyle.Bottom;
            flp_bottom.FlowDirection = FlowDirection.RightToLeft;
            flp_bottom.Location = new Point(0, 434);
            flp_bottom.Name = "flp_bottom";
            flp_bottom.Size = new Size(675, 49);
            flp_bottom.TabIndex = 0;
            // 
            // b_ok
            // 
            b_ok.Location = new Point(582, 10);
            b_ok.Margin = new Padding(5, 10, 10, 10);
            b_ok.Name = "b_ok";
            b_ok.Size = new Size(83, 29);
            b_ok.TabIndex = 1;
            b_ok.Text = "Save";
            b_ok.UseVisualStyleBackColor = true;
            b_ok.Click += b_ok_Click;
            // 
            // b_cancel
            // 
            b_cancel.Location = new Point(489, 10);
            b_cancel.Margin = new Padding(5, 10, 5, 10);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(83, 29);
            b_cancel.TabIndex = 0;
            b_cancel.Text = "Cancel";
            b_cancel.UseVisualStyleBackColor = true;
            b_cancel.Click += b_cancel_Click;
            // 
            // WIN_MachineSettings
            // 
            AcceptButton = b_ok;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(675, 483);
            Controls.Add(flp_bottom);
            Name = "WIN_MachineSettings";
            Text = "Machine Settings";
            FormClosing += MachineSettings_FormClosing;
            flp_bottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_cancel;
        private Button b_ok;
    }
}