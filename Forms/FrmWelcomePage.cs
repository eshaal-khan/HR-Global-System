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
            FormManagement.NavigateToNextForm(this, new FrmSelfServiceLogin());
        }

        private void btnAccessHRPortal_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new FrmHRManagerLogin());
        }
    }
}
