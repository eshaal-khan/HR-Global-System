using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Global_System.Payroll_Classes
{
    public class SalaryCalculator
    {
        //context class for strategy pattern
        private ISalaryByCountry _countryStrategy;

        public void SetCountry(ISalaryByCountry country)
        {
            _countryStrategy=country;
        }

        public decimal CalculateMonthlySalary(decimal AnnualSalary)
        {
            return 0.5M;  //run method here e.g. return _votingStrategy.CountVotes(votes);
        }

    }
}
