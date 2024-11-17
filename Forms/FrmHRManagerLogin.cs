using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System
{
    public partial class FrmHRManagerLogin : Form
    {
        public FrmHRManagerLogin()
        {
            InitializeComponent();
        }

        private void btnHRManagerSignIn_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader reader;
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            //con.Open();
            List<string> IDs = new List<string>();
            using (OleDbConnection connection = new OleDbConnection(con.ConnectionString))
            {
                con.Open();
                using (cmd = new OleDbCommand(@"SELECT * FROM TableEmployeeInfo",con))
                {
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ID = reader.GetString(0);
                            IDs.Add(ID);

                        }
                    }
                }
            }
            foreach (string ID in IDs)
            {
                if (ID == txtHRUsername.Text)
                {
                    OleDbConnection con2;
                    OleDbCommand cmd2;
                    OleDbDataReader reader2;
                    con2 = new OleDbConnection();
                    con2.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
                    cmd2 = new OleDbCommand();
                    cmd2.Connection = con2;
                    cmd2.CommandText = @"SELECT Password FROM TableEmployeeInfo WHERE LoginNumber= @id";
                    cmd2.Parameters.AddWithValue("@id", ID); //parameterised query
                    con2.Open();
                    string expectedPassword = Convert.ToString(cmd2.ExecuteScalar());
                    con2.Close();

                    OleDbConnection con3;
                    OleDbCommand cmd3;
                    OleDbDataReader reader3;
                    con3 = new OleDbConnection();
                    con3.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
                    cmd3 = new OleDbCommand();
                    cmd3.Connection = con3;
                    cmd3.CommandText = @"SELECT JobTtitle FROM TableEmployeeInfo WHERE LoginNumber= @id";
                    cmd3.Parameters.AddWithValue("@id", ID); //parameterised query
                    con.Open();
                    string jobTitle = Convert.ToString(cmd2.ExecuteScalar());
                    con.Close();
                    if (expectedPassword==txtHRPassword.Text)
                    {
                        if (jobTitle=="HR Lead")
                        {
                            DialogResult res = MessageBox.Show("Successful Login!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmHRLandingPage HRLandingPage = new FrmHRLandingPage();
                            HRLandingPage.ShowDialog();

                        }
                    }

                }
            }
        }
    }
}
