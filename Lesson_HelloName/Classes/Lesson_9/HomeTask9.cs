using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_9
{
    internal class HomeTask9
    {
        public static void Task0()
        {
            ArrayList list = new ArrayList();

            try
            {
                object s = list[18];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine($"Message: {ex.Message}");
            }

            var newList = new Dictionary<string, int>()
            {
                ["One"] = 1,
                ["Two"] = 1,
                ["Three"] = 1,
                ["Four"] = 1,
                ["Five"] = 1,
                ["Six"] = 1,
                ["Seven"] = 1,
                ["Eight"] = 1,
                ["Nine"] = 1,
                ["Ten"] = 1,                
            };                   

            foreach (var value in newList)
            {
                Console.WriteLine(value);
            }
        }

        public static void Task1()
        {
            
        }
    }
}
