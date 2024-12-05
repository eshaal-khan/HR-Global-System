using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace HR_Global_System.Forms
{
    internal class AnalyticsAndDataMethods
    {
        //method which takes the values, chart and name of the series and populates the chart (bar chart specific)
        public static void PopulateBarChart(Dictionary<string, int> XYAxisValues, Chart chtToPopulate, string seriesName)
        {

            foreach (var barValue in XYAxisValues)
            {
                chtToPopulate.Series[seriesName].Points.AddXY(barValue.Key, barValue.Value);
            }
        }

        public static void PopulateSalaryBarChart(Dictionary<string, decimal> XYAxisValues, Chart chtToPopulate, string seriesName)
        {

            foreach (var barValue in XYAxisValues)
            {
                chtToPopulate.Series[seriesName].Points.AddXY(barValue.Key, barValue.Value);
            }
        }


        //method for collating the data for headcount per barchart in the country of the HR lead
        public static Dictionary<string, int> FetchRoleHeadcountData()
        {
            string connectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            Dictionary<string, int> XYAxisValues = new Dictionary<string, int>();
            string jobHeadcountQuery = "SELECT JobTitle FROM TableEmployeeInfo WHERE BaseCountry=@baseCountry";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand(jobHeadcountQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@baseCountry", SessionManager.Instance._countryOfUser);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string jobRole = reader["JobTitle"].ToString();
                                if (XYAxisValues.ContainsKey(jobRole))
                                {
                                    XYAxisValues[jobRole]++;
                                }
                                else
                                {
                                    XYAxisValues.Add(jobRole, 1);
                                }
                            }
                        }
                        return XYAxisValues;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error:{ex.Message}");
                    return null;
                }
            }
        }

        //method which is VERY similar to one above, but instead of headcount of people in the country under each job role, it'll be headcount of people in the company under each baseCountry
        public static Dictionary<string, int> FetchCountryHeadcountData()
        {
            string connectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            Dictionary<string, int> XYAxisValues = new Dictionary<string, int>();
            string jobHeadcountQuery = "SELECT BaseCountry FROM TableEmployeeInfo";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand(jobHeadcountQuery, con))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string country = reader["BaseCountry"].ToString();
                                if (XYAxisValues.ContainsKey(country))
                                {
                                    XYAxisValues[country]++;
                                }
                                else
                                {
                                    XYAxisValues.Add(country, 1);
                                }
                            }
                        }
                        return XYAxisValues;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error:{ex.Message}");
                    return null;
                }
            }
        }

        //method for collating the total spent on paying employees in each role in the country > similar to one above but instead of counting number of times mentioned, it adds the baseSalary amounts
        public static Dictionary<string, decimal> FetchTotalSalaryValues()
        {
            string connectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            Dictionary<string, decimal> XYAxisValues = new Dictionary<string, decimal>();
            string salaryByRoleQuery = "SELECT JobTitle,BaseAnnualSalary FROM TableEmployeeInfo WHERE BaseCountry=@baseCountry";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand(salaryByRoleQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@baseCountry", SessionManager.Instance._countryOfUser);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string jobRole = reader["JobTitle"].ToString();
                                decimal baseSalary = Convert.ToDecimal(reader["BaseAnnualSalary"]);
                                if (XYAxisValues.ContainsKey(jobRole))
                                {
                                    XYAxisValues[jobRole] += baseSalary;
                                }
                                else
                                {
                                    XYAxisValues[jobRole] = baseSalary;
                                }
                            }
                        }
                        return XYAxisValues;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error:{ex.Message}");
                    return null;
                }
            }
        }

        //method which get the number of females and males and other employeed in the country
        public static Dictionary<string, int> FetchGenderCounts()
        {
            string connectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            Dictionary<string, int> XYAxisValues = new Dictionary<string, int>();
            string genderCountQuery = "SELECT Gender FROM TableEmployeeInfo WHERE BaseCountry=@baseCountry";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand(genderCountQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@baseCountry", SessionManager.Instance._countryOfUser);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string gender = reader["Gender"].ToString();
                                if (XYAxisValues.ContainsKey(gender))
                                {
                                    XYAxisValues[gender]++;
                                }
                                else
                                {
                                    XYAxisValues.Add(gender, 1);
                                }
                            }
                        }
                        return XYAxisValues;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error:{ex.Message}");
                    return null;
                }
            }
        }

        //method which gets the number of people at each profession grade in the country
        public static Dictionary<string, int> FetchProfessionGradeCounts()
        {
            string connectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            Dictionary<string, int> XYAxisValues = new Dictionary<string, int>();
            string professionGradeCountQuery = "SELECT ProfessionGrade FROM TableEmployeeInfo WHERE BaseCountry=@baseCountry";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand(professionGradeCountQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@baseCountry", SessionManager.Instance._countryOfUser);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string professionGrade = reader["ProfessionGrade"].ToString();
                                if (XYAxisValues.ContainsKey(professionGrade))
                                {
                                    XYAxisValues[professionGrade]++;
                                }
                                else
                                {
                                    XYAxisValues.Add(professionGrade, 1);
                                }
                            }
                        }
                        return XYAxisValues;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error:{ex.Message}");
                    return null;
                }


                //method which displays pie chart data - NOTE may not be needed

            }
        }

        //method which displays gender count data
        public static void ShowGenderCount (Label lblMale, Label lblFemale, Label lblOther, Dictionary <string,int> genderCounts)
        {
            foreach (var entry in genderCounts)
            {
                string gender = entry.Key;
                int count = entry.Value;
                if (gender=="Male")
                {
                    lblMale.Text = $"Male Employee Count: {count}";
                }
                else if (gender=="Female")
                {
                    lblFemale.Text = $"Female Employee Count: {count}";
                }
                else
                {
                    lblOther.Text = $"Other: {count}";
                }
            }
        }
    }
}
