using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    public abstract class Account : IInterestingCalculator
    {
        public string Type { get; set; }

        public double Balance { get; set; }

        public double Interest { get; set; }

        public virtual void CalculateInteresting(double index)
        {
            Interest = Balance * index;
        }
        
    }
}
