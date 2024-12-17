using HR_Global_System.Forms;
using HR_Global_System.Forms.HR_Portal_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System
{
    public partial class FrmHRLandingPage : Form
    {
        public FrmHRLandingPage()
        {
            InitializeComponent();
            lblHRLandingPage.Text = ("Welcome to the HR Portal! Use the below options for navigation:");
        }

        //methods for navigating forward, back and logging out depending on button clicked
        private void btnViewEmployeeRecords_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new FrmViewEmployeeRecords());
        }

        private void btnCreateEmployeeRecord_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new FrmCreateEmployee());
        }

        private void btnViewAnalytics_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new FrmViewAnalytics());
        }

        private void btnBackFromHRLanding_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to go back? Proceeding will log you out of the portal.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new FrmHRManagerLogin());
            }
        }

        private void btnHRLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you would like to log out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                SessionManager.Instance.FinishSession();
            }

        }

        private void btnViewUpdateRequests_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new FrmHRViewUpdateRequests());

        }

        private void btnViewLeaveRequests_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new FrmHRViewLeaveRequests());
        }
    }
}
