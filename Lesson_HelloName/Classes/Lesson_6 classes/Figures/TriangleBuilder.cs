using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_6_classes.Figures
{
    internal class TriangleBuilder
    {
        public TriangleBuilder()
        {
        }

        public Triangle CreateTriangle(double side_1, double side_2, double side_3)
        {
            if((side_1 == side_2) && (side_1 == side_3))
            {
                return new EquilateralTriangle(side_1, side_2, side_3);
            }

            return new Triangle(side_1, side_2, side_3);
        }
    }
}
