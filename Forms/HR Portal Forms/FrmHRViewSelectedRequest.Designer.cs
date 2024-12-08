namespace HR_Global_System.Forms
{
    partial class FrmHRViewSelectedRequest
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
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblSubmissionDate = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtSubmissionDate = new System.Windows.Forms.TextBox();
            this.txtRequestTitle = new System.Windows.Forms.TextBox();
            this.lblRequestTitle = new System.Windows.Forms.Label();
            this.lblRequestDetails = new System.Windows.Forms.Label();
            this.rtxtRequestDetails = new System.Windows.Forms.RichTextBox();
            this.lblRequestStatus = new System.Windows.Forms.Label();
            this.cbxRequestStatus = new System.Windows.Forms.ComboBox();
            this.btnSaveStatusChange = new System.Windows.Forms.Button();
            this.lblViewRequest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(21, 85);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(203, 36);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // lblSubmissionDate
            // 
            this.lblSubmissionDate.AutoSize = true;
            this.lblSubmissionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmissionDate.Location = new System.Drawing.Point(21, 140);
            this.lblSubmissionDate.Name = "lblSubmissionDate";
            this.lblSubmissionDate.Size = new System.Drawing.Size(263, 36);
            this.lblSubmissionDate.TabIndex = 1;
            this.lblSubmissionDate.Text = "Submission Date:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(285, 99);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(324, 38);
            this.txtEmpID.TabIndex = 2;
            // 
            // txtSubmissionDate
            // 
            this.txtSubmissionDate.Location = new System.Drawing.Point(285, 143);
            this.txtSubmissionDate.Name = "txtSubmissionDate";
            this.txtSubmissionDate.ReadOnly = true;
            this.txtSubmissionDate.Size = new System.Drawing.Size(324, 38);
            this.txtSubmissionDate.TabIndex = 3;
            // 
            // txtRequestTitle
            // 
            this.txtRequestTitle.Location = new System.Drawing.Point(285, 213);
            this.txtRequestTitle.Name = "txtRequestTitle";
            this.txtRequestTitle.ReadOnly = true;
            this.txtRequestTitle.Size = new System.Drawing.Size(324, 38);
            this.txtRequestTitle.TabIndex = 5;
            // 
            // lblRequestTitle
            // 
            this.lblRequestTitle.AutoSize = true;
            this.lblRequestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestTitle.Location = new System.Drawing.Point(21, 210);
            this.lblRequestTitle.Name = "lblRequestTitle";
            this.lblRequestTitle.Size = new System.Drawing.Size(212, 36);
            this.lblRequestTitle.TabIndex = 4;
            this.lblRequestTitle.Text = "Request Title:";
            // 
            // lblRequestDetails
            // 
            this.lblRequestDetails.AutoSize = true;
            this.lblRequestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDetails.Location = new System.Drawing.Point(21, 311);
            this.lblRequestDetails.Name = "lblRequestDetails";
            this.lblRequestDetails.Size = new System.Drawing.Size(248, 36);
            this.lblRequestDetails.TabIndex = 6;
            this.lblRequestDetails.Text = "Request Details:";
            // 
            // rtxtRequestDetails
            // 
            this.rtxtRequestDetails.Location = new System.Drawing.Point(285, 311);
            this.rtxtRequestDetails.Name = "rtxtRequestDetails";
            this.rtxtRequestDetails.ReadOnly = true;
            this.rtxtRequestDetails.Size = new System.Drawing.Size(1022, 449);
            this.rtxtRequestDetails.TabIndex = 7;
            this.rtxtRequestDetails.Text = "";
            // 
            // lblRequestStatus
            // 
            this.lblRequestStatus.AutoSize = true;
            this.lblRequestStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestStatus.Location = new System.Drawing.Point(21, 801);
            this.lblRequestStatus.Name = "lblRequestStatus";
            this.lblRequestStatus.Size = new System.Drawing.Size(241, 36);
            this.lblRequestStatus.TabIndex = 8;
            this.lblRequestStatus.Text = "Request Status:";
            // 
            // cbxRequestStatus
            // 
            this.cbxRequestStatus.FormattingEnabled = true;
            this.cbxRequestStatus.Items.AddRange(new object[] {
            "Submitted",
            "Rejected",
            "Partially Actioned",
            "Actioned"});
            this.cbxRequestStatus.Location = new System.Drawing.Point(285, 804);
            this.cbxRequestStatus.Name = "cbxRequestStatus";
            this.cbxRequestStatus.Size = new System.Drawing.Size(324, 39);
            this.cbxRequestStatus.TabIndex = 9;
            // 
            // btnSaveStatusChange
            // 
            this.btnSaveStatusChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStatusChange.Location = new System.Drawing.Point(628, 794);
            this.btnSaveStatusChange.Name = "btnSaveStatusChange";
            this.btnSaveStatusChange.Size = new System.Drawing.Size(389, 87);
            this.btnSaveStatusChange.TabIndex = 10;
            this.btnSaveStatusChange.Text = "Save Status Change";
            this.btnSaveStatusChange.UseVisualStyleBackColor = true;
            this.btnSaveStatusChange.Click += new System.EventHandler(this.btnSaveStatusChange_Click);
            // 
            // lblViewRequest
            // 
            this.lblViewRequest.AutoSize = true;
            this.lblViewRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewRequest.Location = new System.Drawing.Point(20, 25);
            this.lblViewRequest.Name = "lblViewRequest";
            this.lblViewRequest.Size = new System.Drawing.Size(720, 39);
            this.lblViewRequest.TabIndex = 11;
            this.lblViewRequest.Text = "View Details for the selected request below:";
            // 
            // FrmHRViewSelectedRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 974);
            this.Controls.Add(this.lblViewRequest);
            this.Controls.Add(this.btnSaveStatusChange);
            this.Controls.Add(this.cbxRequestStatus);
            this.Controls.Add(this.lblRequestStatus);
            this.Controls.Add(this.rtxtRequestDetails);
            this.Controls.Add(this.lblRequestDetails);
            this.Controls.Add(this.txtRequestTitle);
            this.Controls.Add(this.lblRequestTitle);
            this.Controls.Add(this.txtSubmissionDate);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lblSubmissionDate);
            this.Controls.Add(this.lblEmpID);
            this.Name = "FrmHRViewSelectedRequest";
            this.Text = "FrmHRViewSelectedRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblSubmissionDate;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtSubmissionDate;
        private System.Windows.Forms.TextBox txtRequestTitle;
        private System.Windows.Forms.Label lblRequestTitle;
        private System.Windows.Forms.Label lblRequestDetails;
        private System.Windows.Forms.RichTextBox rtxtRequestDetails;
        private System.Windows.Forms.Label lblRequestStatus;
        private System.Windows.Forms.ComboBox cbxRequestStatus;
        private System.Windows.Forms.Button btnSaveStatusChange;
        private System.Windows.Forms.Label lblViewRequest;
    }
}