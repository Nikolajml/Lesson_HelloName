using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    public class Transport
    {
        public string destination;
        public int number;
        public string departureTime;
        public int numberOfSeats;

        public Transport(string destination, int number, string departureTime, int numberOfSeats)
        {
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
            this.numberOfSeats = numberOfSeats;
        }
                
        public virtual void GetTransportType()
        {
            Console.WriteLine("Transport type");
        }
    }
}
