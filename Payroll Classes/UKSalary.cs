using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class UKSalary : ISalaryByCountry
    {
        //concrete strategy for UK
        //implements interface and applies UK tax brackets (found online) to return take-home pay for the month depending on annual base salary for employees with UK base country
        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal salaryAfterTax;
            if (annualSalary >0.00M && annualSalary <= 12570.00M)
            { 
                return annualSalary/12;
            }
            else if (annualSalary >12570.00M && annualSalary<=50270.00M)
            {
                salaryAfterTax = annualSalary * 0.8M;
                return salaryAfterTax / 12;
            }
            else if(annualSalary >50270.00M && annualSalary <=125140.00M)
            {
                salaryAfterTax = annualSalary * 0.6M;
                return salaryAfterTax / 12;
            }
            else
            {
                salaryAfterTax = annualSalary * 0.55M;
                return salaryAfterTax/12;
            }
        }
    }
}
