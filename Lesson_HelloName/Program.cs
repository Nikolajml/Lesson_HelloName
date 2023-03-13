using Lesson_HelloName;
using Lesson_HelloName.Classes;

namespace Lesson_HelloName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeTask7.Task1();
        }
        /*Задание 2
        Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 
        в числовой промежуток [0 - 14][15 - 35][36 - 49][50 - 100].
        Если да, то укажите, в какой именно промежуток.
        Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, 
        то выводится соответствующее сообщение.
        */
        public static void Task2()
        {
            int number = int.Parse(Console.ReadLine());

            if ((number >= 0) && (number <= 14))
            {
                Console.WriteLine($"Your number is between 0 and 14");
            }
            else if ((number >= 15) && (number <= 35))
            {
                Console.WriteLine($"Your number is between 15 and 35");
            }
            else if ((number >= 36) && (number <= 50))
            {
                Console.WriteLine($"Your number is between 36 and 50");
            }
            else if ((number >= 51) && (number <= 100))
            {
                Console.WriteLine($"Your number is between 50 and 100");
            }
            else if ((number <= 0) || (number >= 100))
            {
                Console.WriteLine($"Your number doesn't fit");
            }
        }
        /*   Задание 3
        Напишите программу русско-английский переводчик.
        Программа знает 10 слов о погоде.
        Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
        Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
        */
        public static void Task3()
        {
            Console.WriteLine("Enter one Russian word to describe the weather:");

            string word = Console.ReadLine();

            if (word == "холод")
            {
                Console.WriteLine($"Translation: холод - cold");
            }
            else if (word == "туман")
            {
                Console.WriteLine($"Translation: туман - fog");
            }
            else if (word == "дождь")
            {
                Console.WriteLine($"Translation: дождь - rain");
            }
            else if (word == "ветер")
            {
                Console.WriteLine($"Translation: ветер - wind");
            }
            else if (word == "облако")
            {
                Console.WriteLine($"Translation: облако - cloud");
            }
            else if (word == "молния")
            {
                Console.WriteLine($"Translation: молния - lightning");
            }
            else if (word == "град")
            {
                Console.WriteLine($"Translation: град - hail");
            }
            else if (word == "тепло")
            {
                Console.WriteLine($"Translation: тепло - warm");
            }
            else if (word == "лужа")
            {
                Console.WriteLine($"Translation: лужа - puddle");
            }
            else if (word == "солнце")
            {
                Console.WriteLine($"Translation: солнце - sun");
            }
            else
            {
                Console.WriteLine($"This word is not availavle in the dictionary");
            }
        }
        /* Задание 4
        Напишите программу, которая будет выполнять проверку чисел на четность.
        Предложите два варианта решения поставленной задачи.
        */
        // вариант решения 1
        public static void Task4()
        {
            Console.WriteLine("Enter a number:");

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Number is even");
            }
            else
            {
                Console.WriteLine($"Number is odd");
            }

        }
        // вариант решения 2
        public static void Task4_1()
        {
            int a;

            a = int.Parse(Console.ReadLine());

            int temp = a % 2;

            bool result = temp == 0;

            if (result)
                Console.WriteLine(a % 2 == 0 ? "Your number is even" : "Your number is uneven");
            else
                Console.WriteLine("Your number is uneven");
        }
        /*
        * Задание 1
        Напишите программу - консольный калькулятор.
        Создайте две переменные с именами operand1 и operand2.
        Задайте переменным некоторые произвольные значения.
        Предложите пользователю ввести знак арифметической операции.
        Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
        Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
        Выведите на экран результат выполнения арифметической операции.
        **В случае использования операции деления, организуйте проверку попытки деления на ноль.
        И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.
       */
        public static void Task1()
        {
            int operand1 = 108;
            int operand2 = 4;


            Console.WriteLine("Do one of the following actions: + , - , * , / ");
            string sign = (Console.ReadLine());

            switch (sign)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Incorrect action!");
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
