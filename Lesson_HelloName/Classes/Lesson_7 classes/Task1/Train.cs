using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    internal class Train : Railway
    {
        public Train(string destination, int number, string departureTime, int numberOfSeats, string transportType) : base(destination, number, departureTime, numberOfSeats, transportType)
        {
        }

        public override void GetTransportType()
        {
            Console.WriteLine($"The kind of transport is {transportType}");
        }
    }
}
