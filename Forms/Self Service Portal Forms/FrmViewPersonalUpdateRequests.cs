using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System.Forms
{
    public partial class FrmViewPersonalUpdateRequests : Form
    {
        public FrmViewPersonalUpdateRequests()
        {
            InitializeComponent();
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * From TableEmployeeRequests WHERE EmployeeID=@id";
            cmd.Parameters.AddWithValue("@id", SessionManager.Instance._IDOfUser);
            con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvViewMyRequests.DataSource = bindingSource;
            con.Close();

        }
    }
}
