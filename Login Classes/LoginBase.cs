using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System.Management_Classes
{
    //encapsulation - only accessible within child classes
    public abstract class LoginBase
    {
        protected string dbConnectionQuery = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
        public bool ValidateDetails(string username, string password)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(dbConnectionQuery))
                {
                    con.Open();
                    string verificationQuery = "SELECT * From TableEmployeeInfo WHERE LoginNumber= '" + username + "' AND Password='" + password + "'";
                    using (OleDbCommand cmd = new OleDbCommand(verificationQuery, con))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            Employee employeeRecord = HRPortalEmployeeFunctionality.CreateEmployeeObject(username);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                }   } 
            }
            catch (OleDbException exception)
            {

                MessageBox.Show($"Error in checking details: {exception.Message}");
                SessionManager.Instance.FinishSession();
                return false;
            }
        }
    }
}
