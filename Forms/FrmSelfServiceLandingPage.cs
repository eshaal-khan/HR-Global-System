using HR_Global_System.Forms;
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
        //static OleDbConnection con;
        Employee fetchedDetails = HRPortalEmployeeFunctionality.CreateEmployeeObject(SessionManager.Instance._IDOfUser);
        static OleDbCommand cmd=new OleDbCommand();
        static OleDbDataReader reader;
        public FrmSelfServiceLandingPage()
        {
            InitializeComponent();
            //Employee fetchedDetails = HRPortalEmployeeFunctionality.CreateEmployeeObject(SessionManager.Instance._IDOfUser);
            lblSelfServiceID.Text = $"Employee ID: {fetchedDetails.employeeID}";
            lblSelfServicePassword.Text = $"Password: *******";
            lblSelfServiceFirstName.Text = $"First Name: {fetchedDetails.firstName}";
            lblSelfServiceSurname.Text = $"Surname: {fetchedDetails.surname}";
            lblSelfServiceGender.Text = $"Gender: {fetchedDetails.gender}";
            lblSelfServiceEmail.Text = $"Email Address: {fetchedDetails.emailAddress}";
            lblSelfServiceNumber.Text = $"Contact Number: {fetchedDetails.phoneNumber}";
            lblSelfServiceJobTtitle.Text = $"Job Title: {fetchedDetails.jobTitle}";
            lblSelfServiceManager.Text = $"Manager: {fetchedDetails.manager}";
            lblSelfServiceAnnualSalary.Text = $"Annual Salary (before tax): {Convert.ToString(fetchedDetails.annualSalary)}";
            lblSelfServicePaidLeave.Text = $"Paid Leave Entitlement (hours): {Convert.ToString(fetchedDetails.totalPaidLeave)}";
            lblSelfServiceJobGrade.Text = $"Profession Grade: {fetchedDetails.jobGrade}";
            lblSelfServiceBaseCountry.Text = $"Base Country: {fetchedDetails.baseCountry}";
            btnSelfServicePassword.Text = "Show Password";


        }

        private void FrmSelfServiceLandingPage_Load(object sender, EventArgs e)
        {

        }

        private void btnSelfServicePassword_Click(object sender, EventArgs e)
        {
            if (btnSelfServicePassword.Text == "Show Password")
            {
                lblSelfServicePassword.Text = $"Password: {fetchedDetails.password}";
                btnSelfServicePassword.Text = "Hide Password";
            }
            else if (btnSelfServicePassword.Text == "Hide Password")
            {
                lblSelfServicePassword.Text = $"Password: *******";
                btnSelfServicePassword.Text = "Show Password";

            }
        }

        private void btnSelfServiceUpdate_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new FrmSelfServiceUpdate(fetchedDetails));

        }
    }
}
