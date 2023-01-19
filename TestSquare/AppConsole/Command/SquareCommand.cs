using AppConsole.Figure;
using TestSquare.Command;

namespace AppConsole.Command
{
    public class SquareCommand<T> : IShapeCommand<T, double> where T : Square
    {
        public double Area(T shape)
        {
            return shape.SideA * shape.SideB;
        }

        public double Handle(T shape)
        {
            return Area(shape);
        }
    }
}
