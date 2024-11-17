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

namespace HR_Global_System
{
    public partial class FrmSelfServiceLandingPage : Form
    {
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;
        public FrmSelfServiceLandingPage(string EmployeeID)
        {
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * From TableEmployeeInfo WHERE LoginNumber=@ID";
            cmd.Parameters.AddWithValue("@id", EmployeeID);
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            //dgvAllEmployeeRecords.DataSource = bindingSource;
            con.Close();
        }

        private void FrmSelfServiceLandingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
