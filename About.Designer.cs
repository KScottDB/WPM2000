namespace WPM2000
{
    partial class About
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelProgName = new System.Windows.Forms.Label();
            this.linkLabelGit = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelProgName
            // 
            this.labelProgName.AutoSize = true;
            this.labelProgName.Location = new System.Drawing.Point(66, 12);
            this.labelProgName.Name = "labelProgName";
            this.labelProgName.Size = new System.Drawing.Size(243, 13);
            this.labelProgName.TabIndex = 1;
            this.labelProgName.Text = "WPM2000: Package Manager for Retro Windows";
            // 
            // linkLabelGit
            // 
            this.linkLabelGit.AutoSize = true;
            this.linkLabelGit.Location = new System.Drawing.Point(66, 35);
            this.linkLabelGit.Name = "linkLabelGit";
            this.linkLabelGit.Size = new System.Drawing.Size(64, 13);
            this.linkLabelGit.TabIndex = 3;
            this.linkLabelGit.TabStop = true;
            this.linkLabelGit.Text = "[ GIT LINK ]";
            this.linkLabelGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openGithub);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 78);
            this.Controls.Add(this.linkLabelGit);
            this.Controls.Add(this.labelProgName);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WPM2000";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelProgName;
        private System.Windows.Forms.LinkLabel linkLabelGit;
    }
}