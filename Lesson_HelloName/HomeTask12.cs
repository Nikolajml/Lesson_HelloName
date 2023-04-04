using Lesson_HelloName.Classes.Lesson_12;
using Lesson_HelloName.Classes.Lesson_7_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName
{
    internal class HomeTask12
    {
        public static void Task1()
        {
            string[] wordsArray = 
            { 
                "sun", 
                "day", 
                "midnight", 
                "food", 
                "outstanding", 
                "stranger",
                "c",
                "house",
                "delivery",
                "letter",
                "knowledge",
                "a",
                "employee"
            };

            List<string> list = new List<string>() { "27", "4", "7", "38", "56", "399", "47", "23" };

            LINQ_methods arrayMethod = new LINQ_methods(wordsArray);
            arrayMethod.FindFirstWordWithOneLetter();
            arrayMethod.FindLastWordsWithEe();
            arrayMethod.FindWordWithConditions(4, 6);
            Console.WriteLine($"4. The array of words contains <<{arrayMethod.NumberOfUniqueValues()}>> unique valeu;");

            LINQ_methods listMethod = new LINQ_methods(list);
            listMethod.GetElementContainsThreeStartingFromFiveElement();

            Console.WriteLine($"6. The shortest word in the array contains <<{arrayMethod.GetLengthShortestWord()}>> element(s);");

            












        }
    }
}
