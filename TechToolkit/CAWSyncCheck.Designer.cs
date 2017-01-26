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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAWSyncCheck));
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastPayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSyncDataDisplay
            // 
            this.btnSyncDataDisplay.Location = new System.Drawing.Point(74, 115);
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
            this.lblSyncTimeLabel.Location = new System.Drawing.Point(16, 15);
            this.lblSyncTimeLabel.Name = "lblSyncTimeLabel";
            this.lblSyncTimeLabel.Size = new System.Drawing.Size(136, 13);
            this.lblSyncTimeLabel.TabIndex = 1;
            this.lblSyncTimeLabel.Text = "Last Sync Completed Time:";
            // 
            // lblSyncTime
            // 
            this.lblSyncTime.AutoSize = true;
            this.lblSyncTime.Location = new System.Drawing.Point(16, 38);
            this.lblSyncTime.Name = "lblSyncTime";
            this.lblSyncTime.Size = new System.Drawing.Size(0, 13);
            this.lblSyncTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Site ID: ";
            // 
            // lblSiteID
            // 
            this.lblSiteID.AutoSize = true;
            this.lblSiteID.Location = new System.Drawing.Point(190, 38);
            this.lblSiteID.Name = "lblSiteID";
            this.lblSiteID.Size = new System.Drawing.Size(0, 13);
            this.lblSiteID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email Address:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(83, 16);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(127, 13);
            this.lblEmailAddress.TabIndex = 6;
            this.lblEmailAddress.Text = "____________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(61, 40);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(151, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "________________________";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(53, 68);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(116, 30);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt Password";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Payment Recieved:";
            // 
            // lblLastPayment
            // 
            this.lblLastPayment.AutoSize = true;
            this.lblLastPayment.Location = new System.Drawing.Point(16, 85);
            this.lblLastPayment.Name = "lblLastPayment";
            this.lblLastPayment.Size = new System.Drawing.Size(0, 13);
            this.lblLastPayment.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount:";
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(178, 85);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(0, 13);
            this.lblPaymentAmount.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblEmailAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(324, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 109);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPaymentAmount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblLastPayment);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblSiteID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblSyncTime);
            this.groupBox2.Controls.Add(this.lblSyncTimeLabel);
            this.groupBox2.Controls.Add(this.btnSyncDataDisplay);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 151);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // CAWSyncCheck
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(565, 181);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CAWSyncCheck";
            this.Text = "CAW Information Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLastPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}