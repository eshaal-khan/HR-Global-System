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
    public partial class FrmEditEmployeeInfo : Form
    {
        public HRPortalEmployeeRelatedMethods employeeMethodsHandler=new HRPortalEmployeeRelatedMethods();
        public FrmEditEmployeeInfo(Employee selectedEmployee)
        {
            //initialising of all components using the passed in Employee type object attributes
            InitializeComponent();
            lblSelectedEmployeeFullName.Text = selectedEmployee.firstName + ' '+selectedEmployee.surname;
            txtSelectedEmployeeID.Text = Convert.ToString(selectedEmployee.employeeID);
            txtSelectedEmployeePassword.Text=Convert.ToString(selectedEmployee.password);
            txtSelectedEmployeeFirstName.Text = selectedEmployee.firstName;
            txtSelectedEmployeeSurname.Text = selectedEmployee.surname;
            txtSelectedEmployeeGender.Text = selectedEmployee.gender;
            txtSelectedEmployeeEmail.Text = selectedEmployee.emailAddress;
            txtSelectedEmployeeMobile.Text = selectedEmployee.phoneNumber;
            txtSelectedEmployeeTitle.Text = selectedEmployee.jobTitle;
            txtSelectedEmployeeManager.Text = selectedEmployee.manager;
            txtSelectedEmployeeSalary.Text = Convert.ToString(selectedEmployee.annualSalary);
            txtSelectedEmployeeLeave.Text=Convert.ToString(selectedEmployee.totalPaidLeave);
            txtSelectedEmployeeGrade.Text=selectedEmployee.jobGrade;
            txtSelectedEmployeeCountry.Text=selectedEmployee.baseCountry;
            txtSelectedEmployeePassword.UseSystemPasswordChar = true;
            btnShowPassword.Text = "Show Password";
        }

        private bool IsEmployeeCreatable()
        {
            if (string.IsNullOrEmpty(txtSelectedEmployeeID.Text) || string.IsNullOrEmpty(txtSelectedEmployeePassword.Text) || string.IsNullOrEmpty(txtSelectedEmployeeFirstName.Text) || string.IsNullOrEmpty(txtSelectedEmployeeSurname.Text)
                || string.IsNullOrEmpty(txtSelectedEmployeeGender.Text) || string.IsNullOrEmpty(txtSelectedEmployeeEmail.Text) || string.IsNullOrEmpty(txtSelectedEmployeeMobile.Text) || string.IsNullOrEmpty(txtSelectedEmployeeTitle.Text)
                || string.IsNullOrEmpty(txtSelectedEmployeeManager.Text) || string.IsNullOrEmpty(txtSelectedEmployeeSalary.Text) || string.IsNullOrEmpty(txtSelectedEmployeeLeave.Text) || string.IsNullOrEmpty(txtSelectedEmployeeGrade.Text)
                || string.IsNullOrEmpty(txtSelectedEmployeeCountry.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnUpdateEmployeeInfo_Click(object sender, EventArgs e) //new Employee type object created using user input on form for passing to method responsible for updating records in the db
        {
            bool isEmployeeCreatable=IsEmployeeCreatable();
            if (!isEmployeeCreatable)
            {
                DialogResult res = MessageBox.Show("Employee record cannot be edited as 1 or more mandatory details are missing", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                Employee updatedEmployeeInfo = new Employee(txtSelectedEmployeeID.Text, txtSelectedEmployeePassword.Text, txtSelectedEmployeeFirstName.Text, txtSelectedEmployeeSurname.Text, txtSelectedEmployeeGender.Text, txtSelectedEmployeeEmail.Text, txtSelectedEmployeeMobile.Text,
                txtSelectedEmployeeTitle.Text, txtSelectedEmployeeManager.Text, Convert.ToDecimal(txtSelectedEmployeeSalary.Text), Convert.ToDecimal(txtSelectedEmployeeLeave.Text), txtSelectedEmployeeGrade.Text, txtSelectedEmployeeCountry.Text);
                employeeMethodsHandler.UpdateSelectedEmpRecord(updatedEmployeeInfo);
                FormManagement.MoveBackToPreviousForm(this, new FrmViewEmployeeRecords()); //navigates back to previous page upon successful completion

            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e) //allows hiding of password for security purposes
        {
            if (btnShowPassword.Text=="Hide Password")
            {
                txtSelectedEmployeePassword.UseSystemPasswordChar = true;
                btnShowPassword.Text = "Show Password";
            }
            else
            {
                txtSelectedEmployeePassword.UseSystemPasswordChar = false;
                btnShowPassword.Text = "Hide Password";
            }
        }

        private void btnBackFromHREditRecord_Click(object sender, EventArgs e) //navigation back to previous page
        {
            DialogResult res = MessageBox.Show("Are you sure you want to go back? No changes made will be saved.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new FrmViewEmployeeRecords());
            }

        }
    }
}
