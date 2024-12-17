namespace HR_Global_System.Forms
{
    partial class FrmHRViewUpdateRequests
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHRViewUpdateRequests));
            this.dgvViewRequests = new System.Windows.Forms.DataGridView();
            this.cmsViewRequestRecord = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblViewRequests = new System.Windows.Forms.Label();
            this.btnBackToHRLanding = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRequests)).BeginInit();
            this.cmsViewRequestRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewRequests
            // 
            this.dgvViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewRequests.ContextMenuStrip = this.cmsViewRequestRecord;
            this.dgvViewRequests.Location = new System.Drawing.Point(27, 86);
            this.dgvViewRequests.Name = "dgvViewRequests";
            this.dgvViewRequests.RowHeadersWidth = 102;
            this.dgvViewRequests.RowTemplate.Height = 40;
            this.dgvViewRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewRequests.Size = new System.Drawing.Size(1369, 660);
            this.dgvViewRequests.TabIndex = 0;
            // 
            // cmsViewRequestRecord
            // 
            this.cmsViewRequestRecord.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsViewRequestRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.cmsViewRequestRecord.Name = "cmsViewRequestRecord";
            this.cmsViewRequestRecord.Size = new System.Drawing.Size(161, 52);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(160, 48);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // lblViewRequests
            // 
            this.lblViewRequests.AutoSize = true;
            this.lblViewRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewRequests.Location = new System.Drawing.Point(32, 23);
            this.lblViewRequests.Name = "lblViewRequests";
            this.lblViewRequests.Size = new System.Drawing.Size(893, 39);
            this.lblViewRequests.TabIndex = 1;
            this.lblViewRequests.Text = "View requests sent by employees in your country here:";
            // 
            // btnBackToHRLanding
            // 
            this.btnBackToHRLanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHRLanding.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToHRLanding.Image")));
            this.btnBackToHRLanding.Location = new System.Drawing.Point(1444, 86);
            this.btnBackToHRLanding.Name = "btnBackToHRLanding";
            this.btnBackToHRLanding.Size = new System.Drawing.Size(125, 128);
            this.btnBackToHRLanding.TabIndex = 5;
            this.btnBackToHRLanding.UseVisualStyleBackColor = true;
            this.btnBackToHRLanding.Click += new System.EventHandler(this.btnBackToHRLanding_Click);
            // 
            // FrmHRViewUpdateRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 833);
            this.Controls.Add(this.btnBackToHRLanding);
            this.Controls.Add(this.lblViewRequests);
            this.Controls.Add(this.dgvViewRequests);
            this.Name = "FrmHRViewUpdateRequests";
            this.Text = "FrmHRViewUpdateRequests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRequests)).EndInit();
            this.cmsViewRequestRecord.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewRequests;
        private System.Windows.Forms.Label lblViewRequests;
        private System.Windows.Forms.ContextMenuStrip cmsViewRequestRecord;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button btnBackToHRLanding;
    }
}