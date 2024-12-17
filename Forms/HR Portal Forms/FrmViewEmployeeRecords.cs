using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HR_Global_System
{
    public partial class FrmViewEmployeeRecords : Form
    {
       public HRPortalEmployeeRelatedMethods employeeMethodsHandler = new HRPortalEmployeeRelatedMethods();
        public FrmViewEmployeeRecords()
        {
            InitializeComponent();
        }
        private void FrmViewEmployeeRecords_Load(object sender, EventArgs e) //methods for retrieving employee records for employees in the same country as HR lead + checking and deleting any archived records in line with GDPR
        {
            employeeMethodsHandler.RetrieveEmpData(dgvAllEmployeeRecords);
            employeeMethodsHandler.CheckAndDeleteArchivedEmpRecords();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) //instantiation of new Employee object using data from selected record- passed to form responsible for handling edits
        {
            Employee selectedEmployee = new Employee(Convert.ToString(dgvAllEmployeeRecords.SelectedCells[0].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[1].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[2].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[3].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[4].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[5].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[6].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[7].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[8].Value), Convert.ToDecimal(dgvAllEmployeeRecords.SelectedCells[9].Value), Convert.ToDecimal(dgvAllEmployeeRecords.SelectedCells[10].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[11].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[12].Value));
            FormManagement.NavigateToNextForm(this, new FrmEditEmployeeInfo(selectedEmployee));
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //employee ID of selected record passed to method which manages deletion of records, and records retrieved again to show most up-to-date version of records
        {
            employeeMethodsHandler.DeleteSelectedEmpRecord(Convert.ToString(dgvAllEmployeeRecords.SelectedCells[0].Value));
            employeeMethodsHandler.RetrieveEmpData(dgvAllEmployeeRecords);
        }

        private void btnBackFromViewEmpRecords_Click(object sender, EventArgs e) //navigation back to landing page
        {
            FormManagement.MoveBackToPreviousForm(this, new FrmHRLandingPage());
        }
    }
}
