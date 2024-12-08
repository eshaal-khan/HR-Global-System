namespace HR_Global_System
{
    partial class FrmViewEmployeeRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewEmployeeRecords));
            this.dgvAllEmployeeRecords = new System.Windows.Forms.DataGridView();
            this.cmsManageEmployeeRecords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblManageEmployeeRecords = new System.Windows.Forms.Label();
            this.btnBackFromViewEmpRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEmployeeRecords)).BeginInit();
            this.cmsManageEmployeeRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllEmployeeRecords
            // 
            this.dgvAllEmployeeRecords.AllowUserToOrderColumns = true;
            this.dgvAllEmployeeRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllEmployeeRecords.ContextMenuStrip = this.cmsManageEmployeeRecords;
            this.dgvAllEmployeeRecords.Location = new System.Drawing.Point(12, 146);
            this.dgvAllEmployeeRecords.Name = "dgvAllEmployeeRecords";
            this.dgvAllEmployeeRecords.RowHeadersWidth = 102;
            this.dgvAllEmployeeRecords.RowTemplate.Height = 40;
            this.dgvAllEmployeeRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllEmployeeRecords.Size = new System.Drawing.Size(1986, 1035);
            this.dgvAllEmployeeRecords.TabIndex = 4;
            // 
            // cmsManageEmployeeRecords
            // 
            this.cmsManageEmployeeRecords.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsManageEmployeeRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsManageEmployeeRecords.Name = "cmsManageEmployeeRecords";
            this.cmsManageEmployeeRecords.Size = new System.Drawing.Size(183, 100);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(182, 48);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(182, 48);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lblManageEmployeeRecords
            // 
            this.lblManageEmployeeRecords.AutoSize = true;
            this.lblManageEmployeeRecords.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEmployeeRecords.Location = new System.Drawing.Point(28, 29);
            this.lblManageEmployeeRecords.Name = "lblManageEmployeeRecords";
            this.lblManageEmployeeRecords.Size = new System.Drawing.Size(1244, 49);
            this.lblManageEmployeeRecords.TabIndex = 2;
            this.lblManageEmployeeRecords.Text = "Manage Employee Records for your Country\'s Employees:";
            // 
            // btnBackFromViewEmpRecords
            // 
            this.btnBackFromViewEmpRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFromViewEmpRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnBackFromViewEmpRecords.Image")));
            this.btnBackFromViewEmpRecords.Location = new System.Drawing.Point(1873, 12);
            this.btnBackFromViewEmpRecords.Name = "btnBackFromViewEmpRecords";
            this.btnBackFromViewEmpRecords.Size = new System.Drawing.Size(125, 128);
            this.btnBackFromViewEmpRecords.TabIndex = 5;
            this.btnBackFromViewEmpRecords.UseVisualStyleBackColor = true;
            this.btnBackFromViewEmpRecords.Click += new System.EventHandler(this.btnBackFromViewEmpRecords_Click);
            // 
            // FrmViewEmployeeRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2024, 1209);
            this.Controls.Add(this.btnBackFromViewEmpRecords);
            this.Controls.Add(this.lblManageEmployeeRecords);
            this.Controls.Add(this.dgvAllEmployeeRecords);
            this.Name = "FrmViewEmployeeRecords";
            this.Text = "FrmViewEmployeeRecords";
            this.Load += new System.EventHandler(this.FrmViewEmployeeRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEmployeeRecords)).EndInit();
            this.cmsManageEmployeeRecords.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllEmployeeRecords;
        private System.Windows.Forms.ContextMenuStrip cmsManageEmployeeRecords;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label lblManageEmployeeRecords;
        private System.Windows.Forms.Button btnBackFromViewEmpRecords;
    }
}