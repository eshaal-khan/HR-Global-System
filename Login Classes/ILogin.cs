using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Login_Classes
{
    //Used for guidance of applicability and application of Decorator pattern: https://www.geeksforgeeks.org/decorator-pattern/
    //Declares method which must be used/implemented in all concrete components + decorators
    public interface ILogin
    {
        bool ValidateCredentials(string username, string password);
    }
}
