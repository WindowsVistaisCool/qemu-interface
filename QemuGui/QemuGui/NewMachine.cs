using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QEMUInterface
{
    public partial class WIN_NewMachine : Form
    {
        private Action<VirtualMachine> actionCallback;

        private int currentTabPage = 0;
        private readonly int maxTabPage = 2;
        private bool isOnFinishTab = false;
        private bool closeInvokedByFinishButton = false;

        public WIN_NewMachine(Action<VirtualMachine> newVMCallback)
        {
            actionCallback = newVMCallback;
            InitializeComponent();
            updatePanel();
        }

        private void WIN_NewMachine_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOnFinishTab && closeInvokedByFinishButton)
            {
                e.Cancel = true;
                closeInvokedByFinishButton = false;
                return;
            }

            actionCallback(null);
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            if (currentTabPage <= 0)
            {
                return;
            }

            currentTabPage--;
            updatePanel();

            if (isOnFinishTab)
            {
                isOnFinishTab = false;
                b_next.Text = "Next >";
            }


            if (currentTabPage == 0)
            {
                b_back.Enabled = false;
            }
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            if (isOnFinishTab)
            {
                closeInvokedByFinishButton = true;
                Close();
                return;
            }
            currentTabPage++;
            b_back.Enabled = true;
            updatePanel();

            if (currentTabPage >= maxTabPage)
            {
                isOnFinishTab = true;
                b_next.Text = "Finish";
            }
        }

        private void updatePanel()
        {
            p_namePage.Visible = currentTabPage == 0;
            p_diskPage.Visible = currentTabPage == 1;
            p_finishPage.Visible = currentTabPage == 2;
        }

    }
}
