namespace HR_Global_System.Forms.HR_Portal_Forms
{
    partial class FrmHRViewLeaveRequests
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
            this.lblViewLeaveRequests = new System.Windows.Forms.Label();
            this.dgvViewLeaveRequests = new System.Windows.Forms.DataGridView();
            this.cmsSelectLeaveRequestRecord = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewLeaveRequests)).BeginInit();
            this.cmsSelectLeaveRequestRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblViewLeaveRequests
            // 
            this.lblViewLeaveRequests.AutoSize = true;
            this.lblViewLeaveRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewLeaveRequests.Location = new System.Drawing.Point(27, 32);
            this.lblViewLeaveRequests.Name = "lblViewLeaveRequests";
            this.lblViewLeaveRequests.Size = new System.Drawing.Size(1650, 65);
            this.lblViewLeaveRequests.TabIndex = 3;
            this.lblViewLeaveRequests.Text = "View leave requests sent by employees in your country here:";
            // 
            // dgvViewLeaveRequests
            // 
            this.dgvViewLeaveRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewLeaveRequests.ContextMenuStrip = this.cmsSelectLeaveRequestRecord;
            this.dgvViewLeaveRequests.Location = new System.Drawing.Point(22, 95);
            this.dgvViewLeaveRequests.Name = "dgvViewLeaveRequests";
            this.dgvViewLeaveRequests.RowHeadersWidth = 102;
            this.dgvViewLeaveRequests.RowTemplate.Height = 40;
            this.dgvViewLeaveRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewLeaveRequests.Size = new System.Drawing.Size(1369, 660);
            this.dgvViewLeaveRequests.TabIndex = 2;
            // 
            // cmsSelectLeaveRequestRecord
            // 
            this.cmsSelectLeaveRequestRecord.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsSelectLeaveRequestRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.cmsSelectLeaveRequestRecord.Name = "cmsSelectLeaveRequestRecord";
            this.cmsSelectLeaveRequestRecord.Size = new System.Drawing.Size(361, 107);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(360, 48);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // FrmHRViewLeaveRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 1286);
            this.Controls.Add(this.lblViewLeaveRequests);
            this.Controls.Add(this.dgvViewLeaveRequests);
            this.Name = "FrmHRViewLeaveRequests";
            this.Text = "FrmHRViewLeaveRequests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewLeaveRequests)).EndInit();
            this.cmsSelectLeaveRequestRecord.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewLeaveRequests;
        private System.Windows.Forms.DataGridView dgvViewLeaveRequests;
        private System.Windows.Forms.ContextMenuStrip cmsSelectLeaveRequestRecord;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}