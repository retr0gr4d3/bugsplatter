namespace QuickFix_AIO
{
    partial class Form1main
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
            this.btnResetAudiosrv = new System.Windows.Forms.Button();
            this.lblResetAudiosrv = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcome2 = new System.Windows.Forms.Label();
            this.lblWelcome3 = new System.Windows.Forms.Label();
            this.lnklblGithub = new System.Windows.Forms.LinkLabel();
            this.lblAudiosrv = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblCreditTag = new System.Windows.Forms.Label();
            this.btnCredits = new System.Windows.Forms.Button();
            this.lblComingSoon1 = new System.Windows.Forms.Label();
            this.lblComingSoon2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNetworkReset2 = new System.Windows.Forms.Button();
            this.btnDebugNo = new System.Windows.Forms.Button();
            this.btnDebugYes = new System.Windows.Forms.Button();
            this.lblDebugNo = new System.Windows.Forms.Label();
            this.lblDebugYes = new System.Windows.Forms.Label();
            this.lblNetworkReset = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetNetFull = new System.Windows.Forms.Button();
            this.lblFixNetQuicker = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnResetAudiosrv
            // 
            this.btnResetAudiosrv.Location = new System.Drawing.Point(277, 142);
            this.btnResetAudiosrv.Name = "btnResetAudiosrv";
            this.btnResetAudiosrv.Size = new System.Drawing.Size(75, 23);
            this.btnResetAudiosrv.TabIndex = 0;
            this.btnResetAudiosrv.Text = "Fix!";
            this.btnResetAudiosrv.UseVisualStyleBackColor = true;
            this.btnResetAudiosrv.Click += new System.EventHandler(this.btnResetAudiosrv_Click);
            // 
            // lblResetAudiosrv
            // 
            this.lblResetAudiosrv.AutoSize = true;
            this.lblResetAudiosrv.Location = new System.Drawing.Point(358, 147);
            this.lblResetAudiosrv.Name = "lblResetAudiosrv";
            this.lblResetAudiosrv.Size = new System.Drawing.Size(0, 13);
            this.lblResetAudiosrv.TabIndex = 2;
            this.lblResetAudiosrv.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(159, 13);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome to the QuickFix Alpha!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome2
            // 
            this.lblWelcome2.AutoSize = true;
            this.lblWelcome2.Location = new System.Drawing.Point(12, 22);
            this.lblWelcome2.Name = "lblWelcome2";
            this.lblWelcome2.Size = new System.Drawing.Size(288, 13);
            this.lblWelcome2.TabIndex = 4;
            this.lblWelcome2.Text = "This is a test version. Functionality is limited and incomplete.";
            // 
            // lblWelcome3
            // 
            this.lblWelcome3.AutoSize = true;
            this.lblWelcome3.Location = new System.Drawing.Point(12, 35);
            this.lblWelcome3.Name = "lblWelcome3";
            this.lblWelcome3.Size = new System.Drawing.Size(220, 13);
            this.lblWelcome3.TabIndex = 5;
            this.lblWelcome3.Text = "For any issues, please report them on github. ";
            // 
            // lnklblGithub
            // 
            this.lnklblGithub.AutoSize = true;
            this.lnklblGithub.Location = new System.Drawing.Point(12, 48);
            this.lnklblGithub.Name = "lnklblGithub";
            this.lnklblGithub.Size = new System.Drawing.Size(228, 13);
            this.lnklblGithub.TabIndex = 6;
            this.lnklblGithub.TabStop = true;
            this.lnklblGithub.Text = "https://github.com/retr0gr4d3/QuickFix/issues";
            this.lnklblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblGithub_LinkClicked);
            // 
            // lblAudiosrv
            // 
            this.lblAudiosrv.AutoSize = true;
            this.lblAudiosrv.Location = new System.Drawing.Point(124, 147);
            this.lblAudiosrv.Name = "lblAudiosrv";
            this.lblAudiosrv.Size = new System.Drawing.Size(147, 13);
            this.lblAudiosrv.TabIndex = 7;
            this.lblAudiosrv.Text = "Audio issues? Use this fella ->";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Crimson;
            this.lblWarning.Location = new System.Drawing.Point(12, 70);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(552, 13);
            this.lblWarning.TabIndex = 8;
            this.lblWarning.Text = "NOTE - While in Alpha, all command processes are unhidden. You will need to manua" +
    "lly exit any opened processes.";
            // 
            // lblCreditTag
            // 
            this.lblCreditTag.AutoSize = true;
            this.lblCreditTag.Location = new System.Drawing.Point(12, 340);
            this.lblCreditTag.Name = "lblCreditTag";
            this.lblCreditTag.Size = new System.Drawing.Size(208, 13);
            this.lblCreditTag.TabIndex = 9;
            this.lblCreditTag.Text = "Made with 💞 in London. Retr0gr4d3. MIT.";
            // 
            // btnCredits
            // 
            this.btnCredits.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCredits.Location = new System.Drawing.Point(277, 89);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(75, 23);
            this.btnCredits.TabIndex = 10;
            this.btnCredits.Text = "About";
            this.btnCredits.UseVisualStyleBackColor = true;
            // 
            // lblComingSoon1
            // 
            this.lblComingSoon1.AutoSize = true;
            this.lblComingSoon1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblComingSoon1.Location = new System.Drawing.Point(146, 205);
            this.lblComingSoon1.Name = "lblComingSoon1";
            this.lblComingSoon1.Size = new System.Drawing.Size(125, 13);
            this.lblComingSoon1.TabIndex = 11;
            this.lblComingSoon1.Text = "Network Reset QuickFix.";
            this.lblComingSoon1.Click += new System.EventHandler(this.lblComingSoon1_Click);
            // 
            // lblComingSoon2
            // 
            this.lblComingSoon2.AutoSize = true;
            this.lblComingSoon2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblComingSoon2.Location = new System.Drawing.Point(12, 258);
            this.lblComingSoon2.Name = "lblComingSoon2";
            this.lblComingSoon2.Size = new System.Drawing.Size(211, 13);
            this.lblComingSoon2.TabIndex = 13;
            this.lblComingSoon2.Text = "[FUTURE] Explorer.exe Restart QuickFix ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "See about for explanations on command functionality.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "DebugNote1 - If an option is grey, it is because: it is not working as intended  " +
    "/ bugged / not implemented.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "[IDEA] CN:SpaceMaker - cleans TEMP files with a click.";
            // 
            // btnNetworkReset2
            // 
            this.btnNetworkReset2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNetworkReset2.Location = new System.Drawing.Point(277, 171);
            this.btnNetworkReset2.Name = "btnNetworkReset2";
            this.btnNetworkReset2.Size = new System.Drawing.Size(75, 23);
            this.btnNetworkReset2.TabIndex = 18;
            this.btnNetworkReset2.Text = "Basic";
            this.btnNetworkReset2.UseVisualStyleBackColor = true;
            this.btnNetworkReset2.Click += new System.EventHandler(this.btnNetworkReset2_Click);
            // 
            // btnDebugNo
            // 
            this.btnDebugNo.Location = new System.Drawing.Point(12, 300);
            this.btnDebugNo.Name = "btnDebugNo";
            this.btnDebugNo.Size = new System.Drawing.Size(75, 23);
            this.btnDebugNo.TabIndex = 19;
            this.btnDebugNo.Text = "no window";
            this.btnDebugNo.UseVisualStyleBackColor = true;
            this.btnDebugNo.Click += new System.EventHandler(this.btnDebugNo_Click);
            // 
            // btnDebugYes
            // 
            this.btnDebugYes.Location = new System.Drawing.Point(483, 300);
            this.btnDebugYes.Name = "btnDebugYes";
            this.btnDebugYes.Size = new System.Drawing.Size(75, 23);
            this.btnDebugYes.TabIndex = 20;
            this.btnDebugYes.Text = "window";
            this.btnDebugYes.UseVisualStyleBackColor = true;
            this.btnDebugYes.Click += new System.EventHandler(this.btnDebugYes_Click);
            // 
            // lblDebugNo
            // 
            this.lblDebugNo.AutoSize = true;
            this.lblDebugNo.Location = new System.Drawing.Point(93, 305);
            this.lblDebugNo.Name = "lblDebugNo";
            this.lblDebugNo.Size = new System.Drawing.Size(87, 13);
            this.lblDebugNo.TabIndex = 21;
            this.lblDebugNo.Text = "background task";
            // 
            // lblDebugYes
            // 
            this.lblDebugYes.AutoSize = true;
            this.lblDebugYes.Location = new System.Drawing.Point(446, 305);
            this.lblDebugYes.Name = "lblDebugYes";
            this.lblDebugYes.Size = new System.Drawing.Size(31, 13);
            this.lblDebugYes.TabIndex = 22;
            this.lblDebugYes.Text = "open";
            // 
            // lblNetworkReset
            // 
            this.lblNetworkReset.AutoSize = true;
            this.lblNetworkReset.Location = new System.Drawing.Point(358, 205);
            this.lblNetworkReset.Name = "lblNetworkReset";
            this.lblNetworkReset.Size = new System.Drawing.Size(0, 13);
            this.lblNetworkReset.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Network Reset QuickerFix.";
            // 
            // btnResetNetFull
            // 
            this.btnResetNetFull.Location = new System.Drawing.Point(277, 200);
            this.btnResetNetFull.Name = "btnResetNetFull";
            this.btnResetNetFull.Size = new System.Drawing.Size(75, 23);
            this.btnResetNetFull.TabIndex = 26;
            this.btnResetNetFull.Text = "Full";
            this.btnResetNetFull.UseVisualStyleBackColor = true;
            this.btnResetNetFull.Click += new System.EventHandler(this.btnResetNetFull_Click);
            // 
            // lblFixNetQuicker
            // 
            this.lblFixNetQuicker.AutoSize = true;
            this.lblFixNetQuicker.Location = new System.Drawing.Point(358, 176);
            this.lblFixNetQuicker.Name = "lblFixNetQuicker";
            this.lblFixNetQuicker.Size = new System.Drawing.Size(0, 13);
            this.lblFixNetQuicker.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "There is an issue with the audio solution. See:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(232, 118);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 13);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Issue #1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 362);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFixNetQuicker);
            this.Controls.Add(this.btnResetNetFull);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNetworkReset);
            this.Controls.Add(this.lblDebugYes);
            this.Controls.Add(this.lblDebugNo);
            this.Controls.Add(this.btnDebugYes);
            this.Controls.Add(this.btnDebugNo);
            this.Controls.Add(this.btnNetworkReset2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblComingSoon2);
            this.Controls.Add(this.lblComingSoon1);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.lblCreditTag);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblAudiosrv);
            this.Controls.Add(this.lnklblGithub);
            this.Controls.Add(this.lblWelcome3);
            this.Controls.Add(this.lblWelcome2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblResetAudiosrv);
            this.Controls.Add(this.btnResetAudiosrv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1main";
            this.Text = "QuickFix ALPHA [PRE-RELEASE]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetAudiosrv;
        private System.Windows.Forms.Label lblResetAudiosrv;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcome2;
        private System.Windows.Forms.Label lblWelcome3;
        private System.Windows.Forms.LinkLabel lnklblGithub;
        private System.Windows.Forms.Label lblAudiosrv;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblCreditTag;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Label lblComingSoon1;
        private System.Windows.Forms.Label lblComingSoon2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNetworkReset2;
        private System.Windows.Forms.Button btnDebugNo;
        private System.Windows.Forms.Button btnDebugYes;
        private System.Windows.Forms.Label lblDebugNo;
        private System.Windows.Forms.Label lblDebugYes;
        private System.Windows.Forms.Label lblNetworkReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetNetFull;
        private System.Windows.Forms.Label lblFixNetQuicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

