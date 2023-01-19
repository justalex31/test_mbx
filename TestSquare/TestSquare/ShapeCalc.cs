using Castle.Windsor;
using TestSquare.Abstract;
using TestSquare.Command;
using TestSquare.Interface;

namespace TestSquare
{
    public static class ShapeCalc
    {
        private static readonly IWindsorContainer container;

        public static IWindsorContainer Container => container;

        static ShapeCalc()
        {
            container = new WindsorContainer();
            container.Install(new LibraryServiceInstaller());
        }

        public static double CalcSquare<TShape>(TShape shape)
            where TShape : Shape
        {
            return container.Resolve<ICommandDispatcher<double>>().Send(shape);
        }

        public static bool HasRightAngle<TShape>(TShape shape)
            where TShape : Shape
        {
            return container.Resolve<ICommandDispatcher<bool>>().Send(shape);
        }
    }
}
