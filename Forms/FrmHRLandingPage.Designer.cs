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
            this.lblHRLandingPage = new System.Windows.Forms.Label();
            this.btnViewEmployeeRecords = new System.Windows.Forms.Button();
            this.btnCreateEmployeeRecord = new System.Windows.Forms.Button();
            this.btnViewAnalytics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHRLandingPage
            // 
            this.lblHRLandingPage.AutoSize = true;
            this.lblHRLandingPage.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRLandingPage.Location = new System.Drawing.Point(24, 24);
            this.lblHRLandingPage.Name = "lblHRLandingPage";
            this.lblHRLandingPage.Size = new System.Drawing.Size(976, 46);
            this.lblHRLandingPage.TabIndex = 0;
            this.lblHRLandingPage.Text = "Successful login! Navigate to the below sections:";
            // 
            // btnViewEmployeeRecords
            // 
            this.btnViewEmployeeRecords.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmployeeRecords.Location = new System.Drawing.Point(32, 113);
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
            this.btnCreateEmployeeRecord.Location = new System.Drawing.Point(972, 113);
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
            this.btnViewAnalytics.Location = new System.Drawing.Point(484, 113);
            this.btnViewAnalytics.Name = "btnViewAnalytics";
            this.btnViewAnalytics.Size = new System.Drawing.Size(276, 195);
            this.btnViewAnalytics.TabIndex = 3;
            this.btnViewAnalytics.Text = "View Analytics";
            this.btnViewAnalytics.UseVisualStyleBackColor = true;
            this.btnViewAnalytics.Click += new System.EventHandler(this.btnViewAnalytics_Click);
            // 
            // FrmHRLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 569);
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
    }
}