using Castle.Windsor;
using System;
using System.Linq;
using TestSquare.Abstract;
using TestSquare.Interface;

namespace TestSquare.Command
{
    public class CommandDispatcher<T> : ICommandDispatcher<T>
    {
        private readonly IWindsorContainer container;

        public CommandDispatcher(IWindsorContainer _container) => container = _container;

        public T Send<TShape>(TShape shape) where TShape : Shape
        {
            string errStr = string.Join("", container.ResolveAll<IValidationHandler<TShape>>()
                .Select(x =>
                {
                    x.Handle(shape);
                    return x.ErrorMessage;
                }));

            if (string.IsNullOrEmpty(errStr))
            {
                return container.Resolve<ICommandHandler<TShape, T>>().Handle(shape);
            }
            else
            {
                throw new Exception(errStr);
            }
        }
    }
}
