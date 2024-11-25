using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System.Management_Classes
{
    public abstract class LoginBase
    {
        protected string dbConnectionQuery = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";

        public bool ValidateDetails(string username, string password)
        {
            string jobQuery = "SELECT JobTitle From TableEmployeeInfo WHERE LoginNumber= '" + username + "' AND Password='" + password + "'";
            string countryQuery = "SELECT BaseCountry From TableEmployeeInfo WHERE LoginNumber= '" + username + "' AND Password='" + password + "'";

            using (OleDbConnection con = new OleDbConnection(dbConnectionQuery))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(dbConnectionQuery, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        using (OleDbCommand cmd2 = new OleDbCommand(jobQuery, con))
                        {
                            object jobResult = cmd2.ExecuteScalar();
                            string jobTitle = jobResult.ToString();

                            if (jobTitle.Equals("HR Lead", StringComparison.OrdinalIgnoreCase))
                            {
                                using (OleDbCommand cmd3 = new OleDbCommand(countryQuery, con))
                                {
                                    object baseCountryResult = cmd3.ExecuteScalar();
                                    string baseCountry = baseCountryResult.ToString();
                                    MessageBox.Show("Login successful!");
                                    SessionManager.Instance.CreateSession(username, jobTitle, baseCountry);
                                    return true;
                                    //FrmHRLandingPage HRLandingPage = new FrmHRLandingPage();
                                    //FormManagement.NavigateToNextForm(currentForm, HRLandingPage);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Access denied as you are not a HR Lead. Please contact your HR Lead for further guidance or log into the self service portal");
                                return false;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid login details, please recheck your details");
                        return false;
                    }
                }
            }
        }
    }
}
