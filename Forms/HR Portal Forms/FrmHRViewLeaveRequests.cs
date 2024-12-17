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

namespace HR_Global_System.Forms.HR_Portal_Forms
{
    public partial class FrmHRViewLeaveRequests : Form
    {
        public FrmHRViewLeaveRequests()
        {
            //retrieval of correct records as per the HR lead's country
            InitializeComponent();
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = HRDatabase.mdb";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * From TableLeaveRequests WHERE CountryOfRequester=@cor";
            cmd.Parameters.AddWithValue("@cor", SessionManager.Instance._countryOfUser);
            con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvViewLeaveRequests.DataSource = bindingSource;
            con.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //new LeaveRequest type object created using details of selected record as per requirement of one for the form which is navigated to
        {
            LeaveRequest selectedLeaveRequest = new LeaveRequest(Convert.ToString(dgvViewLeaveRequests.SelectedCells[1].Value),Convert.ToDateTime(dgvViewLeaveRequests.SelectedCells[2].Value), Convert.ToDateTime(dgvViewLeaveRequests.SelectedCells[3].Value), Convert.ToString(dgvViewLeaveRequests.SelectedCells[4].Value), Convert.ToString(dgvViewLeaveRequests.SelectedCells[5].Value), Convert.ToString(dgvViewLeaveRequests.SelectedCells[6].Value));
            FormManagement.NavigateToNextForm(this, new FrmHRViewSelectedLeaveRequest(selectedLeaveRequest));
        }

        private void btnBackToHRLanding_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, new FrmHRLandingPage());
        }
    }
}
