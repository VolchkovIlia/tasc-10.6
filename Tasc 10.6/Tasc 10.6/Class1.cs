using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasc_10._6
{
    public class Class1
    {
        public static double CalculateTheHypotenuse(double x, double y)
        {
          return Math.Sqrt(x * x + y * y);
        }

        public static double CalculateThePerimeter(double AB, double AC, double CD, double BD)
        {
             return AB + AC + CD + BD;
        }
    }
}
