using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_6
{
    internal class Doctor
    {
        public string name;
        public int workExperience;


        public Doctor(string name, int workExperience)
        {
            this.name = name;
            this.workExperience = workExperience;
        }

        public virtual string MethodOfTreat()
        {
            return "Choose a doctor for treatment";
        }
    }
}
