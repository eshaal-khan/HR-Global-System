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
    public partial class FrmWelcomePage : Form
    {
        public FrmWelcomePage()
        {
            InitializeComponent();
        }

        private void btnAccessSelfService_Click(object sender, EventArgs e)
        {
            FrmSelfServiceLogin selfServiceLogin = new FrmSelfServiceLogin();
            FormManagement.NavigateToNextForm(this, selfServiceLogin);
        }

        private void btnAccessHRPortal_Click(object sender, EventArgs e)
        {
            FrmHRManagerLogin HRManagerLogin = new FrmHRManagerLogin();
            FormManagement.NavigateToNextForm(this, HRManagerLogin);
        }
    }
}
