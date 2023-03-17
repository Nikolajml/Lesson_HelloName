using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes.Task2
{
    internal class Truck : Auto    
    {   
        public Truck(string mark, int number, double speed) : base(mark, number, speed)
        {
            this.loadCapacity = 2000.00;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Mark: {mark}; Number: {number}, Speed: {speed}, Load capacity: {loadCapacity}");
        }

        public virtual double GetTruckCarrying()
        {
            return loadCapacity += 20000.00;
        }
    }
}
