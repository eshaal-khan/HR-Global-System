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
        HRPortalEmployeeRelatedMethods employeeFunctionality=new HRPortalEmployeeRelatedMethods();
        public FrmEditEmployeeInfo(Employee selectedEmployee)
        {
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

        private void btnUpdateEmployeeInfo_Click(object sender, EventArgs e)
        {
            Employee updatedEmployeeInfo = new Employee(txtSelectedEmployeeID.Text, txtSelectedEmployeePassword.Text, txtSelectedEmployeeFirstName.Text, txtSelectedEmployeeSurname.Text, txtSelectedEmployeeGender.Text, txtSelectedEmployeeEmail.Text, txtSelectedEmployeeMobile.Text,
                txtSelectedEmployeeTitle.Text, txtSelectedEmployeeManager.Text, Convert.ToDecimal(txtSelectedEmployeeSalary.Text), Convert.ToDecimal(txtSelectedEmployeeLeave.Text), txtSelectedEmployeeGrade.Text, txtSelectedEmployeeCountry.Text);
            employeeFunctionality.UpdateSelectedRecord(updatedEmployeeInfo);
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
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

        private void btnBackFromHREditRecord_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to go back? No changes made will be saved.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new FrmViewEmployeeRecords());
            }

        }
    }
}
