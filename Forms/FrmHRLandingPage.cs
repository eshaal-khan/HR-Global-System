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
    }
}
