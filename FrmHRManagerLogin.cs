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
    public partial class FrmHRManagerLogin : Form
    {
        public FrmHRManagerLogin()
        {
            InitializeComponent();
        }

        private void btnHRManagerSignIn_Click(object sender, EventArgs e)
        {
            FrmHRLandingPage HRLandingPage = new FrmHRLandingPage();
            HRLandingPage.ShowDialog();
        }
    }
}
