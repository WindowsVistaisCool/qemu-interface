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
            tlp_main = new TableLayoutPanel();
            b_newDisk = new Button();
            flp_bottom = new FlowLayoutPanel();
            b_cancel = new Button();
            b_save = new Button();
            tv_main = new TreeView();
            label1 = new Label();
            p_main = new Panel();
            p_main.SuspendLayout();
            tlp_main.SuspendLayout();
            flp_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // p_main
            // 
            p_main.Controls.Add(tlp_main);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(0, 0);
            p_main.Name = "p_main";
            p_main.Padding = new Padding(3);
            p_main.Size = new Size(594, 383);
            p_main.TabIndex = 4;
            // 
            // tlp_main
            // 
            tlp_main.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlp_main.ColumnCount = 2;
            tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.9932F));
            tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.0068F));
            tlp_main.Controls.Add(b_newDisk, 0, 2);
            tlp_main.Controls.Add(tv_main, 0, 1);
            tlp_main.Controls.Add(label1, 0, 0);
            tlp_main.Dock = DockStyle.Fill;
            tlp_main.Location = new Point(3, 3);
            tlp_main.Name = "tlp_main";
            tlp_main.RowCount = 3;
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 9.814323F));
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 66.57825F));
            tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4042568F));
            tlp_main.Size = new Size(588, 377);
            tlp_main.TabIndex = 0;
            tlp_main.Paint += tlp_main_Paint;
            // 
            // b_newDisk
            // 
            b_newDisk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            b_newDisk.Location = new Point(41, 292);
            b_newDisk.Margin = new Padding(40, 5, 40, 5);
            b_newDisk.Name = "b_newDisk";
            b_newDisk.Size = new Size(259, 23);
            b_newDisk.TabIndex = 2;
            b_newDisk.Text = "Add New HDD";
            b_newDisk.UseVisualStyleBackColor = true;
            b_newDisk.Click += b_newDisk_Click;
            // 
            // flp_bottom
            // 
            flp_bottom.AutoSize = true;
            flp_bottom.BackColor = SystemColors.ControlLight;
            flp_bottom.Controls.Add(b_cancel);
            flp_bottom.Controls.Add(b_save);
            flp_bottom.Dock = DockStyle.Bottom;
            flp_bottom.FlowDirection = FlowDirection.RightToLeft;
            flp_bottom.Location = new Point(0, 383);
            flp_bottom.Name = "flp_bottom";
            flp_bottom.Size = new Size(594, 44);
            flp_bottom.TabIndex = 3;
            // 
            // b_cancel
            // 
            b_cancel.BackColor = SystemColors.Control;
            b_cancel.BackgroundImageLayout = ImageLayout.None;
            b_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            b_cancel.FlatStyle = FlatStyle.System;
            b_cancel.Location = new Point(498, 9);
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
            b_save.Location = new Point(402, 9);
            b_save.Margin = new Padding(5, 9, 5, 9);
            b_save.Name = "b_save";
            b_save.Size = new Size(86, 26);
            b_save.TabIndex = 0;
            b_save.Text = "Save";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // tv_main
            // 
            tv_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tv_main.Location = new Point(21, 58);
            tv_main.Margin = new Padding(20);
            tv_main.Name = "tv_main";
            tv_main.Size = new Size(299, 208);
            tv_main.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(4, 11);
            label1.Name = "label1";
            label1.Size = new Size(333, 15);
            label1.TabIndex = 4;
            label1.Text = "Devices";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WIN_MEDIA
            // 
            AcceptButton = b_save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(594, 427);
            Controls.Add(p_main);
            Controls.Add(flp_bottom);
            Name = "WIN_MEDIA";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Media -";
            FormClosing += WIN_MEDIA_FormClosing;
            p_main.ResumeLayout(false);
            tlp_main.ResumeLayout(false);
            tlp_main.PerformLayout();
            flp_bottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_bottom;
        private Button b_save;
        private Button b_cancel;
        private TableLayoutPanel tlp_main;
        private Button b_newDisk;
        private TreeView tv_main;
        private Label label1;
    }
}