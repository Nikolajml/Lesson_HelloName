using Lesson_HelloName.Classes.Lesson_7_classes.Task2;
using Lesson_HelloName.Lesson_10.Task_2_Car;
using Lesson_HelloName.Lesson_10.Task_3_Point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_10
{
    internal class HomeTask10
    {
        public static void Task1()
        {
            // Add element to array            
            ArrayClass<int> firstArray = new ArrayClass<int>();
            firstArray.AddElement(4);
            firstArray.AddElement(2);
            firstArray.AddElement(7);
            firstArray.AddElement(8);
            firstArray.AddElement(7);
            firstArray.AddElement(7);                       

            for (int i = 0; i < firstArray.count; i++)
            {
               Console.WriteLine(firstArray[i]);
            }

            // Find element in array by index            
            firstArray.GetElementByIndex(5);

            // Get array lengt
            firstArray.GetArrayLength();

            // Delete element from array not realize
            firstArray.DeleteElement(7);
        }

        public static void Task2()
        {
            var electricCar = new Car<Electric>(new Electric());
            electricCar.Movement();
            electricCar.RefillingCar();

            var petrolCar = new Car<Petrol>(new Petrol());
            petrolCar.Movement();
            petrolCar.RefillingCar();

            var dieselCar = new Car<Diesel>(new Diesel());
            dieselCar.Movement();
            dieselCar.RefillingCar();
        }

        public static void Task3()
        {
            Point<int> point_1 = new Point<int>(4, 6);
            Point<int> point_2 = new Point<int>(8, 11);

            point_1.GetPointValeu();
            point_2.GetPointValeu();

            point_1.GetDistance(point_1, point_2);
        }
    }
}
