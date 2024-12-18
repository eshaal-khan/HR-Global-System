using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class AustraliaSalary:ISalaryByCountry
    {
        //concrete strategy for Australia
        //implements interface and applies Australia tax brackets (found online) to return take-home pay for the month depending on annual base salary for employees with Australia base country
        //Follows LSP- definition of CalculateMonthlySalary below means that this class (child class of ISalaryByCountry) can uphold behaviour of the parent class
        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal salaryAfterTax;
            if (annualSalary > 0 && annualSalary <= 9097.45M)
            {
                return annualSalary / 12;
            }
            else if (annualSalary > 9097.45M && annualSalary <= 22493.70M)
            {
                salaryAfterTax = annualSalary * 0.81M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 22493.70M && annualSalary <= 59983.70M)
            {
                salaryAfterTax = annualSalary * 0.675M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 59983.70M && annualSalary <= 89974.80M)
            {
                salaryAfterTax = annualSalary * 0.63M;
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
