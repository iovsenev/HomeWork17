using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    public class SalatyAccount : Account
    {
        public SalatyAccount(double balance)
        {
            Balance = balance;
            Type = "Зарплатный";
        }
    }
}
