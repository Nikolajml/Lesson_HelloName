using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_6_classes.Figures
{
    internal class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double side_1, double side_2, double side_3) : base(side_1, side_2, side_3)
        {
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get square equilateral triangle:");
            return Math.Pow(side_1, 2) * Math.Sqrt(3) / 4;
        }
    }
}
