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
       public UpdateRequest requestMethodsHandler=new UpdateRequest();
        public FrmHRViewUpdateRequests()
        {
            InitializeComponent();
            requestMethodsHandler.ViewRequestRecords(dgvViewRequests); //retrieval of all update personal info requests for employees in the HR lead's country

        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e) //new UpdateRequest type object created using info from selected record for passing to next form
        {
            UpdateRequest selectedRequest = new UpdateRequest(Convert.ToString(dgvViewRequests.SelectedCells[1].Value), Convert.ToDateTime(dgvViewRequests.SelectedCells[2].Value), Convert.ToString(dgvViewRequests.SelectedCells[3].Value), Convert.ToString(dgvViewRequests.SelectedCells[4].Value), Convert.ToString(dgvViewRequests.SelectedCells[5].Value), Convert.ToString(dgvViewRequests.SelectedCells[6].Value));
            FormManagement.NavigateToNextForm(this, new FrmHRViewSelectedRequest(selectedRequest));

        }

        private void btnBackToHRLanding_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, new FrmHRLandingPage());
        }
    }
}
