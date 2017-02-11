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
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMOBInfo = new System.Windows.Forms.Button();
            this.pbWebserviceQR = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWebserviceDisplay = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEmailTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebserviceQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToken
            // 
            this.btnToken.Location = new System.Drawing.Point(213, 240);
            this.btnToken.Name = "btnToken";
            this.btnToken.Size = new System.Drawing.Size(150, 25);
            this.btnToken.TabIndex = 0;
            this.btnToken.Text = "Display My Token";
            this.btnToken.UseVisualStyleBackColor = true;
            this.btnToken.Click += new System.EventHandler(this.btnToken_Click);
            // 
            // lblTokenDisplay
            // 
            this.lblTokenDisplay.AutoSize = true;
            this.lblTokenDisplay.Location = new System.Drawing.Point(59, 22);
            this.lblTokenDisplay.Name = "lblTokenDisplay";
            this.lblTokenDisplay.Size = new System.Drawing.Size(175, 13);
            this.lblTokenDisplay.TabIndex = 1;
            this.lblTokenDisplay.Text = "____________________________";
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(59, 48);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(175, 175);
            this.pbQRCode.TabIndex = 5;
            this.pbQRCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token #";
            // 
            // btnMOBInfo
            // 
            this.btnMOBInfo.Location = new System.Drawing.Point(213, 333);
            this.btnMOBInfo.Name = "btnMOBInfo";
            this.btnMOBInfo.Size = new System.Drawing.Size(150, 25);
            this.btnMOBInfo.TabIndex = 6;
            this.btnMOBInfo.Text = "Mobile Live Account Info";
            this.btnMOBInfo.UseVisualStyleBackColor = true;
            // 
            // pbWebserviceQR
            // 
            this.pbWebserviceQR.Location = new System.Drawing.Point(324, 48);
            this.pbWebserviceQR.Name = "pbWebserviceQR";
            this.pbWebserviceQR.Size = new System.Drawing.Size(175, 175);
            this.pbWebserviceQR.TabIndex = 7;
            this.pbWebserviceQR.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Webservice:";
            // 
            // lblWebserviceDisplay
            // 
            this.lblWebserviceDisplay.AutoSize = true;
            this.lblWebserviceDisplay.Location = new System.Drawing.Point(321, 22);
            this.lblWebserviceDisplay.Name = "lblWebserviceDisplay";
            this.lblWebserviceDisplay.Size = new System.Drawing.Size(175, 13);
            this.lblWebserviceDisplay.TabIndex = 9;
            this.lblWebserviceDisplay.Text = "____________________________";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(213, 271);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 25);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export to Template";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEmailTemplate
            // 
            this.btnEmailTemplate.Location = new System.Drawing.Point(213, 302);
            this.btnEmailTemplate.Name = "btnEmailTemplate";
            this.btnEmailTemplate.Size = new System.Drawing.Size(150, 25);
            this.btnEmailTemplate.TabIndex = 11;
            this.btnEmailTemplate.Text = "Email Template";
            this.btnEmailTemplate.UseVisualStyleBackColor = true;
            this.btnEmailTemplate.Click += new System.EventHandler(this.btnEmailTemplate_Click);
            // 
            // MOBLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 481);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MOBLive";
            this.Text = "Mobile Live Utilities";
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebserviceQR)).EndInit();
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
    }
}