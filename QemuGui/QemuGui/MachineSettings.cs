namespace QEMUInterface
{
    public partial class WIN_MachineSettings : Form
    {
        private VirtualMachine machine;

        private bool unsavedChanges = false;

        public WIN_MachineSettings(VirtualMachine machine)
        {
            this.machine = machine;
            InitializeComponent();
            Text += " - " + machine.Name;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            unsavedChanges = false;
            Close();
        }

        private void MachineSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsavedChanges)
            {
                DialogResult result = MessageBox.Show("You have unsaved changes! Are you sure you want to close?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
