using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_6
{
    internal class Dantist : Doctor
    {
        public Dantist(string name, int workExperience) : base(name, workExperience)
        {
        }

        public override string MethodOfTreat()
        {
            return $"You need a dantist. Method of tratу is genral treatment.";
        }
    }
}
