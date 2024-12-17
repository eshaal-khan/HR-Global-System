using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class EgyptSalary : ISalaryByCountry
    {
        //concrete strategy for Egypt
        //implements interface and applies Egypt tax brackets (found online) to return take-home pay for the month depending on annual base salary for employees with Egypt base country
        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal salaryAfterTax;
            if (annualSalary > 0 && annualSalary <= 619.62M)
            {
                return annualSalary / 12;
            }
            else if (annualSalary > 619.62M && annualSalary <= 852.42M)
            {
                salaryAfterTax = annualSalary * 0.9M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 852.42M && annualSalary <= 1084.90M)
            {
                salaryAfterTax = annualSalary * 0.85M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 1084.90M && annualSalary <= 3100.31M)
            {
                salaryAfterTax = annualSalary * 0.8M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 3100.31M && annualSalary <= 6200.63M)
            {
                salaryAfterTax = annualSalary * 0.775M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 6200.63M && annualSalary <= 18602.25M)
            {
                salaryAfterTax = annualSalary * 0.75M;
                return salaryAfterTax / 12;
            }
            else
            {
                salaryAfterTax = annualSalary * 0.725M;
                return salaryAfterTax / 12;
            }
        }
    }
}
