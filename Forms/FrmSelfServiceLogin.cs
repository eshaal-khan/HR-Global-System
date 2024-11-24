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
    public partial class FrmSelfServiceLogin : Form
    {
        public FrmSelfServiceLogin()
        {
            InitializeComponent();
        }

        private void btnSelfServiceSignIn_Click(object sender, EventArgs e)
        {
            FrmSelfServiceLandingPage selfServiceLandingPage = new FrmSelfServiceLandingPage(Convert.ToString(txtSelfServiceUsername.Text));
            FormManagement.NavigateToNextForm(this,  selfServiceLandingPage );
        }
    }
}
