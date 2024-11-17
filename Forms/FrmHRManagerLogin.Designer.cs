namespace HR_Global_System
{
    partial class FrmHRManagerLogin
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
            this.lblHRUsername = new System.Windows.Forms.Label();
            this.lblHRPassword = new System.Windows.Forms.Label();
            this.txtHRUsername = new System.Windows.Forms.TextBox();
            this.txtHRPassword = new System.Windows.Forms.TextBox();
            this.btnHRManagerSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHRUsername
            // 
            this.lblHRUsername.AutoSize = true;
            this.lblHRUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRUsername.Location = new System.Drawing.Point(12, 27);
            this.lblHRUsername.Name = "lblHRUsername";
            this.lblHRUsername.Size = new System.Drawing.Size(573, 49);
            this.lblHRUsername.TabIndex = 0;
            this.lblHRUsername.Text = "Username (employee ID):";
            // 
            // lblHRPassword
            // 
            this.lblHRPassword.AutoSize = true;
            this.lblHRPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRPassword.Location = new System.Drawing.Point(12, 97);
            this.lblHRPassword.Name = "lblHRPassword";
            this.lblHRPassword.Size = new System.Drawing.Size(238, 49);
            this.lblHRPassword.TabIndex = 1;
            this.lblHRPassword.Text = "Password:";
            // 
            // txtHRUsername
            // 
            this.txtHRUsername.Location = new System.Drawing.Point(610, 38);
            this.txtHRUsername.Name = "txtHRUsername";
            this.txtHRUsername.Size = new System.Drawing.Size(415, 38);
            this.txtHRUsername.TabIndex = 2;
            // 
            // txtHRPassword
            // 
            this.txtHRPassword.Location = new System.Drawing.Point(247, 108);
            this.txtHRPassword.Name = "txtHRPassword";
            this.txtHRPassword.Size = new System.Drawing.Size(450, 38);
            this.txtHRPassword.TabIndex = 3;
            this.txtHRPassword.UseSystemPasswordChar = true;
            // 
            // btnHRManagerSignIn
            // 
            this.btnHRManagerSignIn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRManagerSignIn.Location = new System.Drawing.Point(871, 281);
            this.btnHRManagerSignIn.Name = "btnHRManagerSignIn";
            this.btnHRManagerSignIn.Size = new System.Drawing.Size(224, 134);
            this.btnHRManagerSignIn.TabIndex = 4;
            this.btnHRManagerSignIn.Text = "Sign In";
            this.btnHRManagerSignIn.UseVisualStyleBackColor = true;
            this.btnHRManagerSignIn.Click += new System.EventHandler(this.btnHRManagerSignIn_Click);
            // 
            // FrmHRManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 458);
            this.Controls.Add(this.btnHRManagerSignIn);
            this.Controls.Add(this.txtHRPassword);
            this.Controls.Add(this.txtHRUsername);
            this.Controls.Add(this.lblHRPassword);
            this.Controls.Add(this.lblHRUsername);
            this.Name = "FrmHRManagerLogin";
            this.Text = "HR Manager Portal Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHRUsername;
        private System.Windows.Forms.Label lblHRPassword;
        private System.Windows.Forms.TextBox txtHRUsername;
        private System.Windows.Forms.TextBox txtHRPassword;
        private System.Windows.Forms.Button btnHRManagerSignIn;
    }
}