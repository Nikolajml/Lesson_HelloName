using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_10.Task_2_Car
{
    public class Car<T> where T : Engine
    {
        public T engine;

        public Car(T motor)
        {
            engine = motor;
        }

        public void Movement()
        {
            engine.MoveAuto();
        }

        public void RefillingCar()
        {
            engine.FillAuto();
        }
    }        
}
