using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System
{
    public class HRSessionManagement
    {
        //this class may potentially be used for condensing functionality for valdiating users
        //potential opportunity to implement an interface between this class and FrmHRManagerLogin - this may require breaking this class into 2 and having 5 components
        //> validation cs's for HR and Self-S (2), Interface for them to interact (1) and an interface between each of the cs's and their respective forms

        public string _nameOfUser { get; set; }
        public string _countryOfUser { get; set; }
    }
}
