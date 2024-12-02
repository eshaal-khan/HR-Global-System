using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace HR_Global_System
{
    public sealed class SessionManager
    {

        private static SessionManager instance = null;
        private static readonly object padlock = new object();
        public string _IDOfUser { get; private set; }
        public string _jobOfUser { get; private set; }
        public string _countryOfUser { get; private set; }
        private SessionManager() { }
        public static SessionManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SessionManager();
                    }
                    return instance;
                }
        }   }
        
        public void CreateSession(string userID, string userJobTitle, string userCountry)
        {
            this._IDOfUser = userID;
            this._jobOfUser = userJobTitle;
            this._countryOfUser = userCountry;
        }

        public void FinishSession()
        {
            _IDOfUser = null;
            _jobOfUser = null;
            _countryOfUser = null;
            Application.Exit();

        }
    }
}
