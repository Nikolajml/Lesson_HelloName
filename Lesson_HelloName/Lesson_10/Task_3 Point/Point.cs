using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_10.Task_3_Point
{
    internal class Point <T> where T : struct
    {
        public T x;
        public T y;

        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public void GetPointValeu()
        {
            Console.WriteLine($"X value: {x}; Y value: {y}");
        }

        public void GetDistance(Point<T> point1, Point<T> point2)
        {
            var x1 = Convert.ToInt32(point1.x);
            var y1 = Convert.ToInt32(point1.y);
            var x2 = Convert.ToInt32(point2.x);
            var y2 = Convert.ToInt32(point2.y);

            double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

            Console.WriteLine($"Distance is {result}");
        }
    }
}
