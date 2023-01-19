using AppConsole.Command;
using AppConsole.Figure;
using AppConsole.Validation;
using Castle.MicroKernel.Registration;
using System;
using TestSquare;
using TestSquare.Figure;
using TestSquare.Interface;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Circle circle1 = new Circle(-2);
            Console.WriteLine(ShapeCalc.CalcSquare(circle1));*/

            Circle circle = new Circle(4);
            Console.WriteLine(ShapeCalc.CalcSquare(circle));

            Triangle triangle1 = new Triangle(3, 4, 5);
            Console.WriteLine(ShapeCalc.CalcSquare(triangle1));
            Console.WriteLine(ShapeCalc.HasRightAngle(triangle1));

            Triangle triangle2 = new Triangle(2, 4, 5);
            Console.WriteLine(ShapeCalc.HasRightAngle(triangle2));


            //example add own figure
            ShapeCalc.Container.Register(
                Component.For(typeof(ICommandHandler<Square, double>))
                    .ImplementedBy(typeof(SquareCommand<Square>))
                    .Named("squareShapeCommand"));

            ShapeCalc.Container.Register(
                Component.For(typeof(IValidationHandler<Square>))
                    .ImplementedBy(typeof(Square_ValidationOnPositiveSide<Square>))
                    .Named("Square_ValidationOnPositiveSide"));

            Square square = new Square(4);
            Console.WriteLine(ShapeCalc.CalcSquare(square));

            Console.ReadKey();
        }
    }
}
