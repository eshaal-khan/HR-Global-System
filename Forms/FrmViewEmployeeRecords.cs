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
        HRPortalEmployeeFunctionality employeeFunctionality = new HRPortalEmployeeFunctionality();
        public FrmViewEmployeeRecords()
        {
            InitializeComponent();
        }
        private void FrmViewEmployeeRecords_Load(object sender, EventArgs e)
        {
            employeeFunctionality.RetrieveEmpData(dgvAllEmployeeRecords);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee selectedEmployee = new Employee(Convert.ToString(dgvAllEmployeeRecords.SelectedCells[0].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[1].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[2].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[3].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[4].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[5].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[6].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[7].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[8].Value), Convert.ToDecimal(dgvAllEmployeeRecords.SelectedCells[9].Value), Convert.ToDecimal(dgvAllEmployeeRecords.SelectedCells[10].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[11].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[12].Value));
            FormManagement.NavigateToNextForm(this, new FrmEditEmployeeInfo(selectedEmployee));
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeFunctionality.DeleteSelectedRecord(Convert.ToInt32(dgvAllEmployeeRecords.SelectedCells[0].Value), dgvAllEmployeeRecords);
            employeeFunctionality.RetrieveEmpData(dgvAllEmployeeRecords);
        }
    }
}
