using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORYPATTERN.Circle
{
    internal class Square : IShape
    {
        void IShape.Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }
}
