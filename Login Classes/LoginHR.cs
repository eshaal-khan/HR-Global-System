using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System.Login_Classes
{
    //Inheritance of LoginDecorator attributes and methods
    public class LoginHR:LoginDecorator
    {
        //Concrete decorator used to add further functionality for logging in HR leads specifically
        protected string dbConnectionQuery = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
        public LoginHR(ILogin login) : base(login) { }

        //override method for implementing ValidateCredentials and passing necessary values to ValidateJobRole method (holds the extra functionality needed for this decorated object)
        public override bool ValidateCredentials(string username, string password)
        {
            if (base.ValidateCredentials(username, password))
            {
                return ValidateJobRole(username, password);
            }
            else
            {
                return false;
            }
        }

        public bool ValidateJobRole(string username,string password)
        {
            using (OleDbConnection con = new OleDbConnection(dbConnectionQuery))
            {
                con.Open();
                string jobQuery = "SELECT JobTitle From TableEmployeeInfo WHERE LoginNumber= '" + username + "' AND Password='" + password + "'";
                using (OleDbCommand cmd = new OleDbCommand(jobQuery, con))
                {
                    object jobResult = cmd.ExecuteScalar();
                    string jobTitle = jobResult.ToString();

                    if (jobTitle.Equals("HR Lead", StringComparison.OrdinalIgnoreCase))
                    {
                        string countryQuery = "SELECT BaseCountry From TableEmployeeInfo WHERE LoginNumber= '" + username + "' AND Password='" + password + "'";
                        using (OleDbCommand cmd2 = new OleDbCommand(countryQuery, con))
                        {
                            object baseCountryResult = cmd2.ExecuteScalar();
                            string baseCountry = baseCountryResult.ToString();
                            MessageBox.Show("Login successful!");
                            SessionManager.Instance.CreateSession(username, jobTitle, baseCountry);
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
