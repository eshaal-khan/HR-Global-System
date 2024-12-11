using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class PolandSalary : ISalaryByCountry
    {
        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal salaryAfterTax;
            if (annualSalary < 0 && annualSalary >= 5784.15M)
            {
                return annualSalary / 12;
            }
            else if (annualSalary < 5784.15M && annualSalary >= 23136.60M)
            {
                salaryAfterTax = annualSalary * 0.88M;
                return salaryAfterTax / 12;
            }
            else
            {
                salaryAfterTax = annualSalary * 0.68M;
                return salaryAfterTax / 12;
            }
        }
    }
}
