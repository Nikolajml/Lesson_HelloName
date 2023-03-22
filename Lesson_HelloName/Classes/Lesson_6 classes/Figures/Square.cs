using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_6_classes.Figures
{
    internal class Square : Rectangle
    {
        public Square(double length, double width) : base(length, width) 
        { 
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get squares's square");
            return length * width;
        }
    }
}
