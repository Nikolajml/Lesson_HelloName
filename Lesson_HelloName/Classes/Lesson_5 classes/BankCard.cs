using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_HelloName.Classes
{
    internal class BankCard
    {
        public string cardNumber;
        public int currentSum;

        public void PlusMoney(int money)
        {
            currentSum += money;
        }

        public void WithdrowMoney(int money)
        {
            currentSum -= money;
        }

        public void CardInformation()
        {
            Console.WriteLine("\n" + $"card number: {cardNumber}; current sum: {currentSum}");
        }
    }    
}