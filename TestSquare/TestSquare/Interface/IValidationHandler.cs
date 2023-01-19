using System.Collections.Generic;
using TestSquare.Abstract;

namespace TestSquare.Interface
{
    public interface IValidationHandler<TShape> : IHandler<TShape>
        where TShape : Shape
    {
        public string ErrorMessage { get; set; }
    }
}
