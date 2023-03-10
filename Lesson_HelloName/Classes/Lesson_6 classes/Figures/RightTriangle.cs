using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_6_classes.Figures
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle(double side_1, double side_2, double side_3) : base(side_1, side_2, side_3)
        {
        }

        public override double GetSquare()
        {
            if (side_1 > side_2)
            {
                if (side_1 > side_3)
                {
                    return GetSquareForRightTriangle (side_2, side_3);
                }
                else
                {
                    return GetSquareForRightTriangle (side_1, side_2);
                }
            }
            else 
            {
                if (side_2 > side_3)
                {
                    return GetSquareForRightTriangle (side_1, side_3);
                }
                else
                {
                    return GetSquareForRightTriangle (side_1, side_2);
                }                    
            }
        }

        private double GetSquareForRightTriangle(double side_1, double side_2)
        {
            return 0.5 * side_1 * side_2;
        }
    }
}
