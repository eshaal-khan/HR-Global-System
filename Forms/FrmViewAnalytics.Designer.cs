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
            this.chtHeadcountByJob = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGenderRepAnalytics = new System.Windows.Forms.Label();
            this.lblGenRepMaleCount = new System.Windows.Forms.Label();
            this.lblGenRepFemaleCount = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGenRepOtherCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtHeadcountByJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
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
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(961, 930);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Employees";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1032, 567);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Number of Employees at each Profession Grade";
            this.chart2.Titles.Add(title2);
            // 
            // lblGenderRepAnalytics
            // 
            this.lblGenderRepAnalytics.AutoSize = true;
            this.lblGenderRepAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderRepAnalytics.Location = new System.Drawing.Point(954, 73);
            this.lblGenderRepAnalytics.Name = "lblGenderRepAnalytics";
            this.lblGenderRepAnalytics.Size = new System.Drawing.Size(515, 39);
            this.lblGenderRepAnalytics.TabIndex = 2;
            this.lblGenderRepAnalytics.Text = "Gender-Based Representation:";
            // 
            // lblGenRepMaleCount
            // 
            this.lblGenRepMaleCount.AutoSize = true;
            this.lblGenRepMaleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenRepMaleCount.Location = new System.Drawing.Point(955, 147);
            this.lblGenRepMaleCount.Name = "lblGenRepMaleCount";
            this.lblGenRepMaleCount.Size = new System.Drawing.Size(321, 32);
            this.lblGenRepMaleCount.TabIndex = 3;
            this.lblGenRepMaleCount.Text = "Male Employee Count:";
            // 
            // lblGenRepFemaleCount
            // 
            this.lblGenRepFemaleCount.AutoSize = true;
            this.lblGenRepFemaleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenRepFemaleCount.Location = new System.Drawing.Point(955, 206);
            this.lblGenRepFemaleCount.Name = "lblGenRepFemaleCount";
            this.lblGenRepFemaleCount.Size = new System.Drawing.Size(356, 32);
            this.lblGenRepFemaleCount.TabIndex = 4;
            this.lblGenRepFemaleCount.Text = "Female Employee Count:";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 930);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(912, 567);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Salary Funding per Role";
            this.chart1.Titles.Add(title3);
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart3.Legends.Add(legend4);
            this.chart3.Location = new System.Drawing.Point(12, 330);
            this.chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(912, 567);
            this.chart3.TabIndex = 6;
            this.chart3.Text = "chart3";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Total Headcount by Country";
            this.chart3.Titles.Add(title4);
            // 
            // lblGenRepOtherCount
            // 
            this.lblGenRepOtherCount.AutoSize = true;
            this.lblGenRepOtherCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenRepOtherCount.Location = new System.Drawing.Point(955, 264);
            this.lblGenRepOtherCount.Name = "lblGenRepOtherCount";
            this.lblGenRepOtherCount.Size = new System.Drawing.Size(99, 32);
            this.lblGenRepOtherCount.TabIndex = 7;
            this.lblGenRepOtherCount.Text = "Other:";
            // 
            // FrmViewAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2015, 1523);
            this.Controls.Add(this.lblGenRepOtherCount);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblGenRepFemaleCount);
            this.Controls.Add(this.lblGenRepMaleCount);
            this.Controls.Add(this.lblGenderRepAnalytics);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chtHeadcountByJob);
            this.Name = "FrmViewAnalytics";
            this.Text = "FrnViewAnalytics";
            this.Load += new System.EventHandler(this.FrnViewAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtHeadcountByJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtHeadcountByJob;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblGenderRepAnalytics;
        private System.Windows.Forms.Label lblGenRepMaleCount;
        private System.Windows.Forms.Label lblGenRepFemaleCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label lblGenRepOtherCount;
    }
}