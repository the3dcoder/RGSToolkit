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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCurrentDatabase = new System.Windows.Forms.Label();
            this.lblCurrentServer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBSyncTimes = new System.Windows.Forms.ListBox();
            this.LBPayments = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LBPaymentAmounts = new System.Windows.Forms.ListBox();
            this.LBAccountNumber = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSyncDataDisplay
            // 
            this.btnSyncDataDisplay.Location = new System.Drawing.Point(64, 319);
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
            this.lblSyncTimeLabel.Location = new System.Drawing.Point(6, 18);
            this.lblSyncTimeLabel.Name = "lblSyncTimeLabel";
            this.lblSyncTimeLabel.Size = new System.Drawing.Size(136, 13);
            this.lblSyncTimeLabel.TabIndex = 1;
            this.lblSyncTimeLabel.Text = "Last Sync Completed Time:";
            // 
            // lblSyncTime
            // 
            this.lblSyncTime.AutoSize = true;
            this.lblSyncTime.Location = new System.Drawing.Point(6, 41);
            this.lblSyncTime.Name = "lblSyncTime";
            this.lblSyncTime.Size = new System.Drawing.Size(0, 13);
            this.lblSyncTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Site ID: ";
            // 
            // lblSiteID
            // 
            this.lblSiteID.AutoSize = true;
            this.lblSiteID.Location = new System.Drawing.Point(180, 41);
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
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Payment Recieved:";
            // 
            // lblLastPayment
            // 
            this.lblLastPayment.AutoSize = true;
            this.lblLastPayment.Location = new System.Drawing.Point(6, 88);
            this.lblLastPayment.Name = "lblLastPayment";
            this.lblLastPayment.Size = new System.Drawing.Size(0, 13);
            this.lblLastPayment.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount:";
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(168, 88);
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
            this.groupBox1.Location = new System.Drawing.Point(578, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 109);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblPaymentAmount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblLastPayment);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblSiteID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblSyncTime);
            this.groupBox2.Controls.Add(this.lblSyncTimeLabel);
            this.groupBox2.Controls.Add(this.btnSyncDataDisplay);
            this.groupBox2.Location = new System.Drawing.Point(14, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 355);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Autopay Profiles";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCurrentDatabase);
            this.groupBox3.Controls.Add(this.lblCurrentServer);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(578, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 91);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Server & Database Info";
            // 
            // lblCurrentDatabase
            // 
            this.lblCurrentDatabase.AutoSize = true;
            this.lblCurrentDatabase.Location = new System.Drawing.Point(68, 65);
            this.lblCurrentDatabase.Name = "lblCurrentDatabase";
            this.lblCurrentDatabase.Size = new System.Drawing.Size(92, 13);
            this.lblCurrentDatabase.TabIndex = 3;
            this.lblCurrentDatabase.Text = "*Current Datbase*";
            // 
            // lblCurrentServer
            // 
            this.lblCurrentServer.AutoSize = true;
            this.lblCurrentServer.Location = new System.Drawing.Point(53, 31);
            this.lblCurrentServer.Name = "lblCurrentServer";
            this.lblCurrentServer.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentServer.TabIndex = 2;
            this.lblCurrentServer.Text = "*Current Server*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Database:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Server:";
            // 
            // LBSyncTimes
            // 
            this.LBSyncTimes.FormattingEnabled = true;
            this.LBSyncTimes.Items.AddRange(new object[] {
            "Recently Completed Syncs",
            "____________________________"});
            this.LBSyncTimes.Location = new System.Drawing.Point(281, 37);
            this.LBSyncTimes.Name = "LBSyncTimes";
            this.LBSyncTimes.Size = new System.Drawing.Size(135, 173);
            this.LBSyncTimes.TabIndex = 17;
            this.LBSyncTimes.SelectedIndexChanged += new System.EventHandler(this.LBSyncTimes_SelectedIndexChanged);
            // 
            // LBPayments
            // 
            this.LBPayments.FormattingEnabled = true;
            this.LBPayments.Items.AddRange(new object[] {
            "Most Recent Payments",
            "____________________________"});
            this.LBPayments.Location = new System.Drawing.Point(281, 219);
            this.LBPayments.MultiColumn = true;
            this.LBPayments.Name = "LBPayments";
            this.LBPayments.Size = new System.Drawing.Size(135, 173);
            this.LBPayments.TabIndex = 18;
            this.LBPayments.SelectedIndexChanged += new System.EventHandler(this.LBPayments_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(422, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 173);
            this.listBox1.TabIndex = 19;
            // 
            // LBPaymentAmounts
            // 
            this.LBPaymentAmounts.FormattingEnabled = true;
            this.LBPaymentAmounts.Items.AddRange(new object[] {
            "Amount ($)",
            "____________________________"});
            this.LBPaymentAmounts.Location = new System.Drawing.Point(422, 219);
            this.LBPaymentAmounts.Name = "LBPaymentAmounts";
            this.LBPaymentAmounts.Size = new System.Drawing.Size(59, 173);
            this.LBPaymentAmounts.TabIndex = 20;
            this.LBPaymentAmounts.SelectedIndexChanged += new System.EventHandler(this.LBPaymentAmounts_SelectedIndexChanged);
            // 
            // LBAccountNumber
            // 
            this.LBAccountNumber.FormattingEnabled = true;
            this.LBAccountNumber.Items.AddRange(new object[] {
            "Customer #",
            "____________________________"});
            this.LBAccountNumber.Location = new System.Drawing.Point(487, 219);
            this.LBAccountNumber.Name = "LBAccountNumber";
            this.LBAccountNumber.Size = new System.Drawing.Size(71, 173);
            this.LBAccountNumber.TabIndex = 21;
            this.LBAccountNumber.SelectedIndexChanged += new System.EventHandler(this.LBAccountNumber_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.mOBToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDatabaseConnectionToolStripMenuItem,
            this.connectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // mOBToolStripMenuItem
            // 
            this.mOBToolStripMenuItem.Name = "mOBToolStripMenuItem";
            this.mOBToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mOBToolStripMenuItem.Text = "MOB";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // clearDatabaseConnectionToolStripMenuItem
            // 
            this.clearDatabaseConnectionToolStripMenuItem.Name = "clearDatabaseConnectionToolStripMenuItem";
            this.clearDatabaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.clearDatabaseConnectionToolStripMenuItem.Text = "Clear Database Connection";
            this.clearDatabaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseConnectionToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // CAWSyncCheck
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(859, 413);
            this.Controls.Add(this.LBAccountNumber);
            this.Controls.Add(this.LBPaymentAmounts);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LBPayments);
            this.Controls.Add(this.LBSyncTimes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CAWSyncCheck";
            this.Text = "CAW Information Panel";
            this.Load += new System.EventHandler(this.CAWSyncCheck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLastPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentDatabase;
        private System.Windows.Forms.Label lblCurrentServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LBSyncTimes;
        private System.Windows.Forms.ListBox LBPayments;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox LBPaymentAmounts;
        private System.Windows.Forms.ListBox LBAccountNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    }
}