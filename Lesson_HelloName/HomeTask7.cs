using Lesson_HelloName.Classes.Lesson_7_classes;
using Lesson_HelloName.Classes.Lesson_7_classes.Task1;
using Lesson_HelloName.Classes.Lesson_7_classes.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName
{
    internal class HomeTask7
    {
        public static void Task1()
        {
            GetInfo bus = new GetInfo();
            bus.Main();

            GetInfo getInfo = new GetInfo();
            getInfo.TransportArray();

            Transport aircraft = new Aircraft("Stambul", 1456, "11:00", 310, "Air");           
            aircraft.GetTransportType();

            GetInfo setParametres = new GetInfo();
            setParametres.SetDestinationOrDepatureTime();

            GetInfo departureTime = new GetInfo();
            departureTime.GetDepatureTime();            
        }

        public static void Task2()
        {
            Auto car = new Car("BMW", 1245, 220);
            Auto moto = new Moto("Tayota", 1111, 300);
            Auto truck = new Truck("MAZ", 7777, 190);

            moto.GetMotoCarrying();
            truck.GetTruckCarrying();
            car.GetInfo();
            moto.GetInfo();
            truck.GetInfo();

            var autos = new Auto[] { car, moto, truck };

            Console.WriteLine("Enter the load capacity you need");
            double userLoadCapacity = double.Parse(Console.ReadLine());

            foreach (var auto in autos)
            {
                if(userLoadCapacity <= auto.loadCapacity)
                {
                    auto.GetInfo();
                }
            }
        }
    }
}
