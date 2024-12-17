using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System
{
    public class UpdateRequest
    {
        //query used in db related methods below, protected to limit access appropriately
        protected string dbConnection= "Provider = Microsoft.JET.OLEDB.4.0; Data Source = HRDatabase.mdb";

        //attributes for UpdateRequest type object
        private string _employeeID;
        private DateTime _dateSubmitted;
        private string _requestTitle;
        private string _requestInformation;
        private string _requestStatus;
        private string _countryOfRequester;

        //constructor for UpdateRequest type object
        public UpdateRequest (string employeeID, DateTime dateSubmitted, string requestTitle, string requestInformation, string requestStatus, string countryOfRequester)
        {
            this._employeeID = employeeID;
            this._dateSubmitted = dateSubmitted;
            this._requestTitle = requestTitle;
            this._requestInformation = requestInformation;
            this._requestStatus = requestStatus;
            this._countryOfRequester = countryOfRequester;
        }

        //getters and setters for each UpdateRequest object attribute
        //allows for more controlled access compared to public attributes (encapsulation) + provides flexibility to change accessibility of individual attributes
        public UpdateRequest() { }

        public string employeeID
        {
            get
            {
                return this._employeeID;
            }
            set
            {
                this._employeeID = value;
            }
        }

        public DateTime dateSubmitted
        {
            get
            {
                return this._dateSubmitted;
            }
            set
            {
                this._dateSubmitted = value;
            }
        }

        public string requestTitle
        {
            get
            {
                return this._requestTitle;
            }
            set
            {
                this._requestTitle = value;
            }
        }

        public string requestInformation
        {
            get
            {
                return this._requestInformation;
            }
            set
            {
                this._requestInformation = value;
            }
        }

        public string requestStatus
        {
            get
            {
                return this._requestStatus;
            }
            set
            {
                this._requestStatus = value;
            }
        }

        public string countryOfRequester
        {
            get
            {
                return this._countryOfRequester;
            }
            set
            {
                this._countryOfRequester = value;
            }
        }

        //behaviours related to CRUD of update requests

        //method/behaviour for viewing all update request records for the HR lead's country in a data grid view
        public void ViewRequestRecords(DataGridView dgvViewRequests)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = dbConnection;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * From TableEmployeeRequests WHERE CountryOfRequester=@cor";
            cmd.Parameters.AddWithValue("@cor", SessionManager.Instance._countryOfUser);
            con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvViewRequests.DataSource = bindingSource;
            con.Close();
        }

        //method/behaviour for employee to send a new update request to the HR lead via the database
        public void SendUpdateRequestToDB(UpdateRequest newUpdateRequest)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = dbConnection;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO TableEmployeeRequests (EmployeeID,DateSubmitted,RequestTitle,RequestInformation,RequestStatus,CountryOfRequester) 
            VALUES (@id,@ds,@rt,@ri,@rs,@cor)";
            cmd.Parameters.AddWithValue("@id", newUpdateRequest.employeeID);
            cmd.Parameters.AddWithValue("@ds", newUpdateRequest.dateSubmitted);
            cmd.Parameters.AddWithValue("@rt", newUpdateRequest.requestTitle);
            cmd.Parameters.AddWithValue("@ri", newUpdateRequest.requestInformation);
            cmd.Parameters.AddWithValue("@rs", newUpdateRequest.requestStatus);
            cmd.Parameters.AddWithValue("cor",newUpdateRequest.countryOfRequester);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            DialogResult res = MessageBox.Show("Request has been submitted to your HR lead");
        }

        //method/behaviour for changes to the request status to be made by HR lead as needed (rejected/completed.etc)
        public void SaveStatusChange(string requestStatus, string empID)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = dbConnection;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE TableEmployeeRequests SET RequestStatus= @rs WHERE EmployeeID=@id";
            //parameterised queries for information needed for table
            cmd.Parameters.AddWithValue("@rs", requestStatus);
            cmd.Parameters.AddWithValue("@id", empID);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            DialogResult res = MessageBox.Show("Status has been changed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
