using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Login_Classes
{
    public abstract class LoginDecorator:ILogin
    {
        //abstract class implementing ILogin
        protected ILogin _login;

        public LoginDecorator(ILogin login)
        {
            _login = login;
        }

        public virtual bool ValidateCredentials(string username, string password)
        {
            return _login.ValidateCredentials(username, password);
        }
    }
}
