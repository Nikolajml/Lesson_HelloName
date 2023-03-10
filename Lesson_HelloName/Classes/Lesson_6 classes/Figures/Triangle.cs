using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_6_classes.Figures
{
    internal class Triangle
    {
        public double side_1;
        public double side_2;
        public double side_3;

        public Triangle(double side_1, double side_2, double side_3)
        {
            this.side_1 = side_1;
            this.side_2 = side_2;
            this.side_3 = side_3;
        }

        public virtual double GetSquare()
        {
            Console.WriteLine("Get square Heron's formula:");
            double semiPerimetr = (side_1 + side_2 + side_3) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - side_1) + (semiPerimetr - side_2) + (semiPerimetr - side_3));
        }
    }
}