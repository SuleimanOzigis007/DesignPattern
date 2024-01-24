using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORYPATTERN.Payment
{
    internal class GooglPayPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Successfully paid {amount} to merchant using a google pay");
        }
    }
}
