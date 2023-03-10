using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_6
{
    internal class Therapist : Doctor
    {
        public Therapist(string name, int workExperience) : base(name, workExperience)
        {
        }

        public override string MethodOfTreat()
        {
            return $"You need a therapist. Method of treat is general treatment.";
        }
    }
}
