using TestSquare.Abstract;
using TestSquare.Interface;

namespace TestSquare.Command
{
    public interface IShapeCommand<TShape, TResult> : ICommandHandler<TShape, TResult>
        where TShape : Shape
    {
        public TResult Area(TShape shape);
    }
}
