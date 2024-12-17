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
    public class Employee
    {
        //attributes for Employee type objects

        private string _employeeID;
        private string _password;
        private string _firstName;
        private string _surname;
        private string _gender;
        private string _emailAddress;
        private string _phoneNumber;
        private string _jobTitle;
        private string _manager;
        private decimal _annualSalary;
        private decimal _totalPaidLeave;
        private string _jobGrade;
        private string _baseCountry;

        //constructor for Employee type objects
        public Employee(string employeeID, string password, string firstName, string lastName, string gender, string emailAddress, string phoneNumber,
            string jobTitle, string manager, decimal annualSalary, decimal totalPaidLeave, string jobGrade, string baseCountry)
        {
            this._employeeID = employeeID;
            this._password = password;
            this._firstName = firstName;
            this._surname = lastName;
            this._gender = gender;
            this._emailAddress = emailAddress;
            this._phoneNumber = phoneNumber;
            this._jobTitle = jobTitle;
            this._manager = manager;
            this._annualSalary = annualSalary;
            this._totalPaidLeave = totalPaidLeave;
            this._jobGrade = jobGrade;
            this._baseCountry = baseCountry;
        }

        //getters and setters for each Employee object attribute
        //allows for more controlled access compared to public attributes (encapsulation) + provides flexibility to change accessibility of individual attributes
        public string employeeID
        {
            get
            {
                return this._employeeID;
            }
            set
            {
                this._employeeID = value;
            }
        }
        public string password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }
        public string firstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }
        public string surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
            }
        }
        public string gender
        {
            get
            {
                return this._gender;
            }
            set
            {
                this._gender = value;
            }
        }
        public string emailAddress
        {
            get
            {
                return this._emailAddress;
            }
            set
            {
                this._emailAddress = value;
            }
        }
        public string phoneNumber
        {
            get
            {
                return this._phoneNumber;
            }
            set
            {
                this._phoneNumber = value;
            }
        }
        public string jobTitle
        {
            get
            {
                return this._jobTitle;
            }
            set
            {
                this._jobTitle = value;
            }
        }
        public string manager
        {
            get
            {
                return this._manager;
            }
            set
            {
                this._manager = value;
            }
        }
        public decimal annualSalary
        {
            get
            {
                return this._annualSalary;
            }
            set
            {
                this._annualSalary = value;
            }
        }
        public decimal totalPaidLeave
        {
            get
            {
                return this._totalPaidLeave;
            }
            set
            {
                this._totalPaidLeave = value;
            }
        }
        public string jobGrade
        {
            get
            {
                return this._jobGrade;
            }
            set
            {
                this._jobGrade = value;
            }
        }
        public string baseCountry
        {
            get
            {
                return this._baseCountry;
            }
            set
            {
                this._baseCountry = value;
            }
        }

        //behaviour/method for creating new employee using data from a selected record from TableEmployeeInfo based on employee ID
        public static Employee CreateEmpObject(string ID)
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
