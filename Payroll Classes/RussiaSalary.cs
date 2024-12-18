using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class RussiaSalary : ISalaryByCountry
    {
        //concrete strategy for Russia
        //implements interface and applies Russia tax brackets (found online) to return take-home pay for the month depending on annual base salary for employees with Russia base country
        //Follows LSP- definition of CalculateMonthlySalary below means that this class (child class of ISalaryByCountry) can uphold behaviour of the parent class
        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal SalaryAfterTax;
            if (annualSalary > 0 && annualSalary <= 37212.48M)
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
