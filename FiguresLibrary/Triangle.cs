using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Triangle : IFigure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("One or more sides of triangle is equal or less than zero");
            }
            if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
            {
                throw new ArgumentException("Incorrect sides of triangle");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Square()
        {
            double halfP = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));
        }

        public bool IsRectangular()
        {
            double[] sides = new double[]{ SideA, SideB, SideC};
            double maxSide = sides.Max();
            int maxSideIndex = Array.IndexOf(sides, maxSide);
            if (maxSideIndex != 0)
            {
                (sides[0], sides[maxSideIndex]) = (sides[maxSideIndex], sides[0]);
            }
            double epsilon = 1E-6;
            return Math.Abs(Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < epsilon;
        }
    }
}
