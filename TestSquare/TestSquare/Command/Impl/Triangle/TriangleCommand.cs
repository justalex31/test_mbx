using System;

namespace TestSquare.Command.Impl
{
    public class TriangleCommand<T> : IShapeCommand<T, double> where T : Figure.Triangle
    {
        public double Area(T shape)
        {
            double semiP = (shape.SideA + shape.SideB + shape.SideC) / 2;
            return Math.Sqrt(semiP * (semiP - shape.SideA) * (semiP - shape.SideB) * (semiP - shape.SideC));
        }

        public double Handle(T shape)
        {
            return Area(shape);
        }
    }
}
