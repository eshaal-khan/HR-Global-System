using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HR_Global_System
{
    //Used the following for help in structuring the databases querying code- https://stackoverflow.com/questions/15148588/proper-way-of-getting-a-data-from-an-access-database
    //Follows SRP- class with specific purpose of keeping all methods related to Employee data CRUD on HR lead portal together
    //Only reason this class would change would be to add/remove CRUD functionality
    //Encapsulation of all take-home pay calculation logic and classes
    public class HRPortalEmployeeRelatedMethods
    {
        //attributes used across all defined methods for db connections
        private static OleDbConnection con= new OleDbConnection();
        private static OleDbCommand cmd= new OleDbCommand();
        private static OleDbDataReader reader;
        private string connectionString= "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";

        //method for retrieving all employee records from TableEmployee info for employees who have the same base country as HR lead, and show info in data grid view
        public void RetrieveEmpData(DataGridView dgvShowAllEmployeeRecords)
        {            
            con.ConnectionString = connectionString;
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * From TableEmployeeInfo WHERE BaseCountry=@baseCountry";
            cmd.Parameters.AddWithValue("@baseCountry", SessionManager.Instance._countryOfUser);
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvShowAllEmployeeRecords.DataSource = bindingSource;
            con.Close();
        }


        //method for deleting a selected employee record
        //first moves record to an archive table, as information is retained for 5 years in line with GDPR
        //once successfully moved to archive table, it is then deleted from employee info table
        public void DeleteSelectedEmpRecord(string employeeID)
        {
            OleDbConnection conInsertRecord = new OleDbConnection();
            conInsertRecord.ConnectionString = connectionString;
            OleDbCommand cmdInsertRecord = new OleDbCommand();
            cmdInsertRecord.Connection = conInsertRecord;
            cmdInsertRecord.CommandText = @"INSERT INTO TableRecordsArchive (LoginNumber,[Password],FirstName,Surname,Gender,ContactEmail,ContactNumber,JobTitle,ManagerName,BaseAnnualSalary,PaidLeaveHours,ProfessionGrade,BaseCountry) 
            SELECT LoginNumber,[Password],FirstName,Surname,Gender,ContactEmail,ContactNumber,JobTitle,ManagerName,BaseAnnualSalary,PaidLeaveHours,ProfessionGrade,BaseCountry FROM TableEmployeeInfo WHERE LoginNumber= @id";
            cmdInsertRecord.Parameters.AddWithValue("@id", employeeID); //parameterised query
            conInsertRecord.Open();
            reader = cmdInsertRecord.ExecuteReader();
            conInsertRecord.Close();
            DialogResult res1 = MessageBox.Show("Record successfully inserted!!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.ConnectionString = connectionString;
            cmd.Connection = con;
            cmd.CommandText = @"DELETE FROM TableEmployeeInfo WHERE LoginNumber= @id";
            cmd.Parameters.AddWithValue("@id", employeeID); //parameterised query
            con.Open();
            int status = cmd.ExecuteNonQuery();
            MessageBox.Show(Convert.ToString(status));
            con.Close();
            DialogResult res = MessageBox.Show("Employee record deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //method used for checking that all records in TableRecordsArchive are less than 5 years old in line with the company's GDPR policy
        //if more than 5 years old, they will be deleted and HR lead will be notified of how many records have been deleted since last login
        public void CheckAndDeleteArchivedEmpRecords()
        {
            DateTime cutoffDate = DateTime.Now.AddYears(-5);
            DateTime cutoffDateFormatted = cutoffDate.Date;
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();

                    string commandText = @"DELETE * From TableRecordsArchive WHERE DateDeleted < @cutoffDate";
                    using (OleDbCommand cmd = new OleDbCommand(commandText, con))
                    {
                        cmd.Parameters.AddWithValue("@cutoffDate", cutoffDateFormatted);
                        int deletedRows = cmd.ExecuteNonQuery();
                        DialogResult res=MessageBox.Show(Convert.ToString(deletedRows) + " has been deleted in line with GDPR. Please view out data policy for more information","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in deleting from archive");
            }
            
        }

        //method with takes Employee type object as parameter (monadic method)
        //uses the attributes of passed object for adding a new Employee record to the table through a parameterised query for security/preventing SQL injection
        public void CreateNewEmpRecord(Employee newEmployee)
        {
            con = new OleDbConnection();
            con.ConnectionString = connectionString;
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO TableEmployeeInfo (LoginNumber, [Password],FirstName,Surname,Gender,ContactEmail,ContactNumber,JobTitle,ManagerName,BaseAnnualSalary,PaidLeaveHours,ProfessionGrade,BaseCountry) 
            VALUES (@id,@pwd,@fn,@sn,@gen, @email,@number,@job,@manager, @salary,@leave,@grade,@country)";
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

        //method used to make updates to a specific employee info record, using attributes of the passed in Employee object
        //conducted through parameterised query
        public void UpdateSelectedEmpRecord(Employee updatedEmployeeInfo)
        {
            con = new OleDbConnection();
            con.ConnectionString = connectionString;
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE TableEmployeeInfo SET [Password]=@pwd,FirstName=@fn , Surname=@sn , Gender=@gen , ContactEmail=@email , ContactNumber=@number , JobTitle=@job, ManagerName=@manager, BaseAnnualSalary=@salary, PaidLeaveHours=@leave, ProfessionGrade=@grade, BaseCountry=@country  WHERE LoginNumber=@id";
            //parameterised queries for information needed for table
            cmd.Parameters.AddWithValue("@pwd", updatedEmployeeInfo.password);
            cmd.Parameters.AddWithValue("@fn", updatedEmployeeInfo.firstName);
            cmd.Parameters.AddWithValue("@sn", updatedEmployeeInfo.surname);
            cmd.Parameters.AddWithValue("@gen", updatedEmployeeInfo.gender);
            cmd.Parameters.AddWithValue("@email", updatedEmployeeInfo.emailAddress);
            cmd.Parameters.AddWithValue("@number", updatedEmployeeInfo.phoneNumber);
            cmd.Parameters.AddWithValue("@job", updatedEmployeeInfo.jobTitle);
            cmd.Parameters.AddWithValue("@manager", updatedEmployeeInfo.manager);
            cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(updatedEmployeeInfo.annualSalary));
            cmd.Parameters.AddWithValue("@leave", Convert.ToDecimal(updatedEmployeeInfo.totalPaidLeave));
            cmd.Parameters.AddWithValue("@grade", updatedEmployeeInfo.jobGrade);
            cmd.Parameters.AddWithValue("@country", updatedEmployeeInfo.baseCountry);
            cmd.Parameters.AddWithValue("@id", updatedEmployeeInfo.employeeID);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            DialogResult res = MessageBox.Show("Edit complete!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
