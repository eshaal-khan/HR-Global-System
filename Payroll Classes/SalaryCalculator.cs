using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    public class SalaryCalculator
    {
        //implementation of strategy pattern- classes all to do with calculating take-home pay have differing behaviour based on employee's base country
        //context class for strategy pattern- uses strategy, holds reference to correct strategy object/class and passes it the work
        private ISalaryByCountry _setCountryStrategy;
        public void SetCountry(ISalaryByCountry country)
        {
            _setCountryStrategy=country;
        }

        public decimal CalculateMonthlySalary(decimal annualSalary)
        {
            return _setCountryStrategy.CalculateMonthlySalary(annualSalary);
        }

    }
}
