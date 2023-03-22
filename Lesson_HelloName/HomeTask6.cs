using Lesson_HelloName.Classes;
using Lesson_HelloName.Classes.Lesson_6_classes.Figures;
using Lesson_HelloName.Lesson_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName
{
    internal class HomeTask6
    {
        public static void Task1()
        {
            Triangle triangle = new TriangleBuilder().CreateTriangle(5, 5, 5);
            Console.Write(triangle.GetSquare());

            Rectangle rectangle = new Rectangle(5, 9);
            Console.Write(rectangle.GetSquare());

            Square square = new Square(4, 4);
            Console.Write(square.GetSquare());
        }

        public static void Task2()
        {
            Patient patient_1 = new Patient("Vasia", 40, new TreatmentPlan(1).code);
            patient_1.setDoctor();
        }
    }
}
