using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    internal class GetInfo : Bus
    {
        
        public void Main()
        {
            Console.WriteLine(new Bus("Minsk", 4876, "08:00", 10));
        }

        public void TransportArray()
        {

        }
        
    }
}
