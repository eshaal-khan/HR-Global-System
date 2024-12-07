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
        private string _employeeID;
        private DateTime _dateSubmitted;
        private string _requestTitle;
        private string _requestInformation;
        private string _requestStatus;
        private string _countryOfRequester;

        public UpdateRequest (string employeeID, DateTime dateSubmitted, string requestTitle, string requestInformation, string requestStatus, string countryOfRequester)
        {
            this._employeeID = employeeID;
            this._dateSubmitted = dateSubmitted;
            this._requestTitle = requestTitle;
            this._requestInformation = requestInformation;
            this._requestStatus = requestStatus;
            this._countryOfRequester = countryOfRequester;
        }

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

        public void SendUpdateRequestToDB(UpdateRequest newUpdateRequest)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =HRDatabase.mdb";
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
    }
}
