using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System
{
    public partial class FrmCreateEmployee : Form
    {
        HRPortalEmployeeRelatedMethods employeeFunctionality;
        public FrmCreateEmployee()
        {
            InitializeComponent();
            txtNewEmployeeCountry.Text = SessionManager.Instance._countryOfUser;
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee(txtNewEmployeeID.Text,txtNewEmployeePassword.Text,txtNewEmployeeFirstName.Text,txtNewEmployeeSurname.Text,txtNewEmployeeGender.Text,txtNewEmployeeEmail.Text,txtNewEmployeeMobile.Text,txtNewEmployeeJob.Text,
                txtNewEmployeeManager.Text,Convert.ToDecimal(txtNewEmployeeSalary),Convert.ToDecimal(txtNewEmployeeLeave),txtNewEmployeeGrade.Text,txtNewEmployeeCountry.Text);

            employeeFunctionality.CreateNewRecord(newEmployee);
            FormManagement.MoveBackToPreviousForm(this, new FrmHRLandingPage());
        }

        private void btnBackFromCreateEmp_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, new FrmHRLandingPage());

        }
    }
}
