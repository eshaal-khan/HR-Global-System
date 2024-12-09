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
    public partial class FrmHRViewSelectedLeaveRequest : Form
    {
        public FrmHRViewSelectedLeaveRequest(LeaveRequest selectedLeaveRequest)
        {
            InitializeComponent();
            txtEmpID.Text=selectedLeaveRequest.requesterID;
            txtStartDate.Text=Convert.ToString(selectedLeaveRequest.dateFrom.Date);
            txtEndDate.Text = Convert.ToString(selectedLeaveRequest.dateTill.Date);
            txtReason.Text=selectedLeaveRequest.leaveReason;
            rtxtAdditionalNotes.Text=selectedLeaveRequest.additionalNotes;
            cbxStatus.Text=selectedLeaveRequest.requestStatus;
        }

        private void btnSaveStatusChange_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE TableLeaveRequests SET Status=@st,AdditionalNotes=@an WHERE RequesterID=@id";
            //parameterised queries for information needed for table
            cmd.Parameters.AddWithValue("@st", cbxStatus.Text);
            cmd.Parameters.AddWithValue("@an", rtxtAdditionalNotes.Text);
            cmd.Parameters.AddWithValue("@id", txtEmpID.Text);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            DialogResult res = MessageBox.Show("Changes have been made", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormManagement.MoveBackToPreviousForm(this, new FrmHRViewLeaveRequests());
        }
    }
}
