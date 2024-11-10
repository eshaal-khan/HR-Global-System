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
        public FrmEditEmployeeInfo(Employee selectedEmployee)
        {
            InitializeComponent();
            lblSelectedEmployeeFullName.Text = selectedEmployee._firstName + ' '+selectedEmployee._lastName;
            txtSelectedEmployeeID.Text = Convert.ToString(selectedEmployee._employeeID);
            txtSelectedEmployeeFirstName.Text = selectedEmployee._firstName;
            txtSelectedEmployeeSurname.Text = selectedEmployee._lastName;
            txtSelectedEmployeeGender.Text = selectedEmployee._gender;
            txtSelectedEmployeeEmail.Text = selectedEmployee._contactEmail;
            txtSelectedEmployeeMobile.Text = selectedEmployee._contactNumber;
            txtSelectedEmployeeTitle.Text = selectedEmployee._jobTitle;
            txtSelectedEmployeeManager.Text = selectedEmployee._managerName;
            txtSelectedEmployeeSalary.Text = Convert.ToString(selectedEmployee._annualSalary);
            txtSelectedEmployeeLeave.Text=Convert.ToString(selectedEmployee._totalPaidLeave);
            txtSelectedEmployeeGrade.Text=selectedEmployee._jobGrade;
            txtSelectedEmployeeCountry.Text=selectedEmployee._baseCountry;
        }

        private void btnUpdatEmployeeInfo_Click(object sender, EventArgs e)
        {
            //opening connection with database
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader reader;
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source=HRDatabase.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            //SQL for updating staff record
            cmd.CommandText = @"UPDATE TableEmployeeInfo SET FirstName=@fn , Surname=@sn , Gender=@gen , ContactEmail=@email , ContactNumber=@number , JobTitle=@job, ManagerName=@manager, BaseAnnualSalary=@salary, PaidLeaveHours=@leave, ProfessionalGrade=@grade, BaseCountry=@country  WHERE LoginNumber=@id";
            //parameterised queries for information needed for table
            cmd.Parameters.AddWithValue("@id", txtSelectedEmployeeID.Text);
            cmd.Parameters.AddWithValue("@fn", txtSelectedEmployeeFirstName.Text);
            cmd.Parameters.AddWithValue("@sn", txtSelectedEmployeeSurname.Text);
            cmd.Parameters.AddWithValue("@gen", txtSelectedEmployeeGender.Text);
            cmd.Parameters.AddWithValue("@email", txtSelectedEmployeeEmail.Text);
            cmd.Parameters.AddWithValue("@number", txtSelectedEmployeeMobile.Text);
            cmd.Parameters.AddWithValue("@job", txtSelectedEmployeeTitle.Text);
            cmd.Parameters.AddWithValue("@manager", txtSelectedEmployeeManager.Text);
            cmd.Parameters.AddWithValue("@salary", txtSelectedEmployeeSalary.Text);
            cmd.Parameters.AddWithValue("@leave", txtSelectedEmployeeLeave.Text);
            cmd.Parameters.AddWithValue("@grade", txtSelectedEmployeeGrade.Text);
            cmd.Parameters.AddWithValue("@country", txtSelectedEmployeeCountry.Text);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
            //message shown to user if edit is successful, otherwise error message is shown
            DialogResult res = MessageBox.Show("Edit complete!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                this.Visible = false;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
