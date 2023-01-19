using TestSquare.Helper;
using TestSquare.Interface;

namespace TestSquare.Validation
{
    public class Triangle_ValidationOnPositiveSide<TShape> : IValidationHandler<TShape>
        where TShape : Figure.Triangle
    {
        public string ErrorMessage { get; set; }

        public void Handle(TShape shape)
        {
            ErrorMessage = ValidationHelper.GreaterThanZero(shape.SideA, shape.SideB, shape.SideC);
        }
    }
}
