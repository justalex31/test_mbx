using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TestSquare.Command;
using TestSquare.Command.Impl;
using TestSquare.Figure;
using TestSquare.Interface;
using TestSquare.Validation;

namespace TestSquare
{
    public class LibraryServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register_CommandDispatcher();
            container.Register_Validation();
            container.Register_CommandHandler();
        }
    }

    public static class WindsorContainerExtension
    {
        public static void Register_CommandDispatcher(this IWindsorContainer container)
        {
            container.Register(
                Component.For(typeof(ICommandDispatcher<bool>))
                    .ImplementedBy(typeof(CommandDispatcher<bool>))
                    .Named("dispatcherBool")
                    .DependsOn(new
                    {
                        _container = container
                    }));

            container.Register(
                Component.For(typeof(ICommandDispatcher<double>))
                    .ImplementedBy(typeof(CommandDispatcher<double>))
                    .Named("dispatcherDouble")
                    .DependsOn(new
                    {
                        _container = container
                    }));
        }

        public static void Register_Validation(this IWindsorContainer container)
        {
            container.Register(
                Component.For(typeof(IValidationHandler<Circle>))
                    .ImplementedBy(typeof(Circle_ValidationOnPositiveSide<Circle>))
                    .Named("circleValidation"));

            container.Register(
                Component.For(typeof(IValidationHandler<Triangle>))
                    .ImplementedBy(typeof(Triangle_ValidationOnPositiveSide<Triangle>))
                    .Named("triangle_ValidationOnPositiveSide"));

            container.Register(
                Component.For(typeof(IValidationHandler<Triangle>))
                    .ImplementedBy(typeof(Triangle_ValidationOnExist<Triangle>))
                    .Named("triangle_ValidationRightAngle"));
        }

        public static void Register_CommandHandler(this IWindsorContainer container)
        {
            container.Register(
                Component.For(typeof(ICommandHandler<Circle, double>))
                    .ImplementedBy(typeof(CircleCommand<Circle>))
                    .Named("circleShapeCommand"));

            container.Register(
                Component.For(typeof(ICommandHandler<Triangle, double>))
                    .ImplementedBy(typeof(TriangleCommand<Triangle>))
                    .Named("triangleShapeCommand"));

            container.Register(
                Component.For(typeof(ICommandHandler<Triangle, bool>))
                    .ImplementedBy(typeof(TriangleHasRightAngleCommand<Triangle>))
                    .Named("triangleAngleCommand"));
        }
    }
}
