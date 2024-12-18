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
        public FrmViewMySalary() //implementation of the strategy pattern classes
        {
            InitializeComponent();
            lblNote.Text = "Please note this is your salary in GBP (£). Please use a bank-approved converter to calculate the equivalent in your currency";
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"SELECT BaseAnnualSalary From TableEmployeeInfo WHERE LoginNumber=@id";
                cmd.Parameters.AddWithValue("@id", SessionManager.Instance._IDOfUser);
                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();
                decimal baseAnnualSalary = Convert.ToDecimal(result);//retrieve and store annual base salary of logged in user (needed by concrete strategy objects)
                string country = SessionManager.Instance._countryOfUser; //store base country of logged in user so correct strategy object can be selected below
                ISalaryByCountry salaryByCountry; //interface responsible for passing responsibility to correct strategy object
                switch (country) //switch statement responsible for selecting the correct strategy object
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
                        throw new ArgumentException("Your country is not in the system, please contact your HR lead"); //exception handling
                }
                SalaryCalculator salaryCalculator = new SalaryCalculator(); //execution of the correctly selected strategy object
                salaryCalculator.SetCountry(salaryByCountry);
                decimal monthlyTakeHomeSalary = salaryCalculator.CalculateMonthlySalary(baseAnnualSalary);
                txtMonthlySalary.Text = monthlyTakeHomeSalary.ToString(); // display of calculated value returned

            }
            catch (Exception)
            {
                DialogResult res = MessageBox.Show("Error in calculating salary, please check the following details are valid: base annual salary, base country.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

        }

        private void btnBackFromViewSalary_Click(object sender, EventArgs e) //navigation back to the landing page
        {
            FormManagement.NavigateToNextForm(this, new FrmSelfServiceLandingPage());

        }
    }
}
