using System.Collections.Generic;
using TestSquare.Figure;
using TestSquare.Helper;
using TestSquare.Interface;

namespace TestSquare.Validation
{
    public class Circle_ValidationOnPositiveSide<TShape> : IValidationHandler<TShape>
        where TShape : Circle
    {
        public string ErrorMessage { get; set; }

        public void Handle(TShape shape)
        {
            ErrorMessage = ValidationHelper.GreaterThanZero(shape.Radius);
        }
    }
}
