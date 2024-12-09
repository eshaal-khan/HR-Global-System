using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System
{
    public class HRUpdateRequestsMethods
    {
        public void ViewRequestRecords(DataGridView dgvViewRequests)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = HRDatabase.mdb";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * From TableEmployeeRequests WHERE CountryOfRequester=@cor";
            cmd.Parameters.AddWithValue("@cor", SessionManager.Instance._countryOfUser);
            con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvViewRequests.DataSource = bindingSource;
            con.Close();
        }

        public void SaveStatusChange(string requestStatus, string empID)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE TableEmployeeRequests SET RequestStatus= @rs WHERE EmployeeID=@id";
            //parameterised queries for information needed for table
            cmd.Parameters.AddWithValue("@rs", requestStatus);
            cmd.Parameters.AddWithValue("@id", empID);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            DialogResult res = MessageBox.Show("Status has been changed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
