using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_6
{
    internal class Patient
    {
        public string name;
        public int age;
        public int treatment;

        public Patient(string name, int age, int treatment)
        {
            this.name = name;
            this.age = age;
            this.treatment = treatment;
        }

        public void setDoctor()
        {
            if (treatment == 1)
            {
                Console.WriteLine(new Surgeon("Alex", 15).MethodOfTreat());
            }
            else if (treatment == 2)
            {
                Console.WriteLine(new Dantist("Oleg", 10).MethodOfTreat());
            }
            else
            {
                Console.WriteLine(new Therapist("Elena", 19).MethodOfTreat());
            }
        }

    }
}

