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
        }

        private void btnViewEmployeeRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmViewEmployeeRecords viewEmployeeRecords = new FrmViewEmployeeRecords();
            viewEmployeeRecords.ShowDialog();
            this.Close();
        }

        private void btnCreateEmployeeRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCreateEmployee createEmployee = new FrmCreateEmployee();
            createEmployee.ShowDialog();
            this.Close();
        }
    }
}
