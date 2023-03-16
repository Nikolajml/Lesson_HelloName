using Lesson_HelloName.Classes.Lesson_7_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName
{
    internal class HomeTask7
    {
        public static void Task1()
        {
            //GetInfo bus = new GetInfo();
            //bus.Main();
            
            //GetInfo getInfo = new GetInfo();
            //getInfo.TransportArray();

            //Transport aircraft = new Aircraft("Stambul", 1456, "11:00", 310, "Air");           
            //aircraft.GetTransportType();
            
            GetInfo setParametres = new GetInfo();
            setParametres.SetDestinationOrDepatureTime();


        }
    }
}
