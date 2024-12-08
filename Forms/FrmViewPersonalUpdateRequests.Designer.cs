namespace HR_Global_System.Forms
{
    partial class FrmViewPersonalUpdateRequests
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
            this.dgvViewMyRequests = new System.Windows.Forms.DataGridView();
            this.lblPersonalUpdateRequests = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMyRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewMyRequests
            // 
            this.dgvViewMyRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewMyRequests.Location = new System.Drawing.Point(25, 112);
            this.dgvViewMyRequests.Name = "dgvViewMyRequests";
            this.dgvViewMyRequests.RowHeadersWidth = 102;
            this.dgvViewMyRequests.RowTemplate.Height = 40;
            this.dgvViewMyRequests.Size = new System.Drawing.Size(1315, 243);
            this.dgvViewMyRequests.TabIndex = 9;
            // 
            // lblPersonalUpdateRequests
            // 
            this.lblPersonalUpdateRequests.AutoSize = true;
            this.lblPersonalUpdateRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalUpdateRequests.Location = new System.Drawing.Point(19, 52);
            this.lblPersonalUpdateRequests.Name = "lblPersonalUpdateRequests";
            this.lblPersonalUpdateRequests.Size = new System.Drawing.Size(668, 36);
            this.lblPersonalUpdateRequests.TabIndex = 8;
            this.lblPersonalUpdateRequests.Text = "View all update requests you have made here:";
            // 
            // FrmViewPersonalUpdateRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 966);
            this.Controls.Add(this.dgvViewMyRequests);
            this.Controls.Add(this.lblPersonalUpdateRequests);
            this.Name = "FrmViewPersonalUpdateRequests";
            this.Text = "FrmViewPersonalUpdateRequests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMyRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewMyRequests;
        private System.Windows.Forms.Label lblPersonalUpdateRequests;
    }
}