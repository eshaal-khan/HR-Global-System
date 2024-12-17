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
using System.Windows.Forms.DataVisualization.Charting;
using HR_Global_System.Forms;

namespace HR_Global_System
{
    public partial class FrmViewAnalytics : Form
    {
        public FrmViewAnalytics()
        {
            InitializeComponent();
            //methods for job roles count in the country
            Dictionary<string, int> jobRolesCount = HRAnalyticsPageMethods.FetchRoleHeadcountData();
            HRAnalyticsPageMethods.PopulateBarChart(jobRolesCount, chtHeadcountByJob, "Employee Count");

            //methods for pie chart about profession grades in the country
            Dictionary<string, int> professionGradeCounts = HRAnalyticsPageMethods.FetchProfessionGradeCounts();
            HRAnalyticsPageMethods.PopulateBarChart(professionGradeCounts, chtProfessionGrades, "Employee Count");

            //methods for headcounts in each country
            Dictionary<string, int> countryEmployeesCount = HRAnalyticsPageMethods.FetchCountryHeadcountData();
            HRAnalyticsPageMethods.PopulateBarChart(countryEmployeesCount, chtCountryHeadcounts, "Employee Count");

            //methods for salary total per role
            Dictionary<string, decimal> salaryTotals = HRAnalyticsPageMethods.FetchTotalSalaryValues();
            HRAnalyticsPageMethods.PopulateSalaryBarChart(salaryTotals, chtMoneyPerRole, "Money (£)");

            //methods for gender counts
            Dictionary<string, int> genderCount = HRAnalyticsPageMethods.FetchGenderCounts();
            HRAnalyticsPageMethods.ShowGenderCount(lblGenRepMaleCount, lblGenRepFemaleCount, lblGenRepOtherCount, genderCount);
        }

        private void btnBackFromHRLanding_Click(object sender, EventArgs e) //navigation back to the landing page
        {
            FormManagement.MoveBackToPreviousForm(this, new FrmHRLandingPage());
        }
    }
}
