using HR_Global_System.Forms;
using HR_Global_System.Forms.HR_Portal_Forms;
using HR_Global_System.Forms.Self_Service_Portal_Forms;
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

namespace HR_Global_System
{
    public partial class FrmSelfServiceLandingPage : Form
    {
        //new employee object instantiated for storing/retrieving info related to the logged in user of the ss portal
        public Employee fetchedEmployeeDetails = Employee.CreateEmpObject(SessionManager.Instance._IDOfUser);
        public FrmSelfServiceLandingPage()
        {
            //load/populate all necessary components of the Form
            InitializeComponent();
            lblSelfServiceID.Text = $"Employee ID: {fetchedEmployeeDetails.employeeID}";
            lblSelfServicePassword.Text = $"Password: *******";
            lblSelfServiceFirstName.Text = $"First Name: {fetchedEmployeeDetails.firstName}";
            lblSelfServiceSurname.Text = $"Surname: {fetchedEmployeeDetails.surname}";
            lblSelfServiceGender.Text = $"Gender: {fetchedEmployeeDetails.gender}";
            lblSelfServiceEmail.Text = $"Email Address: {fetchedEmployeeDetails.emailAddress}";
            lblSelfServiceNumber.Text = $"Contact Number: {fetchedEmployeeDetails.phoneNumber}";
            lblSelfServiceJobTtitle.Text = $"Job Title: {fetchedEmployeeDetails.jobTitle}";
            lblSelfServiceManager.Text = $"Manager: {fetchedEmployeeDetails.manager}";
            lblSelfServiceAnnualSalary.Text = $"Annual Salary (before tax): {Convert.ToString(fetchedEmployeeDetails.annualSalary)}";
            lblSelfServicePaidLeave.Text = $"Paid Leave Entitlement (hours): {Convert.ToString(fetchedEmployeeDetails.totalPaidLeave)}";
            lblSelfServiceJobGrade.Text = $"Profession Grade: {fetchedEmployeeDetails.jobGrade}";
            lblSelfServiceBaseCountry.Text = $"Base Country: {fetchedEmployeeDetails.baseCountry}";
            btnSelfServicePassword.Text = "Show Password";


        }

        private void btnSelfServicePassword_Click(object sender, EventArgs e) //method for keeping password hidden if chosen for security, particularly in public settings
        {
            if (btnSelfServicePassword.Text == "Show Password")
            {
                lblSelfServicePassword.Text = $"Password: {fetchedEmployeeDetails.password}";
                btnSelfServicePassword.Text = "Hide Password";
            }
            else if (btnSelfServicePassword.Text == "Hide Password")
            {
                lblSelfServicePassword.Text = $"Password: *******";
                btnSelfServicePassword.Text = "Show Password";

            }
        }

        private void btnSelfServiceUpdate_Click(object sender, EventArgs e) //navigation to page for requesting updates to details
        {
            FormManagement.NavigateToNextForm(this,new FrmRequestInfoUpdates());

        }

        private void btnBackFromSSLanding_Click(object sender, EventArgs e) //navigation out of ss portal, back to landing page
        {
            DialogResult res = MessageBox.Show("Are you sure you want to go back? Proceeding will log you out of the portal.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new FrmSelfServiceLogin());
            }
        }

        private void btnViewPersonalRequests_Click(object sender, EventArgs e) //navigation to page to view all previous + current update requests, details about them including status
        {
            FormManagement.NavigateToNextForm(this, new FrmViewPersonalUpdateRequests());
        }

        private void btnRequestLeave_Click(object sender, EventArgs e) //navigation to page on which employee can request leave
        {
            FormManagement.NavigateToNextForm(this, new FrmSubmitLeaveRequest());
        }

        private void btnViewLeave_Click(object sender, EventArgs e) //navigation to page on which employee can view all previous + current leave including status and other details
        {
            FormManagement.NavigateToNextForm(this, new FrmViewPersonalLeave());
        }

        private void btnViewSalary_Click(object sender, EventArgs e) //navigation to page which employee can use to view their monthly take-home pay in GBP
        {
            FormManagement.NavigateToNextForm(this, new FrmViewMySalary());

        }

        private void btnSSLogout_Click(object sender, EventArgs e) //end session/log out of portal
        {
            DialogResult res = MessageBox.Show("Are you sure you would like to log out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                SessionManager.Instance.FinishSession();
            }

        }
    }
}
