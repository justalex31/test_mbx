using TestSquare.Abstract;
using TestSquare.Helper;

namespace AppConsole.Figure
{
    public class Square : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Square(double a)
        {
            ValidationHelper.GreaterThanZero(a);

            SideA = a;
            SideB = a;
        }

        public Square(double a, double b)
        {
            ValidationHelper.GreaterThanZero(a);
            ValidationHelper.GreaterThanZero(b);

            SideA = a;
            SideB = b;
        }
    }
}
