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
    public class HRLogin : LoginBase
    {
        public override bool HRCheck(string username, string password)
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
                    using (OleDbCommand cmd2 = new OleDbCommand(jobQuery, con))
                    {
                        object jobResult = cmd2.ExecuteScalar();
                        string jobTitle = jobResult.ToString();

                        if (jobTitle.Equals("HR Lead", StringComparison.OrdinalIgnoreCase))
                        {
                            string countryQuery = "SELECT BaseCountry From TableEmployeeInfo WHERE LoginNumber= '" + username + "' AND Password='" + password + "'";
                            using (OleDbCommand cmd3 = new OleDbCommand(countryQuery, con))
                            {
                                object baseCountryResult = cmd3.ExecuteScalar();
                                string baseCountry = baseCountryResult.ToString();
                                MessageBox.Show("Login successful!");
                                SessionManager.Instance.CreateSession(username, jobTitle, baseCountry);
                                FrmHRLandingPage HRLandingPage = new FrmHRLandingPage();
                                FormManagement.NavigateToNextForm(currentForm, HRLandingPage);
                                return true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Access denied as you are not a HR Lead. Please contact your HR Lead for further guidance or log into the self service portal");
                            return false;
                        }
                    }
                }

            }
        }
    }
}
