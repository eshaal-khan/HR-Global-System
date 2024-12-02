using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System.Management_Classes
{
    internal class HRLogin : LoginBase
    {
        public bool ValidateHRDetails(string username, string password)
        {
            if (!ValidateDetails(username, password))
            {
                return false;
            }
            else
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
}
