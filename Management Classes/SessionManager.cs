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
    //Singleton pattern - only 1 instance of SessionManager can exist at once, i.e. only 1 session at 1 time
    //Increased access control & tracking of key values e.g. ID, title & base country w/o global variable
    //Used the following to understand and implement Singleton pattern- https://csharpindepth.com/articles/singleton
    public sealed class SessionManager
    {
        //holds reference to created instance
        private static SessionManager instance = null;

        //lock needed for instance of SessionManager created
        private static readonly object padlock = new object();
        public string _IDOfUser { get; private set; }
        public string _jobOfUser { get; private set; }
        public string _countryOfUser { get; private set; }
        
        //private, parameterless constructor- prevents other classes from instantiating it & subclassing (both of which would violate the pattern)
        private SessionManager() { }
        
        //used for getting details of the currently existing session
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
        
        //upon successful login, a new session is created and values needed for creating a session are added
        public void CreateSession(string userID, string userJobTitle, string userCountry)
        {
            this._IDOfUser = userID;
            this._jobOfUser = userJobTitle;
            this._countryOfUser = userCountry;
        }

        //once user is done with their session, it is ended + program is closed
        public void FinishSession()
        {
            _IDOfUser = null;
            _jobOfUser = null;
            _countryOfUser = null;
            Application.Exit();

        }
    }
}
