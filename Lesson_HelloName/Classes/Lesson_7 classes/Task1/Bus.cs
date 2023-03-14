using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    internal class Bus
    {
        public string destination;
        public int number;
        public string departureTime;
        public int places;


        public Bus(string destination, int number, string departureTime, int places)
        {
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
            this.places = places;
        }

        public Bus()
        {
        }


        public string Destination
        {
            get
            {
                Console.WriteLine("The destination of the transport is ");
                return this.destination;
            }
            set
            {
                this.destination = value;
            }
        }

        public int Number
        {
            get
            {
                Console.WriteLine("The number of the transport is ");
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public string DepartureTime
        {
            get
            {
                Console.WriteLine("The departure time of the transport is ");
                return this.departureTime;
            }
            set
            {
                this.departureTime = value;
            }
        }

        public int Places
        {
            get
            {
                Console.WriteLine("The departure time of the transport is ");
                return this.places;
            }
            set
            {
                this.places = value;
            }
        }
    }
}
