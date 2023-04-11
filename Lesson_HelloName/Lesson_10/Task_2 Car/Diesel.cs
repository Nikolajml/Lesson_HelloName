using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_10.Task_2_Car
{
    internal class Diesel : Engine
    {
        public override void MoveAuto()
        {
            Console.WriteLine("Move on diesel fuel");
        }
        public override void FillAuto()
        {
            Console.WriteLine("Refuel with diesel fuel");
        }
    }
}
