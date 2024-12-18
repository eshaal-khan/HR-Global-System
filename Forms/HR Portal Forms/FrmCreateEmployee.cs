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
        public HRPortalEmployeeRelatedMethods employeeMethodsHandler = new HRPortalEmployeeRelatedMethods();
        public FrmCreateEmployee()
        {
            InitializeComponent();
            txtNewEmployeeCountry.Text = SessionManager.Instance._countryOfUser; //ensures HR lead can only create new records for employees in their specific country
        }

        private bool IsEmployeeCreatable()
        {
            if (string.IsNullOrEmpty(txtNewEmployeeID.Text) || string.IsNullOrEmpty(txtNewEmployeePassword.Text) || string.IsNullOrEmpty(txtNewEmployeeFirstName.Text) || string.IsNullOrEmpty(txtNewEmployeeSurname.Text)
                || string.IsNullOrEmpty(txtNewEmployeeGender.Text) || string.IsNullOrEmpty(txtNewEmployeeEmail.Text) || string.IsNullOrEmpty(txtNewEmployeeMobile.Text) || string.IsNullOrEmpty(txtNewEmployeeJob.Text) 
                || string.IsNullOrEmpty(txtNewEmployeeManager.Text) || string.IsNullOrEmpty(txtNewEmployeeSalary.Text) || string.IsNullOrEmpty(txtNewEmployeeLeave.Text) || string.IsNullOrEmpty(txtNewEmployeeGrade.Text)
                || string.IsNullOrEmpty(txtNewEmployeeCountry.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e) //takes user input from form to create new employee object for passing to the method responsible for creating new db records
        {
            bool isEmployeeCreatable=IsEmployeeCreatable();
            if (!isEmployeeCreatable)
            {
                DialogResult res = MessageBox.Show("Employee record cannot be created as 1 or more mandatory details are missing", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                Employee newEmployee = new Employee(Convert.ToString(txtNewEmployeeID.Text), Convert.ToString(txtNewEmployeePassword.Text), Convert.ToString(txtNewEmployeeFirstName.Text), Convert.ToString(txtNewEmployeeSurname.Text), Convert.ToString(txtNewEmployeeGender.Text), Convert.ToString(txtNewEmployeeEmail.Text), Convert.ToString(txtNewEmployeeMobile.Text), Convert.ToString(txtNewEmployeeJob.Text),
                Convert.ToString(txtNewEmployeeManager.Text), Convert.ToDecimal(txtNewEmployeeSalary.Text), Convert.ToDecimal(txtNewEmployeeLeave.Text), Convert.ToString(txtNewEmployeeGrade.Text), Convert.ToString(txtNewEmployeeCountry.Text));

                employeeMethodsHandler.CreateNewEmpRecord(newEmployee);
                FormManagement.MoveBackToPreviousForm(this, new FrmHRLandingPage()); //navigates back to previous page on successful completion of action

            }
        }

        private void btnBackFromCreateEmp_Click(object sender, EventArgs e) //navigation back to landing page
        {
            DialogResult res = MessageBox.Show("Are you sure you would like to go back? Any unsaved employee records will not be saved.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new FrmHRLandingPage());
            }
        }
    }
}
