using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_6
{
    internal class Surgeon : Doctor
    {
        public Surgeon(string name, int workExperience) : base(name, workExperience)
        {
        }

        public override string MethodOfTreat()
        {
            return "You need a surgeon. Method of treat is operation.";
        }
    }
}
