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
            this.btnToken = new System.Windows.Forms.Button();
            this.lblTokenDisplay = new System.Windows.Forms.Label();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToken
            // 
            this.btnToken.Location = new System.Drawing.Point(12, 12);
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
            this.lblTokenDisplay.Location = new System.Drawing.Point(12, 50);
            this.lblTokenDisplay.Name = "lblTokenDisplay";
            this.lblTokenDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblTokenDisplay.TabIndex = 1;
            this.lblTokenDisplay.Text = "label1";
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(12, 78);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(150, 150);
            this.pbQRCode.TabIndex = 5;
            this.pbQRCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token #";
            // 
            // MOBLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(421, 315);
            this.Controls.Add(this.pbQRCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTokenDisplay);
            this.Controls.Add(this.btnToken);
            this.Name = "MOBLive";
            this.Text = "Mobile Live Utilities";
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToken;
        private System.Windows.Forms.Label lblTokenDisplay;
        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.Label label1;
    }
}