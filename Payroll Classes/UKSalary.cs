using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    class UKSalary : ISalaryByCountry
    {
        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            decimal salaryAfterTax;
            if (annualSalary <0 && annualSalary >= 12570)
            { 
                return annualSalary/12; 
            }
            else if (annualSalary <12570 && annualSalary>50270)
            {
                salaryAfterTax = annualSalary * 0.8M;
                return salaryAfterTax / 12;
            }
            else if(annualSalary <50270 && annualSalary >=125140)
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
