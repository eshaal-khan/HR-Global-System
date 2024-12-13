using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Login_Classes
{
    public interface ILogin
    {
        bool ValidateCredentials(string username, string password);
    }
}
