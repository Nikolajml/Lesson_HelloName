using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    internal class GetInfo
    {        
        public void Main()
        {
            Bus bus = new Bus("Minsk", 4876, "08:00", 10);
            Console.WriteLine($"Destination: {bus.destination}");
            Console.WriteLine($"Bus number: {bus.number}");
            Console.WriteLine($"Departure time: {bus.departureTime}");
            Console.WriteLine($"Number of seats: {bus.numberOfSeats}" + "\n");
        }

        public void TransportArray()
        {
            Transport[] transports =
            {
                new Aircraft("Tashkent", 4456, "12:20", 100, "Air"),
                new Autobus("Moskow", 1113, "10:20", 44, "Automobile"),
                new Train("Minsk", 707, "08:00", 670, "Railway"),
            };

            var sortFunc = (Transport transport) =>
            {
                return transport.numberOfSeats;
            };

            var sortedTransportByNumberOfSeats = transports.OrderBy(sortFunc).ToArray();

            foreach ( var transport in sortedTransportByNumberOfSeats) 
            { 
                Console.WriteLine(transport.numberOfSeats);
            }
        }

        public void SetDestinationOrDepatureTime()
        {
            Transport[] transports =
            {
                new Aircraft("Tashkent", 4456, "12:20", 100, "Air"),
                new Autobus("Moskow", 1113, "10:20", 44, "Automobile"),
                new Train("Minsk", 707, "08:00", 670, "Railway"),
            };

            Console.WriteLine("Enter a destination: ");
            string userDestination = Console.ReadLine(); ;

            Console.WriteLine("Enter a time of departure: ");
            string userDepartureTime = Console.ReadLine();

            foreach ( var transport in transports)
            {
                if(transport.destination == userDestination || transport.departureTime == userDepartureTime)
                {
                    Console.WriteLine(transport);
                }
            }
        }

        public void GetDepatureTime()
        {
            Transport[] transports =
            {
                new Aircraft("Tashkent", 4456, "12:20", 100, "Air"),
                new Autobus("Moskow", 1113, "10:20", 44, "Automobile"),
                new Train("Minsk", 707, "08:00", 670, "Railway"),
            };

            Console.WriteLine("Enter a time of departure: ");
            DateTime userDepartureTime = DateTime.Parse(Console.ReadLine());

            foreach (var transport in transports)
            {
                DateTime TransportTime = DateTime.Parse(transport.departureTime);
                if (TransportTime >= userDepartureTime)
                {
                    Console.WriteLine(transport);
                }
            }
        }
    }
}
