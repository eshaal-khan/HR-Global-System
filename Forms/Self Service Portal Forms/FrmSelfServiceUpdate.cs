using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HR_Global_System.Forms
{
    public partial class FrmSelfServiceUpdate : Form
    {
        HRPortalEmployeeRelatedMethods employeeFunctionality = new HRPortalEmployeeRelatedMethods();

        public FrmSelfServiceUpdate(Employee employeeToUpdate)
        {
            InitializeComponent();
            txtSelfServiceEditEmpID.Text = employeeToUpdate.employeeID;
            txtSelfServiceEditPassword.Text = employeeToUpdate.password;
            txtSelfServiceEditFirstName.Text = employeeToUpdate.firstName;
            txtSelfServiceEditSurname.Text = employeeToUpdate.surname;
            txtSelfServiceEditGender.Text = employeeToUpdate.gender;
            txtSelfServiceEditEmail.Text = employeeToUpdate.emailAddress;
            txtSelfServiceEditNumber.Text=employeeToUpdate.phoneNumber;
            txtSelfServiceEditJob.Text = employeeToUpdate.jobTitle;
            txtSelfServiceEditManager.Text = employeeToUpdate.manager;
            txtSelfServiceEditSalary.Text = Convert.ToString(employeeToUpdate.annualSalary);
            txtSelfServiceEditLeave.Text=Convert.ToString(employeeToUpdate.totalPaidLeave);
            txtSelfServiceEditGrade.Text = employeeToUpdate.jobGrade;
            txtSelfServiceEditCountry.Text=employeeToUpdate.baseCountry;
        }

        private void btnSelfServiceUpdate_Click(object sender, EventArgs e)
        {
            Employee updatedEmployeeInfo = new Employee(txtSelfServiceEditEmpID.Text, txtSelfServiceEditPassword.Text, txtSelfServiceEditFirstName.Text, txtSelfServiceEditSurname.Text, txtSelfServiceEditGender.Text, txtSelfServiceEditEmail.Text, txtSelfServiceEditNumber.Text,
    txtSelfServiceEditJob.Text, txtSelfServiceEditManager.Text, Convert.ToDecimal(txtSelfServiceEditSalary.Text), Convert.ToDecimal(txtSelfServiceEditLeave.Text), txtSelfServiceEditGrade.Text, txtSelfServiceEditCountry.Text);
            employeeFunctionality.UpdateSelectedRecord(updatedEmployeeInfo);

        }

        private void btnBackFromSSUpdate_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to go back? No changes made will be saved.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new FrmSelfServiceLandingPage());
            }

        }
    }
}
