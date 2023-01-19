using NUnit.Framework;
using System;
using TestSquare;
using TestSquare.Figure;

namespace TestProject
{
    public class CircleTest
    {
        [Test]
        public void Circle_NotValidRadius()
        {
            Assert.Throws<Exception>(() => ShapeCalc.CalcSquare(new Circle(-2)));
        }

        [Test]
        public void Ñircle_ValidRadius_CorrectArea()
        {
            Assert.AreEqual(78.5d, ShapeCalc.CalcSquare(new Circle(5)), 0.1);
        }
    }
}