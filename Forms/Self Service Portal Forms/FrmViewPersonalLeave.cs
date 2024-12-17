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

namespace HR_Global_System.Forms.Self_Service_Portal_Forms
{
    public partial class FrmViewPersonalLeave : Form
    {
        public FrmViewPersonalLeave() //retrieval of the logged in user's leave requests from TableLeaveRequests
        {
            InitializeComponent();
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * From TableLeaveRequests WHERE RequesterID=@id";
            cmd.Parameters.AddWithValue("@id", SessionManager.Instance._IDOfUser);
            con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvViewMyLeave.DataSource = bindingSource;
            con.Close();
        }

        private void btnBackToPreviousPage_Click(object sender, EventArgs e)
        {
                FormManagement.MoveBackToPreviousForm(this, new FrmSelfServiceLandingPage());
        }
    }
}
