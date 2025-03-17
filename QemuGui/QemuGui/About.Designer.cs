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
            l_github = new LinkLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ls_author = new Label();
            p_logo = new Panel();
            ls_name = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ls_name
            // 
            ls_name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ls_name.AutoSize = true;
            ls_name.Font = new Font("HarmonyOS Sans SC", 19.6981125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ls_name.Location = new Point(15, 170);
            ls_name.Margin = new Padding(5, 9, 5, 18);
            ls_name.Name = "ls_name";
            ls_name.Size = new Size(404, 32);
            ls_name.TabIndex = 0;
            ls_name.Text = "QEMUInterface";
            ls_name.TextAlign = ContentAlignment.MiddleCenter;
            ls_name.Click += ls_name_Click;
            // 
            // b_close
            // 
            b_close.Anchor = AnchorStyles.None;
            b_close.Location = new Point(172, 298);
            b_close.Margin = new Padding(5, 4, 5, 4);
            b_close.Name = "b_close";
            b_close.Size = new Size(89, 25);
            b_close.TabIndex = 1;
            b_close.Text = "Close";
            b_close.UseVisualStyleBackColor = true;
            b_close.Click += CloseWindow;
            // 
            // l_github
            // 
            l_github.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l_github.AutoSize = true;
            l_github.LinkBehavior = LinkBehavior.HoverUnderline;
            l_github.Location = new Point(15, 261);
            l_github.Margin = new Padding(5, 18, 5, 18);
            l_github.Name = "l_github";
            l_github.Size = new Size(404, 15);
            l_github.TabIndex = 2;
            l_github.TabStop = true;
            l_github.Text = "Explore on Github";
            l_github.TextAlign = ContentAlignment.MiddleCenter;
            l_github.LinkClicked += l_github_LinkClicked;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(l_github, 0, 4);
            tableLayoutPanel1.Controls.Add(b_close, 0, 5);
            tableLayoutPanel1.Controls.Add(ls_name, 0, 2);
            tableLayoutPanel1.Controls.Add(ls_author, 0, 3);
            tableLayoutPanel1.Controls.Add(p_logo, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 9, 10, 9);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.20994473F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.76834F));
            tableLayoutPanel1.Size = new Size(434, 336);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // ls_author
            // 
            ls_author.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ls_author.AutoSize = true;
            ls_author.Location = new Point(15, 224);
            ls_author.Margin = new Padding(5, 4, 5, 4);
            ls_author.Name = "ls_author";
            ls_author.Size = new Size(404, 15);
            ls_author.TabIndex = 3;
            ls_author.Text = "Made by Kyle Rush (WindowsVistaisCool)";
            ls_author.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p_logo
            // 
            p_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_logo.BackgroundImage = (Image)resources.GetObject("p_logo.BackgroundImage");
            p_logo.BackgroundImageLayout = ImageLayout.Center;
            p_logo.Location = new Point(22, 22);
            p_logo.Margin = new Padding(12);
            p_logo.Name = "p_logo";
            p_logo.Size = new Size(390, 127);
            p_logo.TabIndex = 4;
            // 
            // WIN_ABOUT
            // 
            AcceptButton = b_close;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = b_close;
            ClientSize = new Size(434, 336);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WIN_ABOUT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button b_close;
        private LinkLabel l_github;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ls_author;
        private Panel p_logo;
    }
}