using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class IndiaSalary : ISalaryByCountry
    {
        //concrete strategy for India
        //implements interface and applies India tax brackets (found online) to return take-home pay for the month depending on annual base salary for employees with India base country
        //Follows LSP- definition of CalculateMonthlySalary below means that this class (child class of ISalaryByCountry) can uphold behaviour of the parent class
        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal salaryAfterTax;
            if (annualSalary > 0 && annualSalary <= 2776.83M)
            {
                return annualSalary / 12;
            }
            else if (annualSalary > 2776.83M && annualSalary <= 6479.28M)
            {
                salaryAfterTax = annualSalary * 0.95M;
                return salaryAfterTax/12;
            }
            else if (annualSalary > 6479.28M && annualSalary <= 9256.11M)
            {
                salaryAfterTax = annualSalary * 0.90M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 9256.11M && annualSalary <= 11107.33M)
            {
                salaryAfterTax = annualSalary * 0.85M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 11107.33M && annualSalary <= 13884.16M)
            {
                salaryAfterTax = annualSalary * 0.8M;
                return salaryAfterTax / 12;
            }
            else
            {
                salaryAfterTax = annualSalary * 0.7M;
                return salaryAfterTax / 12;
            }
        }
    }
}
