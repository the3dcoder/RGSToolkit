namespace $safeprojectname$
{
    partial class MOBLive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MOBLive));
            this.btnToken = new System.Windows.Forms.Button();
            this.lblTokenDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMOBInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWebserviceDisplay = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEmailTemplate = new System.Windows.Forms.Button();
            this.pbWebserviceQR = new System.Windows.Forms.PictureBox();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQRToTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHostedCustomer = new System.Windows.Forms.Label();
            this.pbAndroidLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebserviceQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAndroidLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToken
            // 
            this.btnToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(158)))), ((int)(((byte)(4)))));
            this.btnToken.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToken.BackgroundImage")));
            this.btnToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToken.Location = new System.Drawing.Point(135, 276);
            this.btnToken.Name = "btnToken";
            this.btnToken.Size = new System.Drawing.Size(150, 25);
            this.btnToken.TabIndex = 0;
            this.btnToken.Text = "Display My Token";
            this.btnToken.UseVisualStyleBackColor = false;
            this.btnToken.Click += new System.EventHandler(this.btnToken_Click);
            // 
            // lblTokenDisplay
            // 
            this.lblTokenDisplay.AutoSize = true;
            this.lblTokenDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblTokenDisplay.Location = new System.Drawing.Point(35, 238);
            this.lblTokenDisplay.Name = "lblTokenDisplay";
            this.lblTokenDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblTokenDisplay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(122, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token #";
            // 
            // btnMOBInfo
            // 
            this.btnMOBInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(158)))), ((int)(((byte)(4)))));
            this.btnMOBInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMOBInfo.BackgroundImage")));
            this.btnMOBInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMOBInfo.FlatAppearance.BorderSize = 0;
            this.btnMOBInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMOBInfo.Location = new System.Drawing.Point(291, 307);
            this.btnMOBInfo.Name = "btnMOBInfo";
            this.btnMOBInfo.Size = new System.Drawing.Size(150, 25);
            this.btnMOBInfo.TabIndex = 6;
            this.btnMOBInfo.Text = "Mobile Live Account Info";
            this.btnMOBInfo.UseVisualStyleBackColor = false;
            this.btnMOBInfo.Click += new System.EventHandler(this.btnMOBInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(382, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Webservice:";
            // 
            // lblWebserviceDisplay
            // 
            this.lblWebserviceDisplay.AutoSize = true;
            this.lblWebserviceDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblWebserviceDisplay.Location = new System.Drawing.Point(266, 238);
            this.lblWebserviceDisplay.Name = "lblWebserviceDisplay";
            this.lblWebserviceDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblWebserviceDisplay.TabIndex = 9;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(158)))), ((int)(((byte)(4)))));
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Location = new System.Drawing.Point(135, 307);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 25);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export to Template";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEmailTemplate
            // 
            this.btnEmailTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(158)))), ((int)(((byte)(4)))));
            this.btnEmailTemplate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmailTemplate.BackgroundImage")));
            this.btnEmailTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmailTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmailTemplate.Location = new System.Drawing.Point(291, 276);
            this.btnEmailTemplate.Name = "btnEmailTemplate";
            this.btnEmailTemplate.Size = new System.Drawing.Size(150, 25);
            this.btnEmailTemplate.TabIndex = 11;
            this.btnEmailTemplate.Text = "Email Template";
            this.btnEmailTemplate.UseVisualStyleBackColor = false;
            this.btnEmailTemplate.Click += new System.EventHandler(this.btnEmailTemplate_Click);
            // 
            // pbWebserviceQR
            // 
            this.pbWebserviceQR.BackColor = System.Drawing.Color.Transparent;
            this.pbWebserviceQR.Location = new System.Drawing.Point(331, 38);
            this.pbWebserviceQR.Name = "pbWebserviceQR";
            this.pbWebserviceQR.Size = new System.Drawing.Size(175, 175);
            this.pbWebserviceQR.TabIndex = 7;
            this.pbWebserviceQR.TabStop = false;
            // 
            // pbQRCode
            // 
            this.pbQRCode.BackColor = System.Drawing.Color.Transparent;
            this.pbQRCode.Location = new System.Drawing.Point(66, 38);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(175, 175);
            this.pbQRCode.TabIndex = 5;
            this.pbQRCode.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(158)))), ((int)(((byte)(4)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.mOBToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.saveQRToTemplateToolStripMenuItem,
            this.clearDatabaseConnectionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.connectToolStripMenuItem.Text = "Create new connection";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // saveQRToTemplateToolStripMenuItem
            // 
            this.saveQRToTemplateToolStripMenuItem.Name = "saveQRToTemplateToolStripMenuItem";
            this.saveQRToTemplateToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveQRToTemplateToolStripMenuItem.Text = "Save QR to Template";
            this.saveQRToTemplateToolStripMenuItem.Click += new System.EventHandler(this.saveQRToTemplateToolStripMenuItem_Click);
            // 
            // clearDatabaseConnectionToolStripMenuItem
            // 
            this.clearDatabaseConnectionToolStripMenuItem.Name = "clearDatabaseConnectionToolStripMenuItem";
            this.clearDatabaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.clearDatabaseConnectionToolStripMenuItem.Text = "Reset";
            this.clearDatabaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseConnectionToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblHostedCustomer
            // 
            this.lblHostedCustomer.AutoSize = true;
            this.lblHostedCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblHostedCustomer.Location = new System.Drawing.Point(455, 225);
            this.lblHostedCustomer.Name = "lblHostedCustomer";
            this.lblHostedCustomer.Size = new System.Drawing.Size(0, 13);
            this.lblHostedCustomer.TabIndex = 25;
            // 
            // pbAndroidLogo
            // 
            this.pbAndroidLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbAndroidLogo.BackgroundImage = global::$safeprojectname$.Properties.Resources.android_logo;
            this.pbAndroidLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAndroidLogo.Location = new System.Drawing.Point(352, 49);
            this.pbAndroidLogo.Name = "pbAndroidLogo";
            this.pbAndroidLogo.Size = new System.Drawing.Size(133, 145);
            this.pbAndroidLogo.TabIndex = 26;
            this.pbAndroidLogo.TabStop = false;
            this.pbAndroidLogo.Visible = false;
            // 
            // MOBLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::$safeprojectname$.Properties.Resources.greenformbg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 368);
            this.Controls.Add(this.pbAndroidLogo);
            this.Controls.Add(this.lblHostedCustomer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEmailTemplate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblWebserviceDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbWebserviceQR);
            this.Controls.Add(this.btnMOBInfo);
            this.Controls.Add(this.pbQRCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTokenDisplay);
            this.Controls.Add(this.btnToken);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MOBLive";
            this.Text = "Tech ToolKit 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pbWebserviceQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAndroidLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToken;
        private System.Windows.Forms.Label lblTokenDisplay;
        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMOBInfo;
        private System.Windows.Forms.PictureBox pbWebserviceQR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWebserviceDisplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEmailTemplate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblHostedCustomer;
        private System.Windows.Forms.PictureBox pbAndroidLogo;
        private System.Windows.Forms.ToolStripMenuItem saveQRToTemplateToolStripMenuItem;
    }
}