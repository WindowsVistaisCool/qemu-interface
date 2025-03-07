namespace QEMUInterface
{
    partial class WIN_MEDIA
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
            Panel p_main;
            button1 = new Button();
            flp_bottom = new FlowLayoutPanel();
            b_cancel = new Button();
            b_save = new Button();
            p_main = new Panel();
            p_main.SuspendLayout();
            flp_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // p_main
            // 
            p_main.Controls.Add(button1);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(3);
            p_main.Size = new Size(642, 379);
            p_main.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(152, 68);
            button1.Name = "button1";
            button1.Size = new Size(311, 241);
            button1.TabIndex = 0;
            button1.Text = "grr button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flp_bottom
            // 
            flp_bottom.AutoSize = true;
            flp_bottom.BackColor = SystemColors.ControlLight;
            flp_bottom.Controls.Add(b_cancel);
            flp_bottom.Controls.Add(b_save);
            flp_bottom.Dock = DockStyle.Bottom;
            flp_bottom.FlowDirection = FlowDirection.RightToLeft;
            flp_bottom.Location = new Point(0, 379);
            flp_bottom.Name = "flp_bottom";
            flp_bottom.Size = new Size(642, 44);
            flp_bottom.TabIndex = 3;
            // 
            // b_cancel
            // 
            b_cancel.BackColor = SystemColors.Control;
            b_cancel.BackgroundImageLayout = ImageLayout.None;
            b_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            b_cancel.FlatStyle = FlatStyle.System;
            b_cancel.Location = new Point(546, 9);
            b_cancel.Margin = new Padding(5, 9, 10, 9);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(86, 26);
            b_cancel.TabIndex = 1;
            b_cancel.Text = "Cancel";
            b_cancel.UseVisualStyleBackColor = false;
            b_cancel.Click += b_cancel_Click;
            // 
            // b_save
            // 
            b_save.BackColor = SystemColors.Control;
            b_save.BackgroundImageLayout = ImageLayout.None;
            b_save.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            b_save.FlatStyle = FlatStyle.System;
            b_save.Location = new Point(450, 9);
            b_save.Margin = new Padding(5, 9, 5, 9);
            b_save.Name = "b_save";
            b_save.Size = new Size(86, 26);
            b_save.TabIndex = 0;
            b_save.Text = "Save";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // WIN_MEDIA
            // 
            AcceptButton = b_save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(642, 423);
            Controls.Add(p_main);
            Controls.Add(flp_bottom);
            Name = "WIN_MEDIA";
            Text = "Edit Media -";
            FormClosing += WIN_MEDIA_FormClosing;
            p_main.ResumeLayout(false);
            flp_bottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_bottom;
        private Button b_save;
        private Button b_cancel;
        private Button button1;
    }
}