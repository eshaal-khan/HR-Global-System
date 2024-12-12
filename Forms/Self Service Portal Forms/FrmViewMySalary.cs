using HR_Global_System.Payroll_Classes;
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

namespace HR_Global_System.Forms.Self_Service_Portal_Forms
{
    public partial class FrmViewMySalary : Form
    {
        public FrmViewMySalary()
        {
            InitializeComponent();
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT BaseAnnualSalary From TableEmployeeInfo WHERE LoginNumber=@id";
            cmd.Parameters.AddWithValue("@id", SessionManager.Instance._IDOfUser);
            con.Open();
            object result = cmd.ExecuteScalar();
            con.Close();
            decimal baseAnnualSalary=Convert.ToDecimal(result);
            string country = SessionManager.Instance._countryOfUser;
            ISalaryByCountry salaryByCountry;
            MessageBox.Show(Convert.ToString(baseAnnualSalary));
            switch (country)
            {
                case "UK":
                    salaryByCountry = new UKSalary();
                    break;
                case "Spain":
                    salaryByCountry = new SpainSalary();
                    break;
                case "Russia":
                    salaryByCountry = new RussiaSalary();
                    break;
                case "Poland":
                    salaryByCountry = new PolandSalary();
                    break;
                case "India":
                    salaryByCountry = new IndiaSalary();
                    break;
                case "France":
                    salaryByCountry = new FranceSalary();
                    break;
                case "Egypt":
                    salaryByCountry = new EgyptSalary();
                    break;
                case "Australia":
                    salaryByCountry = new AustraliaSalary();
                    break;
                default:
                    throw new ArgumentException("Your country is not in the system, please contact your HR lead");
            }
            SalaryCalculator salaryCalculator = new SalaryCalculator();
            salaryCalculator.SetCountry(salaryByCountry);
            decimal monthlyTakeHomeSalary= salaryCalculator.CalculateMonthlySalary(baseAnnualSalary);
            txtMonthlySalary.Text = monthlyTakeHomeSalary.ToString();

        }

        private void btnBackFromViewSalary_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new FrmSelfServiceLandingPage());

        }
    }
}
