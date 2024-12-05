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
        }

        private void FrnViewAnalytics_Load(object sender, EventArgs e)
        {
            //methods for job roles count in the country
            Dictionary<string, int> jobRolesCount = AnalyticsAndDataMethods.FetchRoleHeadcountData();
            AnalyticsAndDataMethods.PopulateBarChart(jobRolesCount, chtHeadcountByJob, "Employee Count");

            //methods for pie chart about profession grades in the country
            Dictionary<string, int> professionGradeCounts = AnalyticsAndDataMethods.FetchProfessionGradeCounts();
            AnalyticsAndDataMethods.PopulateBarChart(professionGradeCounts, chtProfessionGrades, "Employee Count");

            //methods for headcounts in each country
            Dictionary<string,int> countryEmployeesCount=AnalyticsAndDataMethods.FetchCountryHeadcountData();
            AnalyticsAndDataMethods.PopulateBarChart(countryEmployeesCount, chtCountryHeadcounts,"Employee Count");

            //methods for salary total per role
            Dictionary<string,decimal> salaryTotals =AnalyticsAndDataMethods.FetchTotalSalaryValues();
            AnalyticsAndDataMethods.PopulateSalaryBarChart(salaryTotals, chtMoneyPerRole, "Money (£)");

            //methods for gender counts
            Dictionary<string, int> genderCount = AnalyticsAndDataMethods.FetchGenderCounts();
            AnalyticsAndDataMethods.ShowGenderCount(lblGenRepMaleCount, lblGenRepFemaleCount, lblGenRepOtherCount,genderCount);

        }

        private void btnBackFromHRLanding_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, new FrmHRLandingPage());
        }
    }
}
