using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System
{
    internal class HRPortalEmployeeFunctionality
    {
        private static OleDbConnection con;
        private static OleDbCommand cmd;
        private static OleDbDataReader reader;
        private string connectionString= "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";

        public void RetrieveEmpData(DataGridView dgvAllEmployeeRecords)
        {

            con = new OleDbConnection();
            con.ConnectionString = connectionString;
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * From TableEmployeeInfo WHERE BaseCountry=@baseCountry";
            cmd.Parameters.AddWithValue("@baseCountry", SessionManager.Instance._countryOfUser);
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvAllEmployeeRecords.DataSource = bindingSource;
            con.Close();
        }

        public void DeleteSelectedRecord(int employeeID, DataGridView dgvAllEmployeeRecords)
        {
            con = new OleDbConnection();
            con.ConnectionString = connectionString;
            cmd = new OleDbCommand();
            cmd.Connection = con;
            //SQL for deleting the record where the ID is the one in the variable above
            cmd.CommandText = @"DELETE FROM TableEmployeeInfo WHERE LoginNumber= @id";
            cmd.Parameters.AddWithValue("@id", employeeID); //parameterised query
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            //shows message to user that deleting has been done successfully- if not, prints an error message
            DialogResult res = MessageBox.Show("Employee record deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CreateNewRecord(Employee newEmployee)
        {
            con = new OleDbConnection();
            con.ConnectionString = connectionString;
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO TableEmployeeInfo (LoginNumber, Password,FirstName,Surname,Gender,ContactEmail,ContactNumber,JobTitle,ManagerName,BaseAnnualSalary,PaidLeaveHours,ProfessionGrade,BaseCountry) VALUES (@id,@pwd,@fn,@sn,@gen, @email,@number,@job,@manager, @salary,@leave,@grade,@country)";
            cmd.Parameters.AddWithValue("@id", newEmployee.employeeID);
            cmd.Parameters.AddWithValue("@pwd",newEmployee.password);
            cmd.Parameters.AddWithValue("@fn",newEmployee.firstName);
            cmd.Parameters.AddWithValue("@sn", newEmployee.surname);
            cmd.Parameters.AddWithValue("@gen", newEmployee.gender);
            cmd.Parameters.AddWithValue("@email", newEmployee.emailAddress);
            cmd.Parameters.AddWithValue("@number", newEmployee.phoneNumber);
            cmd.Parameters.AddWithValue("@job", newEmployee.jobTitle);
            cmd.Parameters.AddWithValue("@manager", newEmployee.manager);
            cmd.Parameters.AddWithValue("@salary", newEmployee.annualSalary);
            cmd.Parameters.AddWithValue("@leave", newEmployee.totalPaidLeave);
            cmd.Parameters.AddWithValue("@grade", newEmployee.jobGrade);
            cmd.Parameters.AddWithValue("@country", newEmployee.baseCountry);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            DialogResult res = MessageBox.Show("New record successfully added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateSelectedRecord(Employee updatedEmployeeInfo)
        {
            con = new OleDbConnection();
            con.ConnectionString = connectionString;
            cmd = new OleDbCommand();
            cmd.Connection = con;
            //SQL for updating staff record
            cmd.CommandText = @"UPDATE TableEmployeeInfo SET Password=@pwd,FirstName=@fn , Surname=@sn , Gender=@gen , ContactEmail=@email , ContactNumber=@number , JobTitle=@job, ManagerName=@manager, BaseAnnualSalary=@salary, PaidLeaveHours=@leave, ProfessionalGrade=@grade, BaseCountry=@country  WHERE LoginNumber=@id";
            //parameterised queries for information needed for table
            cmd.Parameters.AddWithValue("@id", updatedEmployeeInfo.employeeID);
            cmd.Parameters.AddWithValue("@pwd", updatedEmployeeInfo.password);
            cmd.Parameters.AddWithValue("@fn", updatedEmployeeInfo.firstName);
            cmd.Parameters.AddWithValue("@sn", updatedEmployeeInfo.surname);
            cmd.Parameters.AddWithValue("@gen", updatedEmployeeInfo.gender);
            cmd.Parameters.AddWithValue("@email", updatedEmployeeInfo.emailAddress);
            cmd.Parameters.AddWithValue("@number", updatedEmployeeInfo.phoneNumber);
            cmd.Parameters.AddWithValue("@job", updatedEmployeeInfo.jobTitle);
            cmd.Parameters.AddWithValue("@manager", updatedEmployeeInfo.manager);
            cmd.Parameters.AddWithValue("@salary", updatedEmployeeInfo.annualSalary);
            cmd.Parameters.AddWithValue("@leave", updatedEmployeeInfo.totalPaidLeave);
            cmd.Parameters.AddWithValue("@grade", updatedEmployeeInfo.jobGrade);
            cmd.Parameters.AddWithValue("@country", updatedEmployeeInfo.baseCountry);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            DialogResult res = MessageBox.Show("Edit complete!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static Employee CreateEmployeeObject(string ID)
        {
            string connectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();

                string commandText = @"SELECT * From TableEmployeeInfo WHERE LoginNumber= @id";
                using (OleDbCommand cmd = new OleDbCommand(commandText, con))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Employee EmployeeRecord = new Employee
                                (
                                reader["LoginNumber"].ToString(),
                               reader["Password"].ToString(),
                             reader["FirstName"].ToString(),
                            reader["Surname"].ToString(),
                            reader["Gender"].ToString(),
                            reader["ContactEmail"].ToString(),
                           reader["ContactNumber"].ToString(),
                            reader["JobTitle"].ToString(),
                            reader["ManagerName"].ToString(),
                            Convert.ToDecimal(reader["BaseAnnualSalary"].ToString()),
                            Convert.ToDecimal(reader["PaidLeaveHours"].ToString()),
                            reader["ProfessionGrade"].ToString(),
                            reader["BaseCountry"].ToString()
                                );
                            return EmployeeRecord;


                        }
                        else
                        {
                            MessageBox.Show("Error in fetching data, please try again");
                            return null;
                        }
                    }
                }
            }
        }
    }
}
