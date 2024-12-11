using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class RussiaSalary : ISalaryByCountry
    {
        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal SalaryAfterTax;
            if (annualSalary <0 && annualSalary >=37212.48M)
            {
                SalaryAfterTax = annualSalary * 0.87M;
                return SalaryAfterTax/12;
            }
            else
            {
                SalaryAfterTax = annualSalary * 0.85M;
                return SalaryAfterTax/12;
            }
        }
    }
}
