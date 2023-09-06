using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Square_Radius1_ReturnedCorrect()
        {
            double expected = Math.PI;
            double epsilon = 1E-6;
            var circle = new Circle(1);
            double result = circle.Square();
            Assert.Equal(expected, result,epsilon);
        }

        [Fact]
        public void Square_Radius2_ReturnedCorrect()
        {
            double expected = 12.56637;
            double epsilon = 1E-6;
            var circle = new Circle(2);
            double result = circle.Square();
            Assert.Equal(expected, result, epsilon);
        }

        [Fact]
        public void CircleConstructor_RadiusMinus5_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}
