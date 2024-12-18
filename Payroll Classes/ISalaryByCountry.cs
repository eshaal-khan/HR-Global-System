using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    public interface ISalaryByCountry
    {
        //interface for strategy pattern - ensures all tax calculations use a common method
        //declares algorithms common to the strategies - here it is calculating monthly salary after tax based on each country's tax brackets
        //Follows ISP- rather than polluting the ILogin interface with this method, a separate, smaller interface was made

        decimal CalculateMonthlySalary(decimal annualSalary);
    }
}