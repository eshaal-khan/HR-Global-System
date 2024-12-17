using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class PolandSalary : ISalaryByCountry
    {
        //concrete strategy for Poland
        //implements interface and applies Poland tax brackets (found online) to return take-home pay for the month depending on annual base salary for employees with Poland base country

        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal salaryAfterTax;
            if (annualSalary > 0 && annualSalary <= 5784.15M)
            {
                return annualSalary / 12;
            }
            else if (annualSalary > 5784.15M && annualSalary <= 23136.60M)
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
