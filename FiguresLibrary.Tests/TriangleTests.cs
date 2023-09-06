using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Square_SideA2B3C4_ReturnedCorrect()
        {
            double expected = 2.9047375;
            double epsilon = 1E-6;
            var triangle = new Triangle(2, 3, 4);
            double result = triangle.Square();
            Assert.Equal(expected, result, epsilon);
        }

        [Fact]
        public void Square_SideA3B4C5_ReturnedCorrect()
        {
            double expected = 6;
            double epsilon = 1E-6;
            var triangle = new Triangle(3, 4, 5);
            double result = triangle.Square();
            Assert.Equal(expected, result, epsilon);
        }

        [Fact]
        public void IsRectangular_SideA3B4C5_ReturnedTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            bool result = triangle.IsRectangular();
            Assert.True(result);
        }

        [Fact]
        public void IsRectangular_SideA2B3C4_ReturnedFalse()
        {
            var triangle = new Triangle(2, 3, 4);
            bool result = triangle.IsRectangular();
            Assert.False(result);
        }

        [Fact]
        public void TriangleConstructor_SideA1B2C10_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
        }

        [Fact]
        public void TriangleConstructor_SideA1B2Cminus2_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, -2));
        }
    }
}
