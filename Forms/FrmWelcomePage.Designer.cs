namespace HR_Global_System
{
    partial class FrmWelcomePage
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
            this.lblWelcomePage = new System.Windows.Forms.Label();
            this.btnAccessHRPortal = new System.Windows.Forms.Button();
            this.btnAccessSelfService = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomePage
            // 
            this.lblWelcomePage.AutoSize = true;
            this.lblWelcomePage.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomePage.Location = new System.Drawing.Point(12, 25);
            this.lblWelcomePage.Name = "lblWelcomePage";
            this.lblWelcomePage.Size = new System.Drawing.Size(1617, 79);
            this.lblWelcomePage.TabIndex = 0;
            this.lblWelcomePage.Text = "Welcome to the HR System- Select your portal below";
            // 
            // btnAccessHRPortal
            // 
            this.btnAccessHRPortal.Font = new System.Drawing.Font("MV Boli", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessHRPortal.Location = new System.Drawing.Point(630, 136);
            this.btnAccessHRPortal.Name = "btnAccessHRPortal";
            this.btnAccessHRPortal.Size = new System.Drawing.Size(429, 317);
            this.btnAccessHRPortal.TabIndex = 1;
            this.btnAccessHRPortal.Text = "Access HR Manager Portal";
            this.btnAccessHRPortal.UseVisualStyleBackColor = true;
            this.btnAccessHRPortal.Click += new System.EventHandler(this.btnAccessHRPortal_Click);
            // 
            // btnAccessSelfService
            // 
            this.btnAccessSelfService.Font = new System.Drawing.Font("MV Boli", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessSelfService.Location = new System.Drawing.Point(26, 136);
            this.btnAccessSelfService.Name = "btnAccessSelfService";
            this.btnAccessSelfService.Size = new System.Drawing.Size(429, 317);
            this.btnAccessSelfService.TabIndex = 2;
            this.btnAccessSelfService.Text = "Access Employee Self-Service Portal";
            this.btnAccessSelfService.UseVisualStyleBackColor = true;
            this.btnAccessSelfService.Click += new System.EventHandler(this.btnAccessSelfService_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1200, 136);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(429, 317);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit System";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmWelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 819);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccessSelfService);
            this.Controls.Add(this.btnAccessHRPortal);
            this.Controls.Add(this.lblWelcomePage);
            this.Name = "FrmWelcomePage";
            this.Text = "HR System Welcome Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomePage;
        private System.Windows.Forms.Button btnAccessHRPortal;
        private System.Windows.Forms.Button btnAccessSelfService;
        private System.Windows.Forms.Button btnExit;
    }
}

