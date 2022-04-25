using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace retrograde.project.bugsplatter
{
    public partial class frmUpdateCheck : Form
    {
        public frmUpdateCheck()
        {
            InitializeComponent();
        }
        private void btnUpdatesYes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to close this application and install the latest version from github. If you did not download the Updater.exe included on the release page, this will error out and pretend it never happened. Please ensure both the updater and this program are in the same root directory. In future versions, the updater will be grabbed automatically.", "Closing for updates.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Process.Start("Updater.exe");
                }
                catch
                {
                    MessageBox.Show("There was an error running the updater. Are you sure you have it downloaded and in the same directory? Please check, and try again.", "Failed to update.");
                }
            }
        }
        private void btnUpdatesNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateCheck_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
