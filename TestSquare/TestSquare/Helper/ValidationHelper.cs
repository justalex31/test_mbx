using System.Collections.Generic;

namespace TestSquare.Helper
{
    public static class ValidationHelper
    {
        public static string GreaterThanZero(double value) =>
            value <= 0 ? "Value: " + value + " is less than or equal to zero" : string.Empty;

        public static string GreaterThanZero(params double[] values)
        {
            HashSet<double> hst = new HashSet<double>();
            foreach (var item in values)
            {
                if (item <= 0)
                {
                    hst.Add(item);
                }
            }

            return hst.Count > 0 ? (hst.Count > 1 ? "Values: " : "Value: ") + string.Join(", ", hst) + " is less than or equal to zero" : string.Empty;
        }
    }
}
