using TestSquare.Abstract;

namespace TestSquare.Interface
{
    public interface ICommandDispatcher<T>
    {
        T Send<TShape>(TShape shape) where TShape : Shape;
    }
}
