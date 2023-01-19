using TestSquare.Abstract;
using TestSquare.Helper;

namespace TestSquare.Figure
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(double radius) => Radius = radius;
    }
}
