using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class SpainSalary:ISalaryByCountry
    {
        //concrete strategy for Spain
        //implements interface and applies Spain tax brackets (found online) to return take-home pay for the month depending on annual base salary for employees with Spain base country
        //Follows LSP- definition of CalculateMonthlySalary below means that this class (child class of ISalaryByCountry) can uphold behaviour of the parent class
        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal salaryAfterTax;
            if (annualSalary > 0 && annualSalary <= 10248.40M)
            {
                salaryAfterTax = annualSalary * 0.81M;
                return salaryAfterTax/12;
            }
            else if (annualSalary > 10248.40M && annualSalary <= 16627.93M)
            {
                salaryAfterTax = annualSalary * 0.76M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 16627.93M && annualSalary <= 28975.41M)
            {
                salaryAfterTax = annualSalary * 0.7M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 28975.41M && annualSalary <= 49389.90M)
            {
                salaryAfterTax = annualSalary * 0.63M;
                return salaryAfterTax / 12;
            }
            else if (annualSalary > 49389.90M && annualSalary <= 246989.50M)
            {
                salaryAfterTax = annualSalary * 0.55M;
                return salaryAfterTax / 12;
            }
            else
            {
                salaryAfterTax = annualSalary * 0.53M;
                return salaryAfterTax / 12;
            }
        }
    }
}
