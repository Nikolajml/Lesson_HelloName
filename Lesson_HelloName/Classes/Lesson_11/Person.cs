using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_11
{
    class Person
    {
        public string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void RentApartment(int price)
        {
            Console.WriteLine($"I like this price {price}! I want to rent this apartment!");
        }
    }
}
