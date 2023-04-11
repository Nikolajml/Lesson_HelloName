using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_10.Task_2_Car
{
    internal class Petrol : Engine
    {
        public override void MoveAuto()
        {
            Console.WriteLine("Move on petrol fuel");
        }
        public override void FillAuto()
        {
            Console.WriteLine("Refuel with petrol fuel");
        }
    }
}
