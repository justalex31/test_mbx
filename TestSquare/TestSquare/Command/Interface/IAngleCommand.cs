using TestSquare.Abstract;
using TestSquare.Interface;

namespace TestSquare.Command
{
    public interface IAngleCommand<TShape, TResult> : ICommandHandler<TShape, TResult>
        where TShape : Shape
    {
        public TResult HasRightAngle(TShape shape);
    }
}
