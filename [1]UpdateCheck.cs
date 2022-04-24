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
            System.Diagnostics.Process.Start("https://github.com/retr0gr4d3/QuickFix/releases");
            this.Close();
        }
        private void btnUpdatesNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
