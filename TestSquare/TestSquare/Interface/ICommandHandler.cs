using TestSquare.Abstract;

namespace TestSquare.Interface
{
    public interface ICommandHandler<TShape, T> : IHandler<TShape, T>
        where TShape : Shape
    {
    }
}
