using System;

namespace TestSquare.Command.Impl
{
    class TriangleHasRightAngleCommand<T> : IAngleCommand<T, bool> where T : Figure.Triangle
    {
        public bool Handle(T shape)
        {
            return HasRightAngle(shape);
        }

        public bool HasRightAngle(T shape)
        {
            if (shape.SideA > shape.SideB && shape.SideA > shape.SideC)
            {
                return Math.Sqrt(shape.SideB * shape.SideB + shape.SideC * shape.SideC) == shape.SideA;
            }
            else if (shape.SideB > shape.SideA && shape.SideB > shape.SideC)
            {
                return Math.Sqrt(shape.SideA * shape.SideA + shape.SideC * shape.SideC) == shape.SideB;
            }
            else
            {
                return Math.Sqrt(shape.SideA * shape.SideA + shape.SideB * shape.SideB) == shape.SideC;
            }
        }
    }
}
