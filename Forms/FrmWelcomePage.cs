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

        //implementation of FormManagement to hide complexities of hiding + closing the current form and opening a new instance of the next one
        private void btnAccessSelfService_Click(object sender, EventArgs e) //navigation to ss login page
        {
            FormManagement.NavigateToNextForm(this, new FrmSelfServiceLogin());
        }

        private void btnAccessHRPortal_Click(object sender, EventArgs e) //navigation to HR login page
        {
            FormManagement.NavigateToNextForm(this, new FrmHRManagerLogin());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to go exit the system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
