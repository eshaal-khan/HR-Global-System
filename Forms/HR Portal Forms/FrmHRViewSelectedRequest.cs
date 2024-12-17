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
        public UpdateRequest requestMethodsHandler=new UpdateRequest();
        public FrmHRViewSelectedRequest(UpdateRequest selectedRequest)
        {
            //initialisation of components using attributes of UpdateRequest object passed in
            InitializeComponent();
            txtEmpID.Text=selectedRequest.employeeID;
            txtSubmissionDate.Text=Convert.ToString(selectedRequest.dateSubmitted);
            txtRequestTitle.Text=selectedRequest.requestTitle;
            rtxtRequestDetails.Text=selectedRequest.requestInformation;
            cbxRequestStatus.Text=selectedRequest.requestStatus;
        }

        private void btnSaveStatusChange_Click(object sender, EventArgs e) //pass the set status and employee ID to method resonsible for saving status changes of selected update request
        {
            requestMethodsHandler.SaveStatusChange(cbxRequestStatus.SelectedItem.ToString(),txtEmpID.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to go back? Any changes will not be saved.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new FrmHRViewUpdateRequests());
            }
        }
    }
}
