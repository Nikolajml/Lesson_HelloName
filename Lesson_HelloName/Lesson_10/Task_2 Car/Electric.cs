using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_10.Task_2_Car
{
    internal class Electric : Engine
    {
        public override void MoveAuto()
        {
            Console.WriteLine("Move on electric fuel");
        }
        public override void FillAuto()
        {
            Console.WriteLine("Charge a car with electricity");
        }
    }
}
