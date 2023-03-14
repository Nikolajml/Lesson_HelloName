using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes.Task2
{
    internal class Moto : Auto
    {        
        public Moto(string mark, int number, double speed, double loadCapacity) : base (mark, number, speed, loadCapacity) 
        {            
        }

        public override int GetLoadCapaticyForMoto(int carriage)
        {
            if (carriage == 1)
            {
                double loadCapacity = +80.00;                
            }
            else if (carriage < 1)
            {
                double loadCapacity = 00.00;                
            }
            else if (carriage > 1)
            {
                Console.WriteLine("You can't use more than 1 carriage.");                
            }
        }
    }
}
