using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System
{
    public class Employee
    {
        public int _employeeID { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _gender { get; set; }
        public string _contactEmail { get; set; }
        public string _contactNumber { get; set; }
        public string _jobTitle { get; set; }
        public string _managerName { get; set; }
        public decimal _annualSalary { get; set; }
        public decimal _totalPaidLeave { get; set; }
        public string _jobGrade { get; set; }
        public string _baseCountry { get; set; }

        public Employee(int employeeID, string firstName, string lastName, string gender, string contactEmail, string contactNumber,
            string jobTitle, string managerName, decimal annualSalary, decimal totalPaidLeave, string jobGrade, string baseCountry)
        {
            this._employeeID = employeeID;
            this._firstName = firstName;
            this._lastName = lastName;
            this._gender = gender;
            this._contactEmail = contactEmail;
            this._contactNumber = contactNumber;
            this._jobTitle = jobTitle;
            this._managerName = managerName;
            this._annualSalary = annualSalary;
            this._totalPaidLeave = totalPaidLeave;
            this._jobGrade = jobGrade;
            this._baseCountry = baseCountry;
        }
    }
}
