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
using System.Windows.Forms.DataVisualization.Charting;

namespace HR_Global_System.Forms.HR_Portal_Forms
{
    public partial class FrmSubmitLeaveRequest : Form
    {
        public FrmSubmitLeaveRequest()
        {
            InitializeComponent();
            cbxLeaveStatus.Text = "Submitted";
        }

        private void btnSubmitLeaveRequest_Click(object sender, EventArgs e) //checks dates entered are logically correct and if so, allows successful submission of request & adds it to database
        {
            if (Convert.ToDateTime(dtpDateFrom.Text) <= DateTime.Now)
            {
                MessageBox.Show("You are trying to submit a request which includes dates which have already passed. Please change the dates and resubmit.");

            }
            else if (Convert.ToDateTime(dtpDateFrom.Text) > Convert.ToDateTime(dtpDateTill.Text))
            {
                MessageBox.Show("Date from selected is later than the selected date until. Please change the dates and resubmit");
            }
            else
            {
                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"INSERT INTO TableLeaveRequests (RequesterID,DateFrom,DateTill,Reason,Status,AdditionalNotes,CountryOfRequester) 
                VALUES (@id,@df,@dt,@re,@st,@an,@cor)";
                    cmd.Parameters.AddWithValue("@id", SessionManager.Instance._IDOfUser);
                    cmd.Parameters.AddWithValue("@df", dtpDateFrom);
                    cmd.Parameters.AddWithValue("@dt", dtpDateTill);
                    cmd.Parameters.AddWithValue("@re", cbxLeaveReason.Text);
                    cmd.Parameters.AddWithValue("@st", cbxLeaveStatus.Text);
                    cmd.Parameters.AddWithValue("@an", rtxtAdditionalNotes.Text);
                    cmd.Parameters.AddWithValue("cor", SessionManager.Instance._countryOfUser);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult res = MessageBox.Show("Leave request has been submitted to your HR lead");

                }
                catch (Exception ex)
                {
                    DialogResult res = MessageBox.Show("Error in processing leave rquest.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                }
            }

        }

        private void btnBackFromHRLanding_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to go back? Any unsubmitted leave requests will not be saved.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new FrmSelfServiceLandingPage());
            }
        }
    }
}
