using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    public interface ISalaryByCountry
    {
        //interface for strategy pattern - ensures all tax calculations use a common method
        public decimal CalculateMonthlySalary(decimal annualSalary);
    }
}