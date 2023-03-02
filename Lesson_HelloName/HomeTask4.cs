namespace Lesson_HelloName
{
    internal class HomeTask4
    {
        /// <summary>
        /// Заменить в строке все вхождения 'test' на 'testing'. 
        /// Удалить из текста все символы, являющиеся цифрами.
        /// </summary>
        public static void Task1()
        {
            string s1 = "Test 458";
            s1 = s1.Trim(new char[] { '0', '1', '2', '4', '5', '6', '7', '8', '9' });
            Console.WriteLine(s1);
            Console.WriteLine(s1.Replace("Test", "Testing"));
        }
        /// <summary>
        /// Используя метод вывода значения в консоль, 
        /// выполните конкатенацию слов и выведите на экран следующую фразу: Welcome to the TMS lesons.
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". 
        /// Не забывайте о пробелах после каждого слова
        /// </summary>
        public static void Task2()
        {
            string s1 = "Welcome";
            string s2 = "to";
            string s3 = "the";
            string s4 = "TMS";
            string s5 = "lesson";        

            string[] arrays = { s1, s2, s3, s4, s5 };

            string result = string.Join(" ", arrays);
            Console.WriteLine(result);   
        }
        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter. 
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
        /// Результат вывести в консоль.
        /// </summary>
        public static void Task3()
        {
            string word = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            int index = word.IndexOf("abc");

            string part1 = word.Substring(0, index);
            string part2 = word.Substring(index + 3);

            Console.WriteLine(part1);
            Console.WriteLine(part2);                        
        }
        /// <summary>
        /// Дана строка: Плохой день. Необходимо с помощью метода substring удалить слово "плохой". 
        /// После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
        /// Заменить последний "!" на "?"
        /// </summary>
        public static void Task4()
        {
            string sentence = "Плохой день.";
            int index1 = sentence.IndexOf(".");
            int index2 = sentence.IndexOf("П");

            string result = sentence.Substring(index1-4);
            Console.WriteLine(result);

            string result2 = result.Insert(index2 + 0, "Хороший ");
            Console.WriteLine(result2);

            string result3 = result2.Replace(".", "!!!!!!!!!");
            Console.WriteLine(result3);

            int lastIndex = result3.Length - 1;
            string result4 = result3.Remove(lastIndex);

            string s1 = "?";
            string result5 = result4.Insert(lastIndex, s1);
            Console.WriteLine(result5);    
        }
        /// <summary>
        /// //Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число, а y — это буква.
        /// </summary>
        public static void Task5()
        {            
            string bankCard = "1647-SKR-6835-KMD-0F4D";

            string[] bankCardNumber = bankCard.Split(new char[]{'-'});          // Вывести на экран в одну строку два первых блока по 4 цифры.
            Console.WriteLine(bankCardNumber[0] + " " + bankCardNumber[2]);
        }








    }
}
