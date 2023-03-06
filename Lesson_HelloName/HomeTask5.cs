using Lesson_HelloName.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName
{
    public class HomeTask5
    {
        public static void Task1()
        {
            Phone phone1 = new Phone();
            phone1.number = 3172285;
            phone1.model = "Samsung";
            phone1.weight = 0.120;

            Phone phone2 = new Phone();
            phone2.number = 3757745;
            phone2.model = "Nokia";
            phone2.weight = 0.130;

            Phone phone3 = new Phone();
            phone3.number = 3689412;
            phone3.model = "Xiaomi";
            phone3.weight = 0.110;

            Console.WriteLine($"Phone1: {phone1.number}, {phone1.model}, {phone1.weight}");
            Console.WriteLine($"Phone2: {phone2.number}, {phone2.model}, {phone2.weight}");
            Console.WriteLine($"Phone3: {phone3.number}, {phone3.model}, {phone3.weight}");

            Phone phone = new Phone();

            phone.receiveCall("Olga");
            phone.receiveCall("Ivan", 3756677); // Добавьте перегруженный метод receiveCall, который принимает два  параметра - имя звонящего и номер телефона звонящего.


            phone1.getNumber();
            phone2.getNumber();
            phone3.getNumber();

            phone.sendMessage(3759977, 7653354, 3748976);  // Создать метод sendMessage с аргументами переменной длины. Данный метод принимает на вход номера телефонов, которым будет отправлено  сообщение.
        }

        public static void Task2()
        {
            BankCard card1 = new BankCard();
            card1.cardNumber = "1111";
            card1.currentSum = 250;

            BankCard card2 = new BankCard();
            card2.cardNumber = "2222";
            card2.currentSum = 100;

            BankCard card3 = new BankCard();
            card3.cardNumber = "3333";
            card3.currentSum = 150;

            Console.WriteLine($"Card number: {card1.cardNumber}, current sum of money: {card1.currentSum}");
            Console.WriteLine($"Card number: {card2.cardNumber}, current sum of money: {card2.currentSum}");
            Console.WriteLine($"Card number: {card3.cardNumber}, current sum of money: {card3.currentSum}");

            card1.PlusMoney(100);
            card2.PlusMoney(50);
            card3.WithdrowMoney(100);

            card1.CardInformation();
            card2.CardInformation();
            card3.CardInformation();
        }
    }
}
