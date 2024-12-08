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
    public partial class FrmHRViewSelectedRequest : Form
    {
        public FrmHRViewSelectedRequest(UpdateRequest selectedRequest)
        {
            InitializeComponent();
            txtEmpID.Text=selectedRequest.employeeID;
            txtSubmissionDate.Text=Convert.ToString(selectedRequest.dateSubmitted);
            txtRequestTitle.Text=selectedRequest.requestTitle;
            rtxtRequestDetails.Text=selectedRequest.requestInformation;
            cbxRequestStatus.Text=selectedRequest.requestStatus;
        }

        private void btnSaveStatusChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbxRequestStatus.SelectedItem.ToString());
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE TableEmployeeRequests SET RequestStatus= @rs WHERE EmployeeID=@id";
            //parameterised queries for information needed for table
            cmd.Parameters.AddWithValue("@rs", cbxRequestStatus.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@id", txtEmpID.Text);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            DialogResult res = MessageBox.Show("Status has been changed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
