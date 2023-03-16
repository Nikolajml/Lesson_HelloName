using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_7_classes.Task2
{
    internal class Auto
    {
        public string mark;
        public int number;
        public double speed;
        public double loadCapacity;


        public Auto(string mark,int number, double speed, double loadCapacity)
        {
            this.mark = mark;
            this.number = number;
            this.speed = speed;
            this.loadCapacity = loadCapacity;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Mark: {mark}; Number: {number}, Speed: {speed}, Load capacity: {loadCapacity}");
        }

        
    }
}
