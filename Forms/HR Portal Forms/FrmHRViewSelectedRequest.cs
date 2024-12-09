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
        HRUpdateRequestsMethods requestHandlingMethods;
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
            requestHandlingMethods.SaveStatusChange(cbxRequestStatus.SelectedItem.ToString(),txtEmpID.Text);
        }
    }
}
