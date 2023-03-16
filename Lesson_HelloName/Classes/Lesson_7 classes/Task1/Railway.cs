using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    internal class Railway : Transport
    {
        public string transportType;

        public Railway(string destination, int number, string departureTime, int numberOfSeats, string transportType) : base (destination, number, departureTime, numberOfSeats)
        {
            this.transportType = "Railway transport";
        }

        //public override void GetTransportType()
        //{
        //    Console.WriteLine($"The type of transport is {transportType}");
        //}

    }
}
