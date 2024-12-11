using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class FranceSalary : ISalaryByCountry
    {
        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal salaryAfterTax;
            if (annualSalary < 0 && annualSalary >= 9296.83M)
            {
                return annualSalary / 12;
            }
            else if (annualSalary < 9296.83M && annualSalary >= 23704.68M)
            {
                salaryAfterTax = annualSalary * 0.89M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary < 23704.68M && annualSalary >= 67780.23M)
            {
                salaryAfterTax = annualSalary * 0.7M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary < 67780.23M && annualSalary >= 145787.46M)
            {
                salaryAfterTax = annualSalary * 0.59M;
                return salaryAfterTax / 12;
            }
            else
            {
                salaryAfterTax = annualSalary * 0.55M;
                return salaryAfterTax / 12;
            }
        }
    }
}
