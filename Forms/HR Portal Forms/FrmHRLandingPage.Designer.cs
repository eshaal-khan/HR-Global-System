namespace HR_Global_System
{
    partial class FrmHRLandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHRLandingPage));
            this.lblHRLandingPage = new System.Windows.Forms.Label();
            this.btnViewEmployeeRecords = new System.Windows.Forms.Button();
            this.btnCreateEmployeeRecord = new System.Windows.Forms.Button();
            this.btnViewAnalytics = new System.Windows.Forms.Button();
            this.btnBackFromHRLanding = new System.Windows.Forms.Button();
            this.btnHRLogout = new System.Windows.Forms.Button();
            this.btnViewUpdateRequests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHRLandingPage
            // 
            this.lblHRLandingPage.AutoSize = true;
            this.lblHRLandingPage.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRLandingPage.Location = new System.Drawing.Point(20, 40);
            this.lblHRLandingPage.Name = "lblHRLandingPage";
            this.lblHRLandingPage.Size = new System.Drawing.Size(976, 46);
            this.lblHRLandingPage.TabIndex = 0;
            this.lblHRLandingPage.Text = "Successful login! Navigate to the below sections:";
            // 
            // btnViewEmployeeRecords
            // 
            this.btnViewEmployeeRecords.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmployeeRecords.Location = new System.Drawing.Point(28, 129);
            this.btnViewEmployeeRecords.Name = "btnViewEmployeeRecords";
            this.btnViewEmployeeRecords.Size = new System.Drawing.Size(276, 195);
            this.btnViewEmployeeRecords.TabIndex = 1;
            this.btnViewEmployeeRecords.Text = "View employee records";
            this.btnViewEmployeeRecords.UseVisualStyleBackColor = true;
            this.btnViewEmployeeRecords.Click += new System.EventHandler(this.btnViewEmployeeRecords_Click);
            // 
            // btnCreateEmployeeRecord
            // 
            this.btnCreateEmployeeRecord.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEmployeeRecord.Location = new System.Drawing.Point(968, 129);
            this.btnCreateEmployeeRecord.Name = "btnCreateEmployeeRecord";
            this.btnCreateEmployeeRecord.Size = new System.Drawing.Size(276, 195);
            this.btnCreateEmployeeRecord.TabIndex = 2;
            this.btnCreateEmployeeRecord.Text = "Create new employee record";
            this.btnCreateEmployeeRecord.UseVisualStyleBackColor = true;
            this.btnCreateEmployeeRecord.Click += new System.EventHandler(this.btnCreateEmployeeRecord_Click);
            // 
            // btnViewAnalytics
            // 
            this.btnViewAnalytics.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAnalytics.Location = new System.Drawing.Point(480, 129);
            this.btnViewAnalytics.Name = "btnViewAnalytics";
            this.btnViewAnalytics.Size = new System.Drawing.Size(276, 195);
            this.btnViewAnalytics.TabIndex = 3;
            this.btnViewAnalytics.Text = "View Analytics";
            this.btnViewAnalytics.UseVisualStyleBackColor = true;
            this.btnViewAnalytics.Click += new System.EventHandler(this.btnViewAnalytics_Click);
            // 
            // btnBackFromHRLanding
            // 
            this.btnBackFromHRLanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFromHRLanding.Image = ((System.Drawing.Image)(resources.GetObject("btnBackFromHRLanding.Image")));
            this.btnBackFromHRLanding.Location = new System.Drawing.Point(1374, 28);
            this.btnBackFromHRLanding.Name = "btnBackFromHRLanding";
            this.btnBackFromHRLanding.Size = new System.Drawing.Size(125, 128);
            this.btnBackFromHRLanding.TabIndex = 4;
            this.btnBackFromHRLanding.UseVisualStyleBackColor = true;
            this.btnBackFromHRLanding.Click += new System.EventHandler(this.btnBackFromHRLanding_Click);
            // 
            // btnHRLogout
            // 
            this.btnHRLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnHRLogout.Image")));
            this.btnHRLogout.Location = new System.Drawing.Point(1193, 440);
            this.btnHRLogout.Name = "btnHRLogout";
            this.btnHRLogout.Size = new System.Drawing.Size(306, 106);
            this.btnHRLogout.TabIndex = 5;
            this.btnHRLogout.UseVisualStyleBackColor = true;
            this.btnHRLogout.Click += new System.EventHandler(this.btnHRLogout_Click);
            // 
            // btnViewUpdateRequests
            // 
            this.btnViewUpdateRequests.Location = new System.Drawing.Point(1270, 190);
            this.btnViewUpdateRequests.Name = "btnViewUpdateRequests";
            this.btnViewUpdateRequests.Size = new System.Drawing.Size(243, 158);
            this.btnViewUpdateRequests.TabIndex = 6;
            this.btnViewUpdateRequests.Text = "View Update Requests";
            this.btnViewUpdateRequests.UseVisualStyleBackColor = true;
            this.btnViewUpdateRequests.Click += new System.EventHandler(this.btnViewUpdateRequests_Click);
            // 
            // FrmHRLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 569);
            this.Controls.Add(this.btnViewUpdateRequests);
            this.Controls.Add(this.btnHRLogout);
            this.Controls.Add(this.btnBackFromHRLanding);
            this.Controls.Add(this.btnViewAnalytics);
            this.Controls.Add(this.btnCreateEmployeeRecord);
            this.Controls.Add(this.btnViewEmployeeRecords);
            this.Controls.Add(this.lblHRLandingPage);
            this.Name = "FrmHRLandingPage";
            this.Text = "Welcome to the HR Manager Portal!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHRLandingPage;
        private System.Windows.Forms.Button btnViewEmployeeRecords;
        private System.Windows.Forms.Button btnCreateEmployeeRecord;
        private System.Windows.Forms.Button btnViewAnalytics;
        private System.Windows.Forms.Button btnBackFromHRLanding;
        private System.Windows.Forms.Button btnHRLogout;
        private System.Windows.Forms.Button btnViewUpdateRequests;
    }
}