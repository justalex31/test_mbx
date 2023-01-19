using NUnit.Framework;
using System;
using TestSquare;
using TestSquare.Figure;

namespace TestProject
{
    public class TriangleTests
    {
        [Theory]
        public void Triangle_Not_ValidData()
        {
            Assert.Throws<Exception>(() => ShapeCalc.CalcSquare(new Triangle(3, 4, -1)));
        }

        [Test]
        public void Triangle_Is_Not_Triangle()
        {
            Assert.Throws<Exception>(() => ShapeCalc.CalcSquare(new Triangle(100, 1, 1)));
        }

        [Test]
        [TestCase(3, 4, 5, 6)]
        public void Triangle_Calc_Square(double a, double b, double c, double result)
        {
            Assert.AreEqual(result, ShapeCalc.CalcSquare(new Triangle(a, b, c)), 0.1);
        }

        [Test]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(2, 4, 5, ExpectedResult = false)]
        public bool Triangle_Has_Right_Angle(double a, double b, double c)
        {
            return ShapeCalc.HasRightAngle(new Triangle(a, b, c));
        }
    }
}
