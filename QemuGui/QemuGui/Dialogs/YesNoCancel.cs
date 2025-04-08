using DarkModeForms;
using QEMUInterface.Properties;

namespace QEMUInterface.Dialogs
{
    public partial class YesNoCancel : Form
    {
        private readonly Action<DialogResult> result;
        private readonly Keys yesDown;
        private readonly Keys noDown;

        public YesNoCancel(string message, string title, Action<DialogResult> result, string yesText, string noText, Keys yesDown, Keys noDown)
        {
            this.result = result;
            this.yesDown = yesDown;
            this.noDown = noDown;

            InitializeComponent();

            Text = title;
            l_msg.Text = message;
            b_yes.Text = yesText;
            b_no.Text = noText;

            if (Settings.Default.darkMode)
            {
                _ = new DarkModeCS(this)
                {
                    ColorMode = DarkModeCS.DisplayMode.DarkMode
                };
            }
        }

        public static void Show(string message, string title, Action<DialogResult> result, string yesText, string noText)
        {
            Keys yesDown = yesText.IndexOf('&') > 0 ? (Keys)yesText[yesText.IndexOf('&') + 1] : Keys.Y;
            Keys noDown = noText.IndexOf('&') > 0 ? (Keys)noText[noText.IndexOf('&') + 1] : Keys.N;
            new YesNoCancel(message, title, result, yesText, noText, yesDown, noDown).ShowDialog();
        }

        private void b_yes_Click(object sender, EventArgs e)
        {
            Close();
            result.Invoke(DialogResult.Yes);
        }

        private void b_no_Click(object sender, EventArgs e)
        {
            Close();
            result.Invoke(DialogResult.No);
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
            result.Invoke(DialogResult.Cancel);
        }

        private void YesNoCancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == yesDown)
            {
                b_yes_Click(sender, e);
            }
            else if (e.Alt && e.KeyCode == noDown)
            {
                b_no_Click(sender, e);
            }
        }
    }
}
