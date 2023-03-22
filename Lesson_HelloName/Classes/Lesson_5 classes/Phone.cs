using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_HelloName.Classes
{
    internal class Phone
    {
        public int number;
        public string model;
        public double weight;
    
        public void receiveCall(string name)
        {
            Console.WriteLine($"{name} call");
        }

        public void getNumber() 
        {
            Console.WriteLine("\n" + number);
        }

        public Phone(int number, string model, double weight) : this(number, model)
        {
            this.weight = weight;
        }

        public Phone(int number, string model) 
        {
            this.number = number;
            this.model = model;
        }

        public Phone()
        {            
        }

        public void receiveCall(string name, int phoneNumber)     // Добавьте перегруженный метод receiveCall, который принимает два  параметра - имя звонящего и номер телефона звонящего.
        {
            Console.WriteLine($"{name} call; phone number: {phoneNumber}");
        }

        public void sendMessage(params int[] phoneNumbers)  // Создать метод sendMessage с аргументами переменной длины. Данный метод принимает на вход номера телефонов, которым будет отправлено  сообщение.
        {
            foreach (int phoneNumber in phoneNumbers)
            {
                Console.WriteLine($"The message will be send to {phoneNumber}");
            }                        
        }
    }
}
