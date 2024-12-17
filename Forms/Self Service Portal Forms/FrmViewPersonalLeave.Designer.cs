namespace HR_Global_System.Forms.Self_Service_Portal_Forms
{
    partial class FrmViewPersonalLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewPersonalLeave));
            this.dgvViewMyLeave = new System.Windows.Forms.DataGridView();
            this.lblViewPersonalLeave = new System.Windows.Forms.Label();
            this.btnBackToPreviousPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMyLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewMyLeave
            // 
            this.dgvViewMyLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewMyLeave.Location = new System.Drawing.Point(26, 100);
            this.dgvViewMyLeave.Name = "dgvViewMyLeave";
            this.dgvViewMyLeave.RowHeadersWidth = 102;
            this.dgvViewMyLeave.RowTemplate.Height = 40;
            this.dgvViewMyLeave.Size = new System.Drawing.Size(1535, 631);
            this.dgvViewMyLeave.TabIndex = 11;
            // 
            // lblViewPersonalLeave
            // 
            this.lblViewPersonalLeave.AutoSize = true;
            this.lblViewPersonalLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPersonalLeave.Location = new System.Drawing.Point(20, 40);
            this.lblViewPersonalLeave.Name = "lblViewPersonalLeave";
            this.lblViewPersonalLeave.Size = new System.Drawing.Size(561, 39);
            this.lblViewPersonalLeave.TabIndex = 10;
            this.lblViewPersonalLeave.Text = "View all your leave requests here:";
            // 
            // btnBackToPreviousPage
            // 
            this.btnBackToPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToPreviousPage.Image")));
            this.btnBackToPreviousPage.Location = new System.Drawing.Point(1605, 100);
            this.btnBackToPreviousPage.Name = "btnBackToPreviousPage";
            this.btnBackToPreviousPage.Size = new System.Drawing.Size(125, 128);
            this.btnBackToPreviousPage.TabIndex = 12;
            this.btnBackToPreviousPage.UseVisualStyleBackColor = true;
            this.btnBackToPreviousPage.Click += new System.EventHandler(this.btnBackToPreviousPage_Click);
            // 
            // FrmViewPersonalLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1303);
            this.Controls.Add(this.btnBackToPreviousPage);
            this.Controls.Add(this.dgvViewMyLeave);
            this.Controls.Add(this.lblViewPersonalLeave);
            this.Name = "FrmViewPersonalLeave";
            this.Text = "FrmViewPersonalLeave";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMyLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewMyLeave;
        private System.Windows.Forms.Label lblViewPersonalLeave;
        private System.Windows.Forms.Button btnBackToPreviousPage;
    }
}