using Lesson_HelloName.Classes.Lesson_9.Models;
using Microsoft.VisualBasic;
using System.Globalization;

namespace Lesson_HelloName.Classes.Lesson_9
{
    public abstract class Product : IProduct
    {
        public string name { get; set; }
        public double price { get; set; }
        public DateTime produceDate { get; set; }
        public DateTime expirationDate { get; set; }

        public void Info()
        { 
            Console.WriteLine($"Name: {name};"); 
            Console.WriteLine($"Product price: {price}$;");  
            Console.WriteLine($"Produce date: {produceDate.ToString("dd/MM/yyyy")};");  
            Console.WriteLine($"Expiration date: {expirationDate.ToString("dd/MM/yyyy")}; \n");
        }

        public bool CheckIfProductExpired()
        {
            int result = DateTime.Compare(expirationDate, DateTime.Now);

            //Console.WriteLine($"checkIfProductExpired result: {result}; DateNow: {DateTime.Now}; expiration: {expirationDate}");

            if (result <= 0)
            {
                return true;
            }

            return false;
        }
    }
}
