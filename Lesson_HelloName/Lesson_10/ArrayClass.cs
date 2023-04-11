using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Lesson_10
{
    internal class ArrayClass<T>
    {
        public T[] array = new T[0];
        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public int count { get { return array.Length; } }

        /// <summary>
        /// 1. Method to add an array element
        /// </summary>
        /// <param name="valeu"></param>
        public void AddElement(T valeu)
        {
            var newArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = valeu;

            array = newArray;
        }

        /// <summary>
        /// 2. Method to remove an array element
        /// </summary>
        /// <param name="valeu"></param>
        public void DeleteElement(T valeu)
        {                       
            int counter = 0;
            var array1 = new T[array.Length];

            for (int i = 0; i < array1.Length; i++)
            {                
                if (array1.Equals(valeu))
                {
                    counter++;
                }                
            }

            Console.WriteLine($"Number elements in array to delet is {counter}");

            //var array2 = new T[array.Length - counter];

            //for (int i = 0, j = 0; i < newArray.Length; i++)
            //{
            //  
            //}

            //array = newArray2;
        }

        /// <summary>
        /// 3. Method to show array length
        /// </summary>
        public void GetArrayLength()
        {
            int counter = 0;
            var array1 = new T[array.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                if (i < array1.Length)
                {
                    counter++;
                }                
            }

            int numberOfArrayElements = counter;

            Console.WriteLine($"Array length is {numberOfArrayElements}");
        }

        /// <summary>
        /// 4. Method to find array element by index
        /// </summary>
        /// 
        public void GetElementByIndex(int value)
        {
            var array1 = array[value];

            Console.WriteLine($"Element under number {value} is: {array1}");            
        }
    }
}
