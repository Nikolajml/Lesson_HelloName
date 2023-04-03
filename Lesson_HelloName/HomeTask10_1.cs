using System;


namespace Lesson_HelloName
{
    internal class HomeTask10_1
    {
        public static void Task1()
        {
            int[] intArray = { 2, 1, 5, 3, 4, 5 };

            int max1 = intArray[0];
            int max2 = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                if (max1 < intArray[i])
                {
                    max1 = intArray[i];
                }

                if (max2 < intArray[i] && max1 != intArray[i])
                {
                    max2 = intArray[i];
                }
            }
                 
            Console.WriteLine("Max2 is ");
            Console.WriteLine(max2);
        }

        public static void Task2()
        {
            int[] array = { 1, 1, 0, 1, 1, 1, 0 };

            int countForZero = 0;            

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    if (array[countForZero] == 1)
                    {
                        array[countForZero] = array[i];
                        array[i] = 1;
                    }   

                    countForZero++;
                }                
            }     

            var arrayElements = string.Join(" ", array);
            Console.WriteLine(arrayElements);
        }
    }
}
