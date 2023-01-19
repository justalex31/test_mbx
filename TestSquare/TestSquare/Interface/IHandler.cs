using TestSquare.Abstract;

namespace TestSquare.Interface
{
    public interface IHandler<TShape>
        where TShape : Shape
    {
        void Handle(TShape shape);
    }

    public interface IHandler<TShape, out TResult>
        where TShape: Shape
    {
        TResult Handle(TShape shape);
    }
}
