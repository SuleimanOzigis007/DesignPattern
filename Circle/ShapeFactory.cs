using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORYPATTERN.Circle
{
    public class ShapeFactory
    {
        public static IShape CreateShape(ShapeMethod method)
        {
            switch (method)
            {
                case ShapeMethod.Circle:
                    return new Circle();
                case ShapeMethod.Square:
                    return new Square();
                case ShapeMethod.Triangle:
                    return new Triangle();
                case ShapeMethod.Rectangle: 
                    return new Rectangle();
                default:
                    throw new NotSupportedException($"{method} is not currently supported as a shape method.");
            }
        }
    }
}
