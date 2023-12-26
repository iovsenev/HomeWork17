using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    public class OrdinaryAccount : Account
    {
        public OrdinaryAccount(double balance)
        {
            Balance = balance;
            Type = "Обыкновенный";
        }
        public override void CalculateInteresting(double index)
        {
            Interest = Balance * index;
            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance  >= 1000)
                Interest -= Balance * 0.4;
        }
    }
}
