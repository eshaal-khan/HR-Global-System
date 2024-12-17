namespace HR_Global_System.Forms.HR_Portal_Forms
{
    partial class FrmSubmitLeaveRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubmitLeaveRequest));
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTill = new System.Windows.Forms.DateTimePicker();
            this.lblDateTill = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxLeaveStatus = new System.Windows.Forms.ComboBox();
            this.cbxLeaveReason = new System.Windows.Forms.ComboBox();
            this.lblSubmitLeave = new System.Windows.Forms.Label();
            this.btnSubmitLeaveRequest = new System.Windows.Forms.Button();
            this.rtxtAdditionalNotes = new System.Windows.Forms.RichTextBox();
            this.lblAdditionalInfo = new System.Windows.Forms.Label();
            this.btnBackFromHRLanding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(24, 104);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(389, 36);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Date your leave will begin:";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(415, 104);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(352, 38);
            this.dtpDateFrom.TabIndex = 1;
            // 
            // dtpDateTill
            // 
            this.dtpDateTill.Location = new System.Drawing.Point(415, 195);
            this.dtpDateTill.Name = "dtpDateTill";
            this.dtpDateTill.Size = new System.Drawing.Size(352, 38);
            this.dtpDateTill.TabIndex = 3;
            // 
            // lblDateTill
            // 
            this.lblDateTill.AutoSize = true;
            this.lblDateTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTill.Location = new System.Drawing.Point(24, 198);
            this.lblDateTill.Name = "lblDateTill";
            this.lblDateTill.Size = new System.Drawing.Size(352, 36);
            this.lblDateTill.TabIndex = 2;
            this.lblDateTill.Text = "Date you leave will end:";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(23, 300);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(253, 36);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "Reason of leave:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(23, 416);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(114, 36);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // cbxLeaveStatus
            // 
            this.cbxLeaveStatus.FormattingEnabled = true;
            this.cbxLeaveStatus.Items.AddRange(new object[] {
            "Submitted"});
            this.cbxLeaveStatus.Location = new System.Drawing.Point(415, 416);
            this.cbxLeaveStatus.Name = "cbxLeaveStatus";
            this.cbxLeaveStatus.Size = new System.Drawing.Size(352, 39);
            this.cbxLeaveStatus.TabIndex = 6;
            // 
            // cbxLeaveReason
            // 
            this.cbxLeaveReason.FormattingEnabled = true;
            this.cbxLeaveReason.Items.AddRange(new object[] {
            "Annual Leave (using allowance)",
            "Bereavement/compassionate leave",
            "Jury duty "});
            this.cbxLeaveReason.Location = new System.Drawing.Point(415, 300);
            this.cbxLeaveReason.Name = "cbxLeaveReason";
            this.cbxLeaveReason.Size = new System.Drawing.Size(352, 39);
            this.cbxLeaveReason.TabIndex = 8;
            // 
            // lblSubmitLeave
            // 
            this.lblSubmitLeave.AutoSize = true;
            this.lblSubmitLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitLeave.Location = new System.Drawing.Point(23, 26);
            this.lblSubmitLeave.Name = "lblSubmitLeave";
            this.lblSubmitLeave.Size = new System.Drawing.Size(980, 39);
            this.lblSubmitLeave.TabIndex = 9;
            this.lblSubmitLeave.Text = "Submit your leave request to your HR Manager for approval:";
            // 
            // btnSubmitLeaveRequest
            // 
            this.btnSubmitLeaveRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitLeaveRequest.Location = new System.Drawing.Point(818, 661);
            this.btnSubmitLeaveRequest.Name = "btnSubmitLeaveRequest";
            this.btnSubmitLeaveRequest.Size = new System.Drawing.Size(275, 214);
            this.btnSubmitLeaveRequest.TabIndex = 10;
            this.btnSubmitLeaveRequest.Text = "Submit leave request";
            this.btnSubmitLeaveRequest.UseVisualStyleBackColor = true;
            this.btnSubmitLeaveRequest.Click += new System.EventHandler(this.btnSubmitLeaveRequest_Click);
            // 
            // rtxtAdditionalNotes
            // 
            this.rtxtAdditionalNotes.Location = new System.Drawing.Point(415, 506);
            this.rtxtAdditionalNotes.Name = "rtxtAdditionalNotes";
            this.rtxtAdditionalNotes.Size = new System.Drawing.Size(352, 369);
            this.rtxtAdditionalNotes.TabIndex = 11;
            this.rtxtAdditionalNotes.Text = "";
            // 
            // lblAdditionalInfo
            // 
            this.lblAdditionalInfo.AutoSize = true;
            this.lblAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalInfo.Location = new System.Drawing.Point(24, 533);
            this.lblAdditionalInfo.Name = "lblAdditionalInfo";
            this.lblAdditionalInfo.Size = new System.Drawing.Size(357, 36);
            this.lblAdditionalInfo.TabIndex = 12;
            this.lblAdditionalInfo.Text = "Additional details/notes:";
            // 
            // btnBackFromHRLanding
            // 
            this.btnBackFromHRLanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFromHRLanding.Image = ((System.Drawing.Image)(resources.GetObject("btnBackFromHRLanding.Image")));
            this.btnBackFromHRLanding.Location = new System.Drawing.Point(1061, 14);
            this.btnBackFromHRLanding.Name = "btnBackFromHRLanding";
            this.btnBackFromHRLanding.Size = new System.Drawing.Size(125, 128);
            this.btnBackFromHRLanding.TabIndex = 13;
            this.btnBackFromHRLanding.UseVisualStyleBackColor = true;
            this.btnBackFromHRLanding.Click += new System.EventHandler(this.btnBackFromHRLanding_Click);
            // 
            // FrmSubmitLeaveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1911, 1275);
            this.Controls.Add(this.btnBackFromHRLanding);
            this.Controls.Add(this.lblAdditionalInfo);
            this.Controls.Add(this.rtxtAdditionalNotes);
            this.Controls.Add(this.btnSubmitLeaveRequest);
            this.Controls.Add(this.lblSubmitLeave);
            this.Controls.Add(this.cbxLeaveReason);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbxLeaveStatus);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.dtpDateTill);
            this.Controls.Add(this.lblDateTill);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Name = "FrmSubmitLeaveRequest";
            this.Text = "FrmSubmitLeaveRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTill;
        private System.Windows.Forms.Label lblDateTill;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxLeaveStatus;
        private System.Windows.Forms.ComboBox cbxLeaveReason;
        private System.Windows.Forms.Label lblSubmitLeave;
        private System.Windows.Forms.Button btnSubmitLeaveRequest;
        private System.Windows.Forms.RichTextBox rtxtAdditionalNotes;
        private System.Windows.Forms.Label lblAdditionalInfo;
        private System.Windows.Forms.Button btnBackFromHRLanding;
    }
}