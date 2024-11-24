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
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;
        public FrmViewEmployeeRecords(string baseCountry)
        {
            InitializeComponent();
        }
        private void FrmViewEmployeeRecords_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * From TableEmployeeInfo WHERE BaseCountry={baseCountry}";
            cmd.Parameters.AddWithValue("@baseCountry",baseCountry)
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvAllEmployeeRecords.DataSource = bindingSource;
            con.Close();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee selectedEmployee = new Employee(Convert.ToString(dgvAllEmployeeRecords.SelectedCells[0].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[1].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[2].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[3].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[4].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[5].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[6].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[7].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[8].Value), Convert.ToDecimal(dgvAllEmployeeRecords.SelectedCells[9].Value), Convert.ToDecimal(dgvAllEmployeeRecords.SelectedCells[10].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[11].Value), Convert.ToString(dgvAllEmployeeRecords.SelectedCells[12].Value));
            FrmEditEmployeeInfo editEmployee = new FrmEditEmployeeInfo(selectedEmployee);
            FormManagement.NavigateToNextForm(this, editEmployee);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stores ID of staff member clicked on in variable
            int employeeID = Convert.ToInt32(dgvAllEmployeeRecords.SelectedCells[0].Value);
            //opening connection with database
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            //SQL for deleting the record where the ID is the one in the variable above
            cmd.CommandText = @"DELETE FROM TableEmployeeInfo WHERE LoginNumber= @id";
            cmd.Parameters.AddWithValue("@id", employeeID); //parameterised query
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            //retrieveData();
            //shows message to user that deleting has been done successfully- if not, prints an error message
            DialogResult res = MessageBox.Show("Employee record deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                this.Visible = false;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
