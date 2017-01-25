namespace $safeprojectname$
{
    partial class ToolkitMain
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
            this.btnUpdateKeys = new System.Windows.Forms.Button();
            this.btnDeleteBadShapes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectToDB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnReRunDB = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnComingSoon = new System.Windows.Forms.Button();
            this.btnChangedLinkedDoc = new System.Windows.Forms.Button();
            this.btnCAWSyncCheck = new System.Windows.Forms.Button();
            this.btnMobileLive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateKeys
            // 
            this.btnUpdateKeys.Location = new System.Drawing.Point(49, 202);
            this.btnUpdateKeys.Name = "btnUpdateKeys";
            this.btnUpdateKeys.Size = new System.Drawing.Size(194, 28);
            this.btnUpdateKeys.TabIndex = 2;
            this.btnUpdateKeys.Text = "Update Keys";
            this.btnUpdateKeys.UseVisualStyleBackColor = true;
            this.btnUpdateKeys.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteBadShapes
            // 
            this.btnDeleteBadShapes.Location = new System.Drawing.Point(49, 270);
            this.btnDeleteBadShapes.Name = "btnDeleteBadShapes";
            this.btnDeleteBadShapes.Size = new System.Drawing.Size(194, 28);
            this.btnDeleteBadShapes.TabIndex = 3;
            this.btnDeleteBadShapes.Text = "Delete Bad Shapes";
            this.btnDeleteBadShapes.UseVisualStyleBackColor = true;
            this.btnDeleteBadShapes.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tech Toolkit";
            // 
            // btnConnectToDB
            // 
            this.btnConnectToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConnectToDB.Location = new System.Drawing.Point(150, 57);
            this.btnConnectToDB.Name = "btnConnectToDB";
            this.btnConnectToDB.Size = new System.Drawing.Size(200, 28);
            this.btnConnectToDB.TabIndex = 0;
            this.btnConnectToDB.Text = "Connect to Customer\'s SQL Database";
            this.btnConnectToDB.UseVisualStyleBackColor = false;
            this.btnConnectToDB.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(150, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "You cannot run any of the utilities before connecting to the customer\'s SQL datab" +
    "ase.";
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(49, 168);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(194, 28);
            this.btnDeleteJob.TabIndex = 4;
            this.btnDeleteJob.Text = "Delete Jobs in a Season";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            this.btnDeleteJob.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnReRunDB
            // 
            this.btnReRunDB.Location = new System.Drawing.Point(49, 134);
            this.btnReRunDB.Name = "btnReRunDB";
            this.btnReRunDB.Size = new System.Drawing.Size(194, 28);
            this.btnReRunDB.TabIndex = 1;
            this.btnReRunDB.Text = "Rerun Database Updates";
            this.btnReRunDB.UseVisualStyleBackColor = true;
            this.btnReRunDB.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Location = new System.Drawing.Point(363, 57);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close Application ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnComingSoon
            // 
            this.btnComingSoon.Location = new System.Drawing.Point(284, 186);
            this.btnComingSoon.Name = "btnComingSoon";
            this.btnComingSoon.Size = new System.Drawing.Size(163, 60);
            this.btnComingSoon.TabIndex = 8;
            this.btnComingSoon.TabStop = false;
            this.btnComingSoon.Text = "Coming Soon!";
            this.btnComingSoon.UseVisualStyleBackColor = true;
            // 
            // btnChangedLinkedDoc
            // 
            this.btnChangedLinkedDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnChangedLinkedDoc.Location = new System.Drawing.Point(49, 236);
            this.btnChangedLinkedDoc.Name = "btnChangedLinkedDoc";
            this.btnChangedLinkedDoc.Size = new System.Drawing.Size(194, 28);
            this.btnChangedLinkedDoc.TabIndex = 5;
            this.btnChangedLinkedDoc.Text = "Change Linked Documents Location";
            this.btnChangedLinkedDoc.UseVisualStyleBackColor = true;
            this.btnChangedLinkedDoc.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnCAWSyncCheck
            // 
            this.btnCAWSyncCheck.Location = new System.Drawing.Point(479, 134);
            this.btnCAWSyncCheck.Name = "btnCAWSyncCheck";
            this.btnCAWSyncCheck.Size = new System.Drawing.Size(194, 28);
            this.btnCAWSyncCheck.TabIndex = 9;
            this.btnCAWSyncCheck.Text = "CAW Sync Check";
            this.btnCAWSyncCheck.UseVisualStyleBackColor = true;
            this.btnCAWSyncCheck.Click += new System.EventHandler(this.btnCAWSyncCheck_Click);
            // 
            // btnMobileLive
            // 
            this.btnMobileLive.Location = new System.Drawing.Point(479, 270);
            this.btnMobileLive.Name = "btnMobileLive";
            this.btnMobileLive.Size = new System.Drawing.Size(194, 28);
            this.btnMobileLive.TabIndex = 10;
            this.btnMobileLive.Text = "Mobile Live Tools";
            this.btnMobileLive.UseVisualStyleBackColor = true;
            this.btnMobileLive.Click += new System.EventHandler(this.btnMobileLive_Click);
            // 
            // ToolkitMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 335);
            this.Controls.Add(this.btnMobileLive);
            this.Controls.Add(this.btnCAWSyncCheck);
            this.Controls.Add(this.btnChangedLinkedDoc);
            this.Controls.Add(this.btnComingSoon);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReRunDB);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConnectToDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteBadShapes);
            this.Controls.Add(this.btnUpdateKeys);
            this.Name = "ToolkitMain";
            this.Text = "Tech Toolkit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateKeys;
        private System.Windows.Forms.Button btnDeleteBadShapes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnectToDB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Button btnReRunDB;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnComingSoon;
        private System.Windows.Forms.Button btnChangedLinkedDoc;
        private System.Windows.Forms.Button btnCAWSyncCheck;
        private System.Windows.Forms.Button btnMobileLive;
    }
}