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
    public partial class FrmHRViewUpdateRequests : Form
    {
        public FrmHRViewUpdateRequests()
        {
            InitializeComponent();
        }

        private void FrmHRViewUpdateRequests_Load(object sender, EventArgs e)
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

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRequest selectedRequest = new UpdateRequest(Convert.ToString(dgvViewRequests.SelectedCells[1].Value), Convert.ToDateTime(dgvViewRequests.SelectedCells[2].Value), Convert.ToString(dgvViewRequests.SelectedCells[3].Value), Convert.ToString(dgvViewRequests.SelectedCells[4].Value), Convert.ToString(dgvViewRequests.SelectedCells[5].Value), Convert.ToString(dgvViewRequests.SelectedCells[6].Value));
            FormManagement.NavigateToNextForm(this, new FrmHRViewSelectedRequest(selectedRequest));

        }
    }
}
