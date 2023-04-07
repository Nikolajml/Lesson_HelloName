using Lesson_HelloName.Classes.Lesson_7_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_12
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
            LINQ_methods listMethod = new LINQ_methods(list);
            arrayMethod.FindFirstWordWithOneLetter();
            arrayMethod.FindLastWordsWithEe();
            arrayMethod.FindWordWithConditions(4, 6);
            arrayMethod.NumberOfUniqueValues();            
            listMethod.GetElementContainsThreeStartingFromFiveElement();            
            arrayMethod.GetLengthShortestWord();
        }

        public static void Task2()
        {            
            var users = new List<User>()
            {
                  new User("Oleg", "Alexandrovic", "Kovalev"),
                  new User("Anna", "Olegovna", "Petrova"),
                  new User("Elena", "Petrovna", "Arten"),
                  new User("Margo", "", "Petrachova"),
                  new User("Victor", "", "Smolskiy"),
            };

            User userMethods = new User(users);
            userMethods.GetUsersInfo();
            userMethods.SortListByLastName();            
        }
    }
}
