using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ConsumerLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer Loan is calculated!");
        }
    }
}
