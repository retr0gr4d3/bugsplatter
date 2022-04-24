using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retrograde.project.bugsplatter
{
    public partial class frmReboot : Form
    {
        public frmReboot()
        {
            InitializeComponent();
        }
        private void btnReboot_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/K echo shutdown /r -t 00"; //pressing the button will instantly restart the PC.
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
