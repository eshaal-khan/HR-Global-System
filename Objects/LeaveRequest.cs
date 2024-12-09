using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Forms.HR_Portal_Forms
{
    public class LeaveRequest
    {
        private string _requesterID;
        private DateTime _dateFrom; 
        private DateTime _dateTill;
        private string _leaveReason;
        private string _requestStatus;
        private string _additonalNotes;

        public LeaveRequest (string requesterID,DateTime dateFrom, DateTime dateTill, string leaveReason, string requestStatus, string additonalNotes)
        {
            this._requesterID = requesterID;
            this._dateFrom = dateFrom;
            this._dateTill = dateTill;
            this._leaveReason = leaveReason;
            this._requestStatus = requestStatus;
            this._additonalNotes = additonalNotes;
        }

        public string requesterID
        {
            get 
            { 
                return _requesterID; 
            } 
            set 
            { 
                _requesterID = value; 
            }
        }
        public DateTime dateFrom
        { 
            get 
            { 
                return this._dateFrom; 
            } 
            set 
            { 
                this._dateFrom = value; 
            } 
        }

        public DateTime dateTill
        {
            get
            {
                return this._dateTill;
            }
            set
            {
                this._dateTill = value;
            }
        }

        public string leaveReason
        {
            get
            {
                return this._leaveReason;
            }
            set
            {
                this._leaveReason = value;
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

        public string additionalNotes
        {
            get
            {
                return this._additonalNotes;
            }
            set
            {
                this._additonalNotes = value;
            }
        }
    }
}
