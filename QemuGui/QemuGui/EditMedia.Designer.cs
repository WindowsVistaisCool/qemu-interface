﻿namespace QEMUInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_MEDIA));
            flp_bottom = new FlowLayoutPanel();
            b_cancel = new Button();
            b_save = new Button();
            label1 = new Label();
            p_main = new Panel();
            p_main.SuspendLayout();
            flp_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // p_main
            // 
            p_main.BackgroundImage = (Image)resources.GetObject("p_main.BackgroundImage");
            p_main.Controls.Add(label1);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(3);
            p_main.Size = new Size(594, 435);
            p_main.TabIndex = 4;
            // 
            // flp_bottom
            // 
            flp_bottom.AutoSize = true;
            flp_bottom.BackColor = SystemColors.ControlLight;
            flp_bottom.Controls.Add(b_cancel);
            flp_bottom.Controls.Add(b_save);
            flp_bottom.Dock = DockStyle.Bottom;
            flp_bottom.FlowDirection = FlowDirection.RightToLeft;
            flp_bottom.Location = new Point(0, 435);
            flp_bottom.Name = "flp_bottom";
            flp_bottom.Size = new Size(594, 49);
            flp_bottom.TabIndex = 3;
            // 
            // b_cancel
            // 
            b_cancel.BackColor = SystemColors.Control;
            b_cancel.BackgroundImageLayout = ImageLayout.None;
            b_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            b_cancel.FlatStyle = FlatStyle.System;
            b_cancel.Location = new Point(498, 10);
            b_cancel.Margin = new Padding(5, 10, 10, 10);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(86, 29);
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
            b_save.Location = new Point(402, 10);
            b_save.Margin = new Padding(5, 10, 5, 10);
            b_save.Name = "b_save";
            b_save.Size = new Size(86, 29);
            b_save.TabIndex = 0;
            b_save.Text = "Save";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 173);
            label1.Name = "label1";
            label1.Size = new Size(527, 60);
            label1.TabIndex = 0;
            label1.Text = "sooo i was actually too lazy to implemnet this box lmao\r\ngood luck making disks and whatever\r\n";
            // 
            // WIN_MEDIA
            // 
            AcceptButton = b_save;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(594, 484);
            Controls.Add(p_main);
            Controls.Add(flp_bottom);
            Name = "WIN_MEDIA";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Media -";
            FormClosing += WIN_MEDIA_FormClosing;
            p_main.ResumeLayout(false);
            p_main.PerformLayout();
            flp_bottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_bottom;
        private Button b_save;
        private Button b_cancel;
        private Label label1;
    }
}