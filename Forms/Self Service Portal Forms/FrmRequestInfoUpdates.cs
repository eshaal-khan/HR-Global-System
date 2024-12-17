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
    public partial class FrmRequestInfoUpdates : Form
    {
        public FrmRequestInfoUpdates()
        {
            InitializeComponent();
        }

        private bool IsUpdateRequestCreatable()
        {
            if (string.IsNullOrEmpty(txtRequestTitle.Text) || string.IsNullOrEmpty(rtxtRequestDetails.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e) //instantiation of new UpdateRequest type object for passing to method responsible for adding the request to the database
        {
            DateTime submissionDate= DateTime.Now;
            DateTime submissionDateFormatted = submissionDate.Date;
            bool isObjectCreatable=IsUpdateRequestCreatable();
            if (!isObjectCreatable)
            {
                DialogResult res = MessageBox.Show("Request cannot be created as 1 or more mandatory details are missing", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            }
            else
            {
                UpdateRequest newUpdateRequest = new UpdateRequest(SessionManager.Instance._IDOfUser, submissionDateFormatted, txtRequestTitle.Text, rtxtRequestDetails.Text, "Submitted", SessionManager.Instance._countryOfUser);
                newUpdateRequest.SendUpdateRequestToDB(newUpdateRequest);
                this.Close();

            }
        }

        private void btnBackFromPage_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to go back? Any unsubmitted requests will not be saved.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new FrmSelfServiceLandingPage());
            }
        }

    }
}
