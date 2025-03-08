namespace QEMUInterface
{
    partial class WIN_ABOUT
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
            Label ls_name;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_ABOUT));
            b_close = new Button();
            ls_name = new Label();
            SuspendLayout();
            // 
            // ls_name
            // 
            ls_name.AutoSize = true;
            ls_name.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ls_name.Location = new Point(128, 9);
            ls_name.Name = "ls_name";
            ls_name.Size = new Size(174, 50);
            ls_name.TabIndex = 0;
            ls_name.Text = "Made by Kyle Rush\r\nMarch 2025";
            ls_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // b_close
            // 
            b_close.Location = new Point(142, 207);
            b_close.Name = "b_close";
            b_close.Size = new Size(149, 40);
            b_close.TabIndex = 1;
            b_close.Text = "Close";
            b_close.UseVisualStyleBackColor = true;
            b_close.Click += CloseWindow;
            // 
            // WIN_ABOUT
            // 
            AcceptButton = b_close;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = b_close;
            ClientSize = new Size(434, 259);
            Controls.Add(b_close);
            Controls.Add(ls_name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WIN_ABOUT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_close;
    }
}