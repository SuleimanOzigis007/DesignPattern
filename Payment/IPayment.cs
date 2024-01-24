﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORYPATTERN.Payment
{
    public interface IPayment
    {
        void Pay(double amount);
    }
}
