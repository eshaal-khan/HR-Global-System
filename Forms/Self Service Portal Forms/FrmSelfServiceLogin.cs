using HR_Global_System.Login_Classes;
//using HR_Global_System.Management_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HR_Global_System
{
    public partial class FrmSelfServiceLogin : Form
    {
        ILogin basicLogin=new BasicLogin();
        public FrmSelfServiceLogin()
        {
            InitializeComponent();
        }

        private void btnSelfServiceSignIn_Click(object sender, EventArgs e)
        {
            if (basicLogin.ValidateCredentials(txtSelfServiceUsername.Text,txtSelfServicePassword.Text))
            {
                MessageBox.Show("Successful Login!");
                Employee employeeRecord = HRPortalEmployeeRelatedMethods.CreateEmployeeObject(txtSelfServiceUsername.Text);
                SessionManager.Instance.CreateSession(employeeRecord.employeeID, employeeRecord.jobTitle, employeeRecord.baseCountry);
                FormManagement.NavigateToNextForm(this, new FrmSelfServiceLandingPage());

            }
            else
            {
                MessageBox.Show("Access denied- please ensure your details are correct");
                SessionManager.Instance.FinishSession();
            }
        }

        private void btnBackFromSSLogin_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, new FrmWelcomePage());
        }
    }
}
