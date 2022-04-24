namespace retrograde.project.bugsplatter
{
    partial class frmUpdateCheck
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatesYes = new System.Windows.Forms.Button();
            this.btnUpdatesNo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Would you like to check the latest version on GitHub?";
            // 
            // btnUpdatesYes
            // 
            this.btnUpdatesYes.Location = new System.Drawing.Point(24, 35);
            this.btnUpdatesYes.Name = "btnUpdatesYes";
            this.btnUpdatesYes.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatesYes.TabIndex = 1;
            this.btnUpdatesYes.Text = "Yes";
            this.btnUpdatesYes.UseVisualStyleBackColor = true;
            this.btnUpdatesYes.Click += new System.EventHandler(this.btnUpdatesYes_Click);
            // 
            // btnUpdatesNo
            // 
            this.btnUpdatesNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdatesNo.Location = new System.Drawing.Point(189, 35);
            this.btnUpdatesNo.Name = "btnUpdatesNo";
            this.btnUpdatesNo.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatesNo.TabIndex = 2;
            this.btnUpdatesNo.Text = "No";
            this.btnUpdatesNo.UseVisualStyleBackColor = true;
            this.btnUpdatesNo.Click += new System.EventHandler(this.btnUpdatesNo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Currently: 0.5.0";
            // 
            // frmUpdateCheck
            // 
            this.AcceptButton = this.btnUpdatesYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.btnUpdatesNo;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdatesNo);
            this.Controls.Add(this.btnUpdatesYes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmUpdateCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check for updates?";
            this.Load += new System.EventHandler(this.frmUpdateCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatesYes;
        private System.Windows.Forms.Button btnUpdatesNo;
        private System.Windows.Forms.Label label2;
    }
}