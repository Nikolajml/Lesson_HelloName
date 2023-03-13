using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    internal class Transport
    {
        public string destination;
        public int number;
        public string departureTime;
        public int places;

        public Transport(string destination, int number, string departureTime, int places)
        {
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
            this.places = places;
        }

        public Transport()
        {
        }
                

        public virtual void GetKindOfTransport()
        {
            Console.WriteLine("The kind of transport is ");
        }
    }
}
