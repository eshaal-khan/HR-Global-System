namespace HR_Global_System
{
    partial class FrmViewAnalytics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewAnalytics));
            this.chtHeadcountByJob = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGenderRepAnalytics = new System.Windows.Forms.Label();
            this.lblGenRepMaleCount = new System.Windows.Forms.Label();
            this.lblGenRepFemaleCount = new System.Windows.Forms.Label();
            this.chtMoneyPerRole = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtCountryHeadcounts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGenRepOtherCount = new System.Windows.Forms.Label();
            this.chtProfessionGrades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBackFromHRLanding = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtHeadcountByJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtMoneyPerRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCountryHeadcounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtProfessionGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // chtHeadcountByJob
            // 
            chartArea1.AxisX.Title = "Job Roles";
            chartArea1.AxisY.Title = "Number of Employees";
            chartArea1.Name = "MainChartArea";
            this.chtHeadcountByJob.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtHeadcountByJob.Legends.Add(legend1);
            this.chtHeadcountByJob.Location = new System.Drawing.Point(961, 330);
            this.chtHeadcountByJob.Name = "chtHeadcountByJob";
            this.chtHeadcountByJob.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "MainChartArea";
            series1.Legend = "Legend1";
            series1.Name = "Employee Count";
            this.chtHeadcountByJob.Series.Add(series1);
            this.chtHeadcountByJob.Size = new System.Drawing.Size(1032, 567);
            this.chtHeadcountByJob.TabIndex = 0;
            this.chtHeadcountByJob.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Total Headcount per Job Role";
            title1.Text = "Total Headcount per Job Role";
            this.chtHeadcountByJob.Titles.Add(title1);
            // 
            // lblGenderRepAnalytics
            // 
            this.lblGenderRepAnalytics.AutoSize = true;
            this.lblGenderRepAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderRepAnalytics.Location = new System.Drawing.Point(1000, 73);
            this.lblGenderRepAnalytics.Name = "lblGenderRepAnalytics";
            this.lblGenderRepAnalytics.Size = new System.Drawing.Size(515, 39);
            this.lblGenderRepAnalytics.TabIndex = 2;
            this.lblGenderRepAnalytics.Text = "Gender-Based Representation:";
            // 
            // lblGenRepMaleCount
            // 
            this.lblGenRepMaleCount.AutoSize = true;
            this.lblGenRepMaleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenRepMaleCount.Location = new System.Drawing.Point(1000, 147);
            this.lblGenRepMaleCount.Name = "lblGenRepMaleCount";
            this.lblGenRepMaleCount.Size = new System.Drawing.Size(321, 32);
            this.lblGenRepMaleCount.TabIndex = 3;
            this.lblGenRepMaleCount.Text = "Male Employee Count:";
            // 
            // lblGenRepFemaleCount
            // 
            this.lblGenRepFemaleCount.AutoSize = true;
            this.lblGenRepFemaleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenRepFemaleCount.Location = new System.Drawing.Point(1000, 206);
            this.lblGenRepFemaleCount.Name = "lblGenRepFemaleCount";
            this.lblGenRepFemaleCount.Size = new System.Drawing.Size(356, 32);
            this.lblGenRepFemaleCount.TabIndex = 4;
            this.lblGenRepFemaleCount.Text = "Female Employee Count:";
            // 
            // chtMoneyPerRole
            // 
            chartArea2.Name = "ChartArea1";
            this.chtMoneyPerRole.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtMoneyPerRole.Legends.Add(legend2);
            this.chtMoneyPerRole.Location = new System.Drawing.Point(12, 930);
            this.chtMoneyPerRole.Name = "chtMoneyPerRole";
            this.chtMoneyPerRole.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Money (£)";
            series2.YValuesPerPoint = 2;
            this.chtMoneyPerRole.Series.Add(series2);
            this.chtMoneyPerRole.Size = new System.Drawing.Size(912, 567);
            this.chtMoneyPerRole.TabIndex = 5;
            this.chtMoneyPerRole.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Total Salary Spent per Job Role (annual, before tax)";
            this.chtMoneyPerRole.Titles.Add(title2);
            // 
            // chtCountryHeadcounts
            // 
            chartArea3.Name = "ChartArea1";
            this.chtCountryHeadcounts.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtCountryHeadcounts.Legends.Add(legend3);
            this.chtCountryHeadcounts.Location = new System.Drawing.Point(12, 330);
            this.chtCountryHeadcounts.Name = "chtCountryHeadcounts";
            this.chtCountryHeadcounts.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Employee Count";
            this.chtCountryHeadcounts.Series.Add(series3);
            this.chtCountryHeadcounts.Size = new System.Drawing.Size(912, 567);
            this.chtCountryHeadcounts.TabIndex = 6;
            this.chtCountryHeadcounts.Text = "chart3";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Total Headcount by Country";
            this.chtCountryHeadcounts.Titles.Add(title3);
            // 
            // lblGenRepOtherCount
            // 
            this.lblGenRepOtherCount.AutoSize = true;
            this.lblGenRepOtherCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenRepOtherCount.Location = new System.Drawing.Point(1000, 264);
            this.lblGenRepOtherCount.Name = "lblGenRepOtherCount";
            this.lblGenRepOtherCount.Size = new System.Drawing.Size(99, 32);
            this.lblGenRepOtherCount.TabIndex = 7;
            this.lblGenRepOtherCount.Text = "Other:";
            // 
            // chtProfessionGrades
            // 
            chartArea4.Name = "ChartArea1";
            this.chtProfessionGrades.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtProfessionGrades.Legends.Add(legend4);
            this.chtProfessionGrades.Location = new System.Drawing.Point(945, 930);
            this.chtProfessionGrades.Name = "chtProfessionGrades";
            this.chtProfessionGrades.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Employee Count";
            this.chtProfessionGrades.Series.Add(series4);
            this.chtProfessionGrades.Size = new System.Drawing.Size(1048, 567);
            this.chtProfessionGrades.TabIndex = 8;
            this.chtProfessionGrades.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Number of Employees per Profession Grade";
            this.chtProfessionGrades.Titles.Add(title4);
            // 
            // btnBackFromHRLanding
            // 
            this.btnBackFromHRLanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFromHRLanding.Image = ((System.Drawing.Image)(resources.GetObject("btnBackFromHRLanding.Image")));
            this.btnBackFromHRLanding.Location = new System.Drawing.Point(1853, 28);
            this.btnBackFromHRLanding.Name = "btnBackFromHRLanding";
            this.btnBackFromHRLanding.Size = new System.Drawing.Size(125, 128);
            this.btnBackFromHRLanding.TabIndex = 9;
            this.btnBackFromHRLanding.UseVisualStyleBackColor = true;
            this.btnBackFromHRLanding.Click += new System.EventHandler(this.btnBackFromHRLanding_Click);
            // 
            // FrmViewAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2015, 1523);
            this.Controls.Add(this.btnBackFromHRLanding);
            this.Controls.Add(this.chtProfessionGrades);
            this.Controls.Add(this.lblGenRepOtherCount);
            this.Controls.Add(this.chtCountryHeadcounts);
            this.Controls.Add(this.chtMoneyPerRole);
            this.Controls.Add(this.lblGenRepFemaleCount);
            this.Controls.Add(this.lblGenRepMaleCount);
            this.Controls.Add(this.lblGenderRepAnalytics);
            this.Controls.Add(this.chtHeadcountByJob);
            this.Name = "FrmViewAnalytics";
            this.Text = "FrnViewAnalytics";
            ((System.ComponentModel.ISupportInitialize)(this.chtHeadcountByJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtMoneyPerRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCountryHeadcounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtProfessionGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtHeadcountByJob;
        private System.Windows.Forms.Label lblGenderRepAnalytics;
        private System.Windows.Forms.Label lblGenRepMaleCount;
        private System.Windows.Forms.Label lblGenRepFemaleCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMoneyPerRole;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCountryHeadcounts;
        private System.Windows.Forms.Label lblGenRepOtherCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtProfessionGrades;
        private System.Windows.Forms.Button btnBackFromHRLanding;
    }
}