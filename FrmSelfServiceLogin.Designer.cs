namespace HR_Global_System
{
    partial class FrmSelfServiceLogin
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
            this.lblSelfServiceUsername = new System.Windows.Forms.Label();
            this.lblSelfServicePassword = new System.Windows.Forms.Label();
            this.txtSelfServiceUsername = new System.Windows.Forms.TextBox();
            this.txtSelfServicePassword = new System.Windows.Forms.TextBox();
            this.btnSelfServiceSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelfServiceUsername
            // 
            this.lblSelfServiceUsername.AutoSize = true;
            this.lblSelfServiceUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelfServiceUsername.Location = new System.Drawing.Point(12, 28);
            this.lblSelfServiceUsername.Name = "lblSelfServiceUsername";
            this.lblSelfServiceUsername.Size = new System.Drawing.Size(573, 49);
            this.lblSelfServiceUsername.TabIndex = 0;
            this.lblSelfServiceUsername.Text = "Username (employee ID):";
            // 
            // lblSelfServicePassword
            // 
            this.lblSelfServicePassword.AutoSize = true;
            this.lblSelfServicePassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelfServicePassword.Location = new System.Drawing.Point(12, 132);
            this.lblSelfServicePassword.Name = "lblSelfServicePassword";
            this.lblSelfServicePassword.Size = new System.Drawing.Size(238, 49);
            this.lblSelfServicePassword.TabIndex = 1;
            this.lblSelfServicePassword.Text = "Password:";
            // 
            // txtSelfServiceUsername
            // 
            this.txtSelfServiceUsername.Location = new System.Drawing.Point(591, 39);
            this.txtSelfServiceUsername.Name = "txtSelfServiceUsername";
            this.txtSelfServiceUsername.Size = new System.Drawing.Size(345, 38);
            this.txtSelfServiceUsername.TabIndex = 2;
            // 
            // txtSelfServicePassword
            // 
            this.txtSelfServicePassword.Location = new System.Drawing.Point(271, 143);
            this.txtSelfServicePassword.Name = "txtSelfServicePassword";
            this.txtSelfServicePassword.Size = new System.Drawing.Size(450, 38);
            this.txtSelfServicePassword.TabIndex = 3;
            this.txtSelfServicePassword.UseSystemPasswordChar = true;
            // 
            // btnSelfServiceSignIn
            // 
            this.btnSelfServiceSignIn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelfServiceSignIn.Location = new System.Drawing.Point(861, 281);
            this.btnSelfServiceSignIn.Name = "btnSelfServiceSignIn";
            this.btnSelfServiceSignIn.Size = new System.Drawing.Size(242, 133);
            this.btnSelfServiceSignIn.TabIndex = 4;
            this.btnSelfServiceSignIn.Text = "Sign In";
            this.btnSelfServiceSignIn.UseVisualStyleBackColor = true;
            // 
            // FrmSelfServiceLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 458);
            this.Controls.Add(this.btnSelfServiceSignIn);
            this.Controls.Add(this.txtSelfServicePassword);
            this.Controls.Add(this.txtSelfServiceUsername);
            this.Controls.Add(this.lblSelfServicePassword);
            this.Controls.Add(this.lblSelfServiceUsername);
            this.Name = "FrmSelfServiceLogin";
            this.Text = "Employee Self Service Portal Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelfServiceUsername;
        private System.Windows.Forms.Label lblSelfServicePassword;
        private System.Windows.Forms.TextBox txtSelfServiceUsername;
        private System.Windows.Forms.TextBox txtSelfServicePassword;
        private System.Windows.Forms.Button btnSelfServiceSignIn;
    }
}