using TestSquare.Interface;

namespace TestSquare.Validation
{
    public class Triangle_ValidationOnExist<TShape> : IValidationHandler<TShape>
        where TShape : Figure.Triangle
    {
        public string ErrorMessage { get; set; }

        public void Handle(TShape shape) => ErrorMessage = IsTriangle(shape.SideA, shape.SideB, shape.SideC);

        private string IsTriangle(double a, double b, double c) =>
            (a + b > c && b + c > a && c + a > b) == false ? "Cannot create a triangle" : string.Empty;
    }
}
