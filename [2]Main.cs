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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmUpdateCheck myForm = new frmUpdateCheck();
            myForm.ShowDialog();
            this.Show();
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void btnIssues_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/retr0gr4d3/QuickFix/issues");
        }

        private void lnkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/retr0gr4d3/QuickFix/tree/staging-beta");
        }

        private void lnkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://git.retr0.gr4d3.uk");
        }

        private void btnAudioFix_Click(object sender, EventArgs e)
        {
            lblNetworkingInfo.ForeColor = System.Drawing.Color.White;
            lblResetAudiosrv.Text = "Stopping Audiosrv...";
            string strCmdText;
            strCmdText = "/c net stop audiosrv"; //pressing the button will stop audiosrv, then...
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            wait(4000); //wait four seconds
            lblResetAudiosrv.Text = "Stopping AudioEndpointBuilder...";
            string strCmdText1;
            strCmdText1 = "/C net stop audioendpointbuilder"; //stops audiopointendbuilder
            System.Diagnostics.Process.Start("CMD.exe", strCmdText1);
            wait(4000); //wait four seconds
            lblResetAudiosrv.Text = "Starting AudioEndpointBuilder...";
            string strCmdText2;
            strCmdText2 = "/C net start audioendpointbuilder"; //starts audiopointendbuilder
            System.Diagnostics.Process.Start("CMD.exe", strCmdText2);
            wait(4000); //wait four seconds
            lblResetAudiosrv.Text = "Starting Audiosrv...";
            string strCmdText3;
            strCmdText3 = "/C net start audiosrv"; //starts audiosrv
            System.Diagnostics.Process.Start("CMD.exe", strCmdText3);
            wait(4000); //wait four seconds
            lblResetAudiosrv.Text = "Done!";
            lblResetAudiosrv.ForeColor = System.Drawing.Color.Green;
        }

        private void btnNetworking2_Click(object sender, EventArgs e)
        {
            lblNetworkingInfo.ForeColor = System.Drawing.Color.White;
            lblNetworkingInfo.Text = "/flushdns...";
            string strCmdText;
            strCmdText = "/K ipconfig /flushdns"; //flush dns
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            wait(5000); //wait four seconds
            lblNetworkingInfo.Text = "/registerdns...";
            string strCmdText1;
            strCmdText1 = "/K ipconfig /registerdns"; //register dns
            System.Diagnostics.Process.Start("CMD.exe", strCmdText1);
            wait(5000); //wait four seconds
            lblNetworkingInfo.Text = "Done!";
            lblNetworkingInfo.ForeColor = System.Drawing.Color.Green;
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            frmReboot myForm = new frmReboot();
            myForm.ShowDialog();
            this.Show();
        }

        private void btnNetworking1_Click(object sender, EventArgs e)
        {
            lblNetworkingInfo.ForeColor = System.Drawing.Color.White;
            lblNetworkingInfo.Text = "/release...";
            string strCmdText2;
            strCmdText2 = "/K ipconfig /release"; //release
            System.Diagnostics.Process.Start("CMD.exe", strCmdText2);
            wait(5000); //wait four seconds
            lblNetworkingInfo.Text = "/renew...";
            string strCmdText3;
            strCmdText3 = "/K ipconfig /renew"; //renew
            System.Diagnostics.Process.Start("CMD.exe", strCmdText3);
            wait(5000); //wait four seconds
            lblNetworkingInfo.Text = "Done!";
            lblNetworkingInfo.ForeColor = System.Drawing.Color.Green;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNetwork3_Click(object sender, EventArgs e)
        {
            lblNetworkingInfo.ForeColor = System.Drawing.Color.White;
            string strCmdText4;
            strCmdText4 = "/K netsh winsock reset"; //reset winsock
            System.Diagnostics.Process.Start("CMD.exe", strCmdText4);
            wait(5000); //wait four seconds
            lblNetworkingInfo.Text = "Please restart.";
            lblNetworkingInfo.ForeColor = System.Drawing.Color.Green;
            frmReboot myForm = new frmReboot();
            myForm.ShowDialog();
            this.Show();
        }

        private void btnDebugHidden_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/K echo hidden"; //reset winsock
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void btnDebugVisable_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/K echo visable"; //reset winsock
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void chkTest_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
