using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System.Login_Classes
{
    class BasicLogin: ILogin
    {
        //functionality for logging in Self-Service Side
        //Concrete class that implements ILogin
        //Inherits ILogin
        //Simply defines and runs ValidateCredentials method
        //Follows LSP- definition of ValidateCredentials below means that this class (child class of ILogin) can uphold behaviour of the parent class

        protected string dbConnectionQuery = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
        public bool ValidateCredentials (string username, string password)
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
                            Employee employeeRecord = Employee.CreateEmpObject(username);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (OleDbException exception)
            {

                MessageBox.Show($"Error in checking details: {exception.Message}");
                SessionManager.Instance.FinishSession();
                return false;
            }
            //code for logging in goes here, may need to change to return a bool
        }
    }
}
