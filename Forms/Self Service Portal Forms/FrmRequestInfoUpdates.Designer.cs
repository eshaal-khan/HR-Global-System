namespace HR_Global_System.Forms
{
    partial class FrmRequestInfoUpdates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequestInfoUpdates));
            this.lblRequestUpdate = new System.Windows.Forms.Label();
            this.lblUpdateRequestDetails = new System.Windows.Forms.Label();
            this.rtxtRequestDetails = new System.Windows.Forms.RichTextBox();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.lblUpdateRequestTitle = new System.Windows.Forms.Label();
            this.txtRequestTitle = new System.Windows.Forms.TextBox();
            this.btnBackFromPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRequestUpdate
            // 
            this.lblRequestUpdate.AutoSize = true;
            this.lblRequestUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestUpdate.Location = new System.Drawing.Point(12, 36);
            this.lblRequestUpdate.Name = "lblRequestUpdate";
            this.lblRequestUpdate.Size = new System.Drawing.Size(1322, 39);
            this.lblRequestUpdate.TabIndex = 0;
            this.lblRequestUpdate.Text = "Use this form to submit any requests to change your current data to your HR lead:" +
    "";
            // 
            // lblUpdateRequestDetails
            // 
            this.lblUpdateRequestDetails.AutoSize = true;
            this.lblUpdateRequestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRequestDetails.Location = new System.Drawing.Point(13, 232);
            this.lblUpdateRequestDetails.Name = "lblUpdateRequestDetails";
            this.lblUpdateRequestDetails.Size = new System.Drawing.Size(519, 36);
            this.lblUpdateRequestDetails.TabIndex = 1;
            this.lblUpdateRequestDetails.Text = "Explain the desired changes below:";
            // 
            // rtxtRequestDetails
            // 
            this.rtxtRequestDetails.Location = new System.Drawing.Point(19, 285);
            this.rtxtRequestDetails.Name = "rtxtRequestDetails";
            this.rtxtRequestDetails.Size = new System.Drawing.Size(1315, 362);
            this.rtxtRequestDetails.TabIndex = 2;
            this.rtxtRequestDetails.Text = "";
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(19, 689);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(296, 79);
            this.btnSendRequest.TabIndex = 3;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // lblUpdateRequestTitle
            // 
            this.lblUpdateRequestTitle.AutoSize = true;
            this.lblUpdateRequestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRequestTitle.Location = new System.Drawing.Point(13, 149);
            this.lblUpdateRequestTitle.Name = "lblUpdateRequestTitle";
            this.lblUpdateRequestTitle.Size = new System.Drawing.Size(342, 36);
            this.lblUpdateRequestTitle.TabIndex = 4;
            this.lblUpdateRequestTitle.Text = "Title of update request:";
            // 
            // txtRequestTitle
            // 
            this.txtRequestTitle.Location = new System.Drawing.Point(361, 149);
            this.txtRequestTitle.Name = "txtRequestTitle";
            this.txtRequestTitle.Size = new System.Drawing.Size(973, 38);
            this.txtRequestTitle.TabIndex = 5;
            // 
            // btnBackFromPage
            // 
            this.btnBackFromPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFromPage.Image = ((System.Drawing.Image)(resources.GetObject("btnBackFromPage.Image")));
            this.btnBackFromPage.Location = new System.Drawing.Point(1431, 27);
            this.btnBackFromPage.Name = "btnBackFromPage";
            this.btnBackFromPage.Size = new System.Drawing.Size(125, 128);
            this.btnBackFromPage.TabIndex = 6;
            this.btnBackFromPage.UseVisualStyleBackColor = true;
            this.btnBackFromPage.Click += new System.EventHandler(this.btnBackFromPage_Click);
            // 
            // FrmRequestInfoUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 837);
            this.Controls.Add(this.btnBackFromPage);
            this.Controls.Add(this.txtRequestTitle);
            this.Controls.Add(this.lblUpdateRequestTitle);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.rtxtRequestDetails);
            this.Controls.Add(this.lblUpdateRequestDetails);
            this.Controls.Add(this.lblRequestUpdate);
            this.Name = "FrmRequestInfoUpdates";
            this.Text = "FrmRequestInfoUpdates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestUpdate;
        private System.Windows.Forms.Label lblUpdateRequestDetails;
        private System.Windows.Forms.RichTextBox rtxtRequestDetails;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Label lblUpdateRequestTitle;
        private System.Windows.Forms.TextBox txtRequestTitle;
        private System.Windows.Forms.Button btnBackFromPage;
    }
}