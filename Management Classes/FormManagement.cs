using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System
{
    public class FormManagement
    {
        //this class will manage complexities and navigation between various forms
        public static void NavigateToNextForm(Form presentForm, Form nextForm)
        {
            presentForm.Hide();
            nextForm.ShowDialog();
            presentForm.Close();
        }
    }
}
