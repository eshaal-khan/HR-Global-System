namespace HR_Global_System.Forms.HR_Portal_Forms
{
    partial class FrmHRViewSelectedLeaveRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHRViewSelectedLeaveRequest));
            this.lblViewRequest = new System.Windows.Forms.Label();
            this.btnSaveStatusChange = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblRequestStatus = new System.Windows.Forms.Label();
            this.rtxtAdditionalNotes = new System.Windows.Forms.RichTextBox();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblViewRequest
            // 
            this.lblViewRequest.AutoSize = true;
            this.lblViewRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewRequest.Location = new System.Drawing.Point(25, 35);
            this.lblViewRequest.Name = "lblViewRequest";
            this.lblViewRequest.Size = new System.Drawing.Size(720, 39);
            this.lblViewRequest.TabIndex = 23;
            this.lblViewRequest.Text = "View Details for the selected request below:";
            // 
            // btnSaveStatusChange
            // 
            this.btnSaveStatusChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStatusChange.Location = new System.Drawing.Point(633, 848);
            this.btnSaveStatusChange.Name = "btnSaveStatusChange";
            this.btnSaveStatusChange.Size = new System.Drawing.Size(389, 87);
            this.btnSaveStatusChange.TabIndex = 22;
            this.btnSaveStatusChange.Text = "Save Changes";
            this.btnSaveStatusChange.UseVisualStyleBackColor = true;
            this.btnSaveStatusChange.Click += new System.EventHandler(this.btnSaveStatusChange_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Submitted",
            "Approved",
            "Rejected"});
            this.cbxStatus.Location = new System.Drawing.Point(290, 858);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(324, 39);
            this.cbxStatus.TabIndex = 21;
            // 
            // lblRequestStatus
            // 
            this.lblRequestStatus.AutoSize = true;
            this.lblRequestStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestStatus.Location = new System.Drawing.Point(26, 855);
            this.lblRequestStatus.Name = "lblRequestStatus";
            this.lblRequestStatus.Size = new System.Drawing.Size(241, 36);
            this.lblRequestStatus.TabIndex = 20;
            this.lblRequestStatus.Text = "Request Status:";
            // 
            // rtxtAdditionalNotes
            // 
            this.rtxtAdditionalNotes.Location = new System.Drawing.Point(290, 365);
            this.rtxtAdditionalNotes.Name = "rtxtAdditionalNotes";
            this.rtxtAdditionalNotes.Size = new System.Drawing.Size(1022, 449);
            this.rtxtAdditionalNotes.TabIndex = 19;
            this.rtxtAdditionalNotes.Text = "";
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalNotes.Location = new System.Drawing.Point(26, 365);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(260, 36);
            this.lblAdditionalNotes.TabIndex = 18;
            this.lblAdditionalNotes.Text = "Additional Notes:";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(290, 223);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(324, 38);
            this.txtEndDate.TabIndex = 17;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(26, 220);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(264, 36);
            this.lblEndDate.TabIndex = 16;
            this.lblEndDate.Text = "Last day of leave:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(290, 153);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(324, 38);
            this.txtStartDate.TabIndex = 15;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(290, 109);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(324, 38);
            this.txtEmpID.TabIndex = 14;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(26, 150);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(267, 36);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "First day of leave:";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(26, 95);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(203, 36);
            this.lblEmpID.TabIndex = 12;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(290, 292);
            this.txtReason.Name = "txtReason";
            this.txtReason.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(324, 38);
            this.txtReason.TabIndex = 25;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(26, 289);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(219, 36);
            this.lblReason.TabIndex = 24;
            this.lblReason.Text = "Reason given:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(1431, 48);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 128);
            this.btnBack.TabIndex = 26;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmHRViewSelectedLeaveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1225);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblViewRequest);
            this.Controls.Add(this.btnSaveStatusChange);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.lblRequestStatus);
            this.Controls.Add(this.rtxtAdditionalNotes);
            this.Controls.Add(this.lblAdditionalNotes);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEmpID);
            this.Name = "FrmHRViewSelectedLeaveRequest";
            this.Text = "FrmHRViewSelectedLeaveRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewRequest;
        private System.Windows.Forms.Button btnSaveStatusChange;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblRequestStatus;
        private System.Windows.Forms.RichTextBox rtxtAdditionalNotes;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Button btnBack;
    }
}