using HR_Global_System.Management_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System
{
    public partial class FrmHRManagerLogin : Form
    {
        public FrmHRManagerLogin()
        {
            InitializeComponent();
        }

        private void btnHRManagerSignIn_Click(object sender, EventArgs e)
        {   
            HRLogin loginHandler = new HRLogin();
            bool successfulLogin= loginHandler.ValidateHRDetails(txtHRUsername.Text,txtHRPassword.Text);
            if (successfulLogin)
            {
                FormManagement.NavigateToNextForm(this, new FrmHRLandingPage());
            }
            else
            {
                MessageBox.Show("Access denied- please ensure you are a HR lead and your details are correct");
                SessionManager.Instance.FinishSession();
            }
        }

        private void btnBackFromHRLogin_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, new FrmWelcomePage());
        }
    }
}
