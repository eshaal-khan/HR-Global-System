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
            Dictionary<string, int> jobRolesCount = HRPortalEmployeeFunctionality.PopulateJobRolesCountChart();
            HRPortalEmployeeFunctionality.PopulateChart(jobRolesCount,chtHeadcountByJob);
        }
    }
}
