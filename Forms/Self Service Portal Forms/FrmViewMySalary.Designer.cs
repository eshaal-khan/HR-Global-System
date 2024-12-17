namespace HR_Global_System.Forms.Self_Service_Portal_Forms
{
    partial class FrmViewMySalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewMySalary));
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.btnBackFromViewSalary = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMonthlySalary
            // 
            this.lblMonthlySalary.AutoSize = true;
            this.lblMonthlySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlySalary.Location = new System.Drawing.Point(12, 18);
            this.lblMonthlySalary.Name = "lblMonthlySalary";
            this.lblMonthlySalary.Size = new System.Drawing.Size(1143, 36);
            this.lblMonthlySalary.TabIndex = 0;
            this.lblMonthlySalary.Text = "Your current salary per month after tax (in line with your country\'s tax brackets" +
    "):";
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.Location = new System.Drawing.Point(18, 77);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.ReadOnly = true;
            this.txtMonthlySalary.Size = new System.Drawing.Size(532, 38);
            this.txtMonthlySalary.TabIndex = 1;
            // 
            // btnBackFromViewSalary
            // 
            this.btnBackFromViewSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFromViewSalary.Image = ((System.Drawing.Image)(resources.GetObject("btnBackFromViewSalary.Image")));
            this.btnBackFromViewSalary.Location = new System.Drawing.Point(1030, 285);
            this.btnBackFromViewSalary.Name = "btnBackFromViewSalary";
            this.btnBackFromViewSalary.Size = new System.Drawing.Size(125, 128);
            this.btnBackFromViewSalary.TabIndex = 18;
            this.btnBackFromViewSalary.UseVisualStyleBackColor = true;
            this.btnBackFromViewSalary.Click += new System.EventHandler(this.btnBackFromViewSalary_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(22, 164);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(92, 32);
            this.lblNote.TabIndex = 19;
            this.lblNote.Text = "label1";
            // 
            // FrmViewMySalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 592);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnBackFromViewSalary);
            this.Controls.Add(this.txtMonthlySalary);
            this.Controls.Add(this.lblMonthlySalary);
            this.Name = "FrmViewMySalary";
            this.Text = "FrmViewMySalary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonthlySalary;
        private System.Windows.Forms.TextBox txtMonthlySalary;
        private System.Windows.Forms.Button btnBackFromViewSalary;
        private System.Windows.Forms.Label lblNote;
    }
}