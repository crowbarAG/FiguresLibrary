using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius of the circle is equal or less than zero");
            }
            Radius = radius;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
