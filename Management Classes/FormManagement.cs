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
        //Facade pattern - class used to manage and hide complexities of moving between 2 forms both ways (to next form and back)
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
