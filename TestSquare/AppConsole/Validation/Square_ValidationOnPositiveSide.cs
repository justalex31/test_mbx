using AppConsole.Figure;
using TestSquare.Helper;
using TestSquare.Interface;

namespace AppConsole.Validation
{
    class Square_ValidationOnPositiveSide<TShape> : IValidationHandler<TShape>
        where TShape : Square
    {
        public string ErrorMessage { get; set; }

        public void Handle(TShape shape)
        {
            ErrorMessage = ValidationHelper.GreaterThanZero(shape.SideA, shape.SideB);
        }
    }
}
