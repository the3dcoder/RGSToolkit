namespace $safeprojectname$
{
    partial class CAWSyncCheck
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
            this.btnSyncDataDisplay = new System.Windows.Forms.Button();
            this.lblSyncTimeLabel = new System.Windows.Forms.Label();
            this.lblSyncTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSiteID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSyncDataDisplay
            // 
            this.btnSyncDataDisplay.Location = new System.Drawing.Point(70, 113);
            this.btnSyncDataDisplay.Name = "btnSyncDataDisplay";
            this.btnSyncDataDisplay.Size = new System.Drawing.Size(116, 30);
            this.btnSyncDataDisplay.TabIndex = 0;
            this.btnSyncDataDisplay.Text = "Display Sync Data";
            this.btnSyncDataDisplay.UseVisualStyleBackColor = true;
            this.btnSyncDataDisplay.Click += new System.EventHandler(this.btnSyncDataDisplay_Click);
            // 
            // lblSyncTimeLabel
            // 
            this.lblSyncTimeLabel.AutoSize = true;
            this.lblSyncTimeLabel.Location = new System.Drawing.Point(24, 20);
            this.lblSyncTimeLabel.Name = "lblSyncTimeLabel";
            this.lblSyncTimeLabel.Size = new System.Drawing.Size(136, 13);
            this.lblSyncTimeLabel.TabIndex = 1;
            this.lblSyncTimeLabel.Text = "Last Sync Completed Time:";
            // 
            // lblSyncTime
            // 
            this.lblSyncTime.AutoSize = true;
            this.lblSyncTime.Location = new System.Drawing.Point(24, 67);
            this.lblSyncTime.Name = "lblSyncTime";
            this.lblSyncTime.Size = new System.Drawing.Size(0, 13);
            this.lblSyncTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Site ID: ";
            // 
            // lblSiteID
            // 
            this.lblSiteID.AutoSize = true;
            this.lblSiteID.Location = new System.Drawing.Point(186, 67);
            this.lblSiteID.Name = "lblSiteID";
            this.lblSiteID.Size = new System.Drawing.Size(0, 13);
            this.lblSiteID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email Address:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(341, 43);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(35, 13);
            this.lblEmailAddress.TabIndex = 6;
            this.lblEmailAddress.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(341, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(35, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "label4";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(311, 113);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(116, 30);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt Password";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // CAWSyncCheck
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 427);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSiteID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSyncTime);
            this.Controls.Add(this.lblSyncTimeLabel);
            this.Controls.Add(this.btnSyncDataDisplay);
            this.Name = "CAWSyncCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSyncDataDisplay;
        private System.Windows.Forms.Label lblSyncTimeLabel;
        private System.Windows.Forms.Label lblSyncTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSiteID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnDecrypt;
    }
}