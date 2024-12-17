using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System
{
    public class FormManagement
    {
        //methods for moving forward/back through the program, reduce repition of code/functionality
        //Follows SRP - purpose of this class is simply to hold methods used for form navigation
        //Follows DRY- eliminates repition of navigation code, simply call the correct method
        public static void NavigateToNextForm(Form presentForm, Form nextForm)
        {
            presentForm.Hide();
            nextForm.ShowDialog();
            presentForm.Close();
        }

        public static void MoveBackToPreviousForm(Form presentForm, Form previousForm)
        {
            presentForm.Hide();
            previousForm.ShowDialog();
            presentForm.Close();
        }

    }
}
