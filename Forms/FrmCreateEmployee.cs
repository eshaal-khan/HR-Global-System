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
        public FrmCreateEmployee()
        {
            InitializeComponent();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader reader;
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO TableEmployeeInfo (LoginNumber,FirstName,Surname,Gender,ContactEmail,ContactNumber,JobTitle,ManagerName,BaseAnnualSalary,PaidLeaveHours,ProfessionGrade,BaseCountry) VALUES (@id,@fn,@sn,@gen, @email,@number,@job,@manager, @salary,@leave,@grade,@country)";
            cmd.Parameters.AddWithValue("@id", txtNewEmployeeID.Text);
            cmd.Parameters.AddWithValue("@fn", txtNewEmployeeFirstName.Text);
            cmd.Parameters.AddWithValue("@sn", txtNewEmployeeSurname.Text);
            cmd.Parameters.AddWithValue("@gen", txtNewEmployeeGender.Text);
            cmd.Parameters.AddWithValue("@email", txtNewEmployeeEmail.Text);
            cmd.Parameters.AddWithValue("@number", txtNewEmployeeMobile.Text);
            cmd.Parameters.AddWithValue("@job", txtNewEmployeeJob.Text);
            cmd.Parameters.AddWithValue("@manager", txtNewEmployeeManager.Text);
            cmd.Parameters.AddWithValue("@salary", txtNewEmployeeSalary.Text);
            cmd.Parameters.AddWithValue("@leave", txtNewEmployeeLeave.Text);
            cmd.Parameters.AddWithValue("@grade", txtNewEmployeeGrade.Text);
            cmd.Parameters.AddWithValue("@country", txtNewEmployeeCountry.Text);

            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            DialogResult res = MessageBox.Show("New record successfully added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
