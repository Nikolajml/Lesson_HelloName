using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    internal class Аutomobile : Transport
    {
        public string transportType;

        public Аutomobile(string destination, int number, string departureTime, int numberOfSeats, string transportType) : base(destination, number, departureTime, numberOfSeats)
        {
            this.transportType = "Аutomobile transport";
        }

        public override void GetTransportType()
        {
            Console.WriteLine($"The type of transport is {transportType}");
        }

    }
}
