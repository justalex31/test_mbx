using System;
using TestSquare.Figure;

namespace TestSquare.Command.Impl
{
    public class CircleCommand<T> : IShapeCommand<T, double> where T : Circle
    {
        public double Area(T shape)
        {
            return Math.PI * Math.Pow(shape.Radius, 2);
        }

        public double Handle(T shape)
        {
            return Area(shape);
        }
    }
}
