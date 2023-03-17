using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    internal class Bus
    {
        public string destination { get; set; }
        public int number { get; set; }
        public string departureTime { get; set; }
        public int numberOfSeats { get; set; }

        public Bus(string destination, int number, string departureTime, int numberOfSeats)
        {
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
            this.numberOfSeats = numberOfSeats;
        }        
    }
}
