using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_12
{
    public class LINQ_methods
    {
        public string[] wordsArray;

        public LINQ_methods(string[] wordsArray)
        {
            this.wordsArray = wordsArray;
        }

        public List<string> numbersList;
        public LINQ_methods(List<string> numbersList)
        {
            this.numbersList = numbersList;
        }

        /// <summary>
        /// 1. The method returns the first word in a sequence of words that contains only one letter.
        /// </summary>
        public void FindFirstWordWithOneLetter()
        {
            var firstOneLetterWord = wordsArray.FirstOrDefault(wL => wL.Length == 1);
            Console.WriteLine($"1. The first word in a sequence of words that contains only one letter is: <<{firstOneLetterWord}>>;");
        }

        /// <summary>
        /// 2.The method returns the last word containing the substring "ee".
        /// </summary>

        public void FindLastWordsWithEe()
        {
            var lastWordsWithEe = wordsArray.LastOrDefault(w => w.Contains("ee"));
            Console.WriteLine($"2. The last word containing the substring 'ee' is <<{lastWordsWithEe}>>;");
        }

        /// <summary>
        /// 3. Implement a method for returning the last words, the corresponding condition: 
        /// the length of the word is not less than min. and no more than max. 
        /// If there are no words matching the condition method, null is returned.        
        /// </summary>
        public void FindWordWithConditions(int min, int max)
        {
            var wordConditionsWords = wordsArray.LastOrDefault(w => w.Length > min && w.Length < max);
            Console.WriteLine($"3. Word that satisfies the condition is <<{wordConditionsWords}>>;");
        }

        /// <summary>
        /// 4. The method that returns the number of unique values in an array.            
        /// </summary>
        public int NumberOfUniqueValues()
        {
            var uniqValues = wordsArray.Distinct();
            var countUniqValue = uniqValues.Count();
            return countUniqValue;
        }

        /// <summary>
        /// 5. The method that takes a list and, starting from the 5th element, extract those values that contain 3.            
        /// </summary>
        public void GetElementContainsThreeStartingFromFiveElement()
        {
            var conditionElement = from n in numbersList.Skip(4)
                                   where n.Contains("3")
                                   select n;

            foreach (var number in conditionElement)
            {
                Console.WriteLine($"5. The element that satisfies the conditions is <<{number}>>");
            }
        }

        /// <summary>
        /// 6. The method returns the length of the shortest word.            
        /// </summary>

        public int GetLengthShortestWord()
        {
            var shortestWordLength = wordsArray.OrderBy(w => w.Length).FirstOrDefault().Count(); ;
            return shortestWordLength;
        }


    }
}
