using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes.Task2
{
    internal class Moto : Auto
    {        
        public Moto(string mark, int number, double speed) : base (mark, number, speed) 
        {                   
            this.loadCapacity = 0;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Mark: {mark}; Number: {number}, Speed: {speed}, Load capacity: {loadCapacity}");
        }

        public override double GetMotoCarrying()
        {           
            return loadCapacity += 80;                        
        }
    }
}
