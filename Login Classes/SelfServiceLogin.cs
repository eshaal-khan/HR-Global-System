using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System.Management_Classes
{
    internal class SelfServiceLogin:LoginBase
    {
        public bool ValidateSelfServiceDetails(string username, string password)
        {
            if (!ValidateDetails(username, password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
