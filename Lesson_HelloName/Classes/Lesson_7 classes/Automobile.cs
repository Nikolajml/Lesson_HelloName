using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    internal class Аutomobile : Transport
    {
        public string kindOfTransport;

        public Аutomobile(string destination, int number, string departureTime, int places, string kindOfTransport) : base(destination, number, departureTime, places)
        {
            this.kindOfTransport = "Аutomobile transport";
        }
    }
}
