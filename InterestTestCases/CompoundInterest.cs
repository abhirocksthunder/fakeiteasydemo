using System;
using System.Collections.Generic;
using System.Text;

namespace InterestTestCases
{
    class CompoundInterest
    {
        double Total = 0, _interestRate, _years, _annualCompound, _amount;
        public CompoundInterest(double interestRate, double years, double annualCompound, double amount)
        {
            _interestRate = interestRate;
            _years = years;
            _annualCompound = annualCompound;
            _amount = amount;
        }

        public double calculateInterest()
        {
            for (int t = 1; t < _years + 1; t++)
            {
                Total = Total + _amount * Math.Pow((1 + _interestRate / _annualCompound),
                                         (_annualCompound * t));               

            }

            return Total;
        }
    }
}
