using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System
{
    public partial class FrmHRManagerLogin : Form
    {
        public FrmHRManagerLogin()
        {
            InitializeComponent();
        }

        private void btnHRManagerSignIn_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    string verificationQuery = "SELECT * From TableEmployeeInfo WHERE LoginNumber= '" + txtHRUsername.Text + "' AND Password='" + txtHRPassword.Text + "'";
                    using (OleDbCommand cmd = new OleDbCommand(verificationQuery, con))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string jobQuery = "SELECT JobTitle From TableEmployeeInfo WHERE LoginNumber= '" + txtHRUsername.Text + "' AND Password='" + txtHRPassword.Text + "'";
                            using (OleDbCommand cmd2 = new OleDbCommand(jobQuery, con))
                            {
                                object jobResult = cmd2.ExecuteScalar();
                                string jobTitle = jobResult.ToString();

                                if (jobTitle.Equals("HR Lead", StringComparison.OrdinalIgnoreCase))
                                {
                                    string countryQuery= "SELECT BaseCountry From TableEmployeeInfo WHERE LoginNumber= '" + txtHRUsername.Text + "' AND Password='" + txtHRPassword.Text + "'";
                                    using (OleDbCommand cmd3 = new OleDbCommand(countryQuery, con))
                                    {
                                        object baseCountryResult = cmd3.ExecuteScalar();
                                        string baseCountry = baseCountryResult.ToString();
                                        MessageBox.Show("Login successful!");
                                        FrmHRLandingPage HRLandingPage = new FrmHRLandingPage(baseCountry);
                                        FormManagement.NavigateToNextForm(this, HRLandingPage);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Access denied as you are not a HR Lead. Please contact your HR Lead for further guidance or log into the self service portal");
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid login details, please recheck your details");
                        }
                    }
                }
            }
            catch (OleDbException exception)
            {

                MessageBox.Show($"Error in checking details: {exception.Message}");
            }

        }
    }
}
