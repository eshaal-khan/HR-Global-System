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
        HRPortalEmployeeFunctionality employeeFunctionality = new HRPortalEmployeeFunctionality();

        public FrmSelfServiceUpdate(Employee employeeToUpdate)
        {
            InitializeComponent();
            txtSelfServiceEditPassword.Text = employeeToUpdate.password;
            txtSelfServiceEditFirstName.Text = employeeToUpdate.firstName;
            txtSelfServiceEditSurname.Text = employeeToUpdate.surname;
            txtSelfServiceEditGender.Text = employeeToUpdate.gender;
            txtSelfServiceEditEmail.Text = employeeToUpdate.emailAddress;
            txtSelfServiceEditNumber.Text=employeeToUpdate.phoneNumber;
        }

        private void btnSelfServiceUpdate_Click(object sender, EventArgs e)
        {
            Employee updatedEmployeeInfo = new Employee(txtSelfServiceEditEmpID.Text, txtSelfServiceEditPassword.Text, txtSelfServiceEditFirstName.Text, txtSelfServiceEditSurname.Text, txtSelfServiceEditSurname.Text, txtSelfServiceEditEmail.Text, txtSelfServiceEditNumber.Text,
    txtSelfServiceEditJob.Text, txtSelfServiceEditManager.Text, Convert.ToDecimal(txtSelfServiceEditSalary.Text), Convert.ToDecimal(txtSelfServiceEditLeave.Text), txtSelfServiceEditGrade.Text, txtSelfServiceEditCountry.Text);
            employeeFunctionality.UpdateSelectedRecord(updatedEmployeeInfo);

        }
    }
}
