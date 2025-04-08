namespace QEMUInterface.Dialogs
{
    partial class YesNoCancel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label l_msg;
        private System.Windows.Forms.Button b_yes;
        private System.Windows.Forms.Button b_no;
        private System.Windows.Forms.Button b_cancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YesNoCancel));
            l_msg = new Label();
            b_yes = new Button();
            b_no = new Button();
            b_cancel = new Button();
            flp_buttons = new FlowLayoutPanel();
            panel1 = new Panel();
            flp_buttons.SuspendLayout();
            SuspendLayout();
            // 
            // l_msg
            // 
            l_msg.Location = new Point(95, 19);
            l_msg.Margin = new Padding(4, 0, 4, 0);
            l_msg.Name = "l_msg";
            l_msg.Size = new Size(226, 75);
            l_msg.TabIndex = 0;
            l_msg.Text = "Message";
            l_msg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // b_yes
            // 
            b_yes.Location = new Point(40, 8);
            b_yes.Margin = new Padding(4, 3, 4, 3);
            b_yes.Name = "b_yes";
            b_yes.Size = new Size(88, 27);
            b_yes.TabIndex = 1;
            b_yes.Text = "&Yes";
            b_yes.UseVisualStyleBackColor = true;
            b_yes.Click += b_yes_Click;
            // 
            // b_no
            // 
            b_no.Location = new Point(136, 8);
            b_no.Margin = new Padding(4, 3, 4, 3);
            b_no.Name = "b_no";
            b_no.Size = new Size(88, 27);
            b_no.TabIndex = 2;
            b_no.Text = "&No";
            b_no.UseVisualStyleBackColor = true;
            b_no.Click += b_no_Click;
            // 
            // b_cancel
            // 
            b_cancel.Location = new Point(232, 8);
            b_cancel.Margin = new Padding(4, 3, 4, 3);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(88, 27);
            b_cancel.TabIndex = 0;
            b_cancel.Text = "&Cancel";
            b_cancel.UseVisualStyleBackColor = true;
            b_cancel.Click += b_cancel_Click;
            // 
            // flp_buttons
            // 
            flp_buttons.AutoSize = true;
            flp_buttons.Controls.Add(b_cancel);
            flp_buttons.Controls.Add(b_no);
            flp_buttons.Controls.Add(b_yes);
            flp_buttons.Dock = DockStyle.Bottom;
            flp_buttons.FlowDirection = FlowDirection.RightToLeft;
            flp_buttons.Location = new Point(0, 113);
            flp_buttons.Name = "flp_buttons";
            flp_buttons.Padding = new Padding(10, 5, 0, 10);
            flp_buttons.Size = new Size(334, 48);
            flp_buttons.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(12, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 54);
            panel1.TabIndex = 5;
            // 
            // YesNoCancel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_cancel;
            ClientSize = new Size(334, 161);
            Controls.Add(panel1);
            Controls.Add(flp_buttons);
            Controls.Add(l_msg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "YesNoCancel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Caption";
            KeyDown += YesNoCancel_KeyDown;
            flp_buttons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_buttons;
        private Panel panel1;
    }
}