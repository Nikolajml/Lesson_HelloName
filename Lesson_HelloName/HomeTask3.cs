using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_HelloName
{
    internal class HomeTask3
    {
        /// <summary>
        /// 0. Создайте массив целых чисел. 
        /// Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет. 
        /// Пусть число для поиска задается с консоли.
        /// </summary>
        public static void Task0()
        {
            int[] numbers = { 10, 25, 31, 47 };

            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                if (numbers[i] == a)
                {
                    Console.WriteLine("This number exists in the array");
                }
            }
        }
        /// <summary>
        /// Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
        /// Пусть число задается с консоли.Если такого числа нет - выведите сообщения об этом. 
        /// В результате должен быть новый массив без указанного числа.
        /// </summary>
        public static void Task1()
        {
            Random random = new Random();            
            
            int[] numbers = { 10, 25, 10, 47, 50, 10 };

            Console.WriteLine("Enter a number you want to delete: ");
            int deleteNumber = int.Parse(Console.ReadLine());

            int counter = 0;            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == deleteNumber)
                {
                    counter++;
                }                
            }

            Console.WriteLine(counter);

            int[] newArray = new int[numbers.Length - counter];

            for (int i = 0, j = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != deleteNumber)
                {
                    newArray[j] = numbers[i];
                    j++;
                }
            }

            foreach (int number in newArray)
            {
                Console.Write("\n" + number);
            }            
        }              
        /// <summary>
        /// Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
        /// Для генерации случайного числа используйте метод Random().
        /// Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли. 
        /// </summary>
        public static void Task2()
        {
            Random random = new Random();

            int a = int.Parse(Console.ReadLine());
            int[] numbers = new int[a];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)random.Next(0, 1000);
            }
                                  
            int minNumber = numbers[0];
            int maxNumber = numbers[0];
            int sum = 0;
                              
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                
                sum += numbers[i];                      
            }
            
            int average = sum / numbers.Length;

            Console.WriteLine("Minimum number is: " + minNumber);
            Console.WriteLine("Maximum number is: " + maxNumber);
            Console.WriteLine("Average number is: " + average);
        }
        /// <summary>
        /// Создайте 2 массива из 5 чисел. 
        /// Выведите массивы на консоль в двух отдельных строках. 
        /// Посчитайте среднее арифметическое элементов каждого массива и сообщите, 
        /// для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).
        /// </summary>
        public static void Task3()
        {
            double[] numbers1 = new double[5] { 1, 1, 1, 1, 2 };
            double[] numbers2 = new double[5] { 1, 1, 1, 1, 5 };

            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < numbers1.Length; i++)               // Не разобрался как вывести элементы для двух массивов в двух разных строках 
            {
                Console.Write(numbers1[i] + " ");  
            }

            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.Write(numbers2[i] + " ");
            }                    

            for (int i = 0; i < numbers1.Length; i++)
            {
                sum1 += numbers1[i];
                sum2 += numbers2[i];
            }

            double average1 = sum1 / numbers1.Length;
            double average2 = sum2 / numbers2.Length;
            
            Console.WriteLine("\t" + "average1 is: " + average1);
            Console.WriteLine("\t" + "average2 is: " + average2);

            if (average1 > average2)
            {
                Console.WriteLine($"average1 is more than average2");
            }
            else if (average1 < average2)
            {
                Console.WriteLine($"average1 is less than average2");
            }
            else if (average1 == average2)
            {
                Console.WriteLine($"average1 is equal average2");
            }       
        }       
    }       
}
