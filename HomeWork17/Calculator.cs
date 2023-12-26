using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    public class Calculator
    {
        public void SetInterest(IInterestingCalculator account)
        {
            double coefficient = 0;
            switch (account)
            {
                case OrdinaryAccount:
                    coefficient =0.4;
                    break;
                case SalatyAccount:
                    coefficient = 0.5;
                    break;
                default:
                    break;
            }
            account.CalculateInteresting(coefficient);
        }

    }
}
