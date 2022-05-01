﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuickFix_AIO
{
    public partial class Form1main : Form
    {
        public Form1main()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResetAudiosrv_Click(object sender, EventArgs e)
        {
            lblResetAudiosrv.Text = "Stopping Audiosrv...";
            string strCmdText;
            strCmdText = "/K net stop audiosrv"; //pressing the button will stop audiosrv, then...
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            wait(4000); //wait four seconds
            lblResetAudiosrv.Text = "Stopping AudioEndpointBuilder...";
            string strCmdText1;
            strCmdText1 = "/K net stop audioendpointbuilder"; //stops audiopointendbuilder
            System.Diagnostics.Process.Start("CMD.exe", strCmdText1);
            wait(5000); //wait four seconds
            lblResetAudiosrv.Text = "Starting AudioEndpointBuilder...";
            string strCmdText2;
            strCmdText2 = "/K net start audioendpointbuilder"; //starts audiopointendbuilder
            System.Diagnostics.Process.Start("CMD.exe", strCmdText2);
            wait(5000); //wait four seconds
            lblResetAudiosrv.Text = "Starting Audiosrv...";
            string strCmdText3;
            strCmdText3 = "/K net start audiosrv"; //starts audiosrv
            System.Diagnostics.Process.Start("CMD.exe", strCmdText3);
            wait(5000); //wait four seconds
            lblResetAudiosrv.Text = "Done!";
            lblResetAudiosrv.ForeColor = System.Drawing.Color.Green;
        }

        private void lblComingSoon1_Click(object sender, EventArgs e)
        {

        }

        private void lnklblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/retr0gr4d3/QuickFix/issues");
        }

        private void btnDebugYes_Click(object sender, EventArgs e)
        {
            frmTabbedUI myForm = new frmTabbedUI();
            myForm.ShowDialog();
            this.Show();
        }

        private void btnDebugNo_Click(object sender, EventArgs e)
        {
            lblDebugNo.Text = "should notice flash of app opening and closing";
            string strCmdText3;
            strCmdText3 = "/c echo debug"; //opens debug
            System.Diagnostics.Process.Start("CMD.exe", strCmdText3);
        }

        private void btnNetworkReset2_Click(object sender, EventArgs e)
        { 
            lblFixNetQuicker.Text = "/release...";
            string strCmdText2;
            strCmdText2 = "/K ipconfig /release"; //release
            System.Diagnostics.Process.Start("CMD.exe", strCmdText2);
            wait(5000); //wait four seconds
            lblFixNetQuicker.Text = "/renew...";
            string strCmdText3;
            strCmdText3 = "/K ipconfig /renew"; //renew
            System.Diagnostics.Process.Start("CMD.exe", strCmdText3);
            wait(5000); //wait four seconds
            lblFixNetQuicker.Text = "Done!";
            lblFixNetQuicker.ForeColor = System.Drawing.Color.Green;
        }

        private void btnResetNetFull_Click(object sender, EventArgs e)
        {
            lblNetworkReset.Text = "/flushdns...";
            string strCmdText;
            strCmdText = "/K ipconfig /flushdns"; //flush dns
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            wait(5000); //wait four seconds
            lblNetworkReset.Text = "/registerdns...";
            string strCmdText1;
            strCmdText1 = "/K ipconfig /registerdns"; //register dns
            System.Diagnostics.Process.Start("CMD.exe", strCmdText1);
            wait(5000); //wait four seconds
            lblNetworkReset.Text = "/release...";
            string strCmdText2;
            strCmdText2 = "/K ipconfig /release"; //release
            System.Diagnostics.Process.Start("CMD.exe", strCmdText2);
            wait(5000); //wait four seconds
            lblNetworkReset.Text = "/renew...";
            string strCmdText3;
            strCmdText3 = "/K ipconfig /renew"; //renew
            System.Diagnostics.Process.Start("CMD.exe", strCmdText3);
            wait(5000); //wait four seconds
            lblNetworkReset.Text = "Please restart.";
            string strCmdText4;
            strCmdText4 = "/K netsh winsock reset"; //reset winsock
            System.Diagnostics.Process.Start("CMD.exe", strCmdText4);
            wait(5000); //wait four seconds
            lblNetworkReset.Text = "Done!";
            lblNetworkReset.ForeColor = System.Drawing.Color.Green;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/retr0gr4d3/QuickFix/issues/1");
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            frmQuickFixAbout myForm = new frmQuickFixAbout();
            myForm.ShowDialog();
            this.Show();
        }
    }
}