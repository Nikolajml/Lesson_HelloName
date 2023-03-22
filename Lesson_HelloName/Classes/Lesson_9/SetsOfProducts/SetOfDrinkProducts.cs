using Lesson_HelloName.Classes.Lesson_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_9.SetsOfProducts
{
    public class SetOfDrinkProducts : ISetOfProducts
    {
        public string name { get; set; }
        public double price { get; set; }
        public List<Product> products { get; set; }

        public SetOfDrinkProducts(string name, double price, List<Product> products)
        {
            this.name = name;
            this.price = price;
            this.products = products;
        }

        public void Info()
        {
            Console.WriteLine($"Set of {name} products");
            Console.WriteLine($"Set price: {price}$; \n");

            foreach (var product in products)
            {
                product.Info();
            }            
        }

        public void CheckIfProductExpired()
        {
            var expiredProducts = new List<Product>();

            foreach (var product in products)
            {                
                if (product.CheckIfProductExpired())
                {
                    expiredProducts.Add(product);
                }
            }

            Console.WriteLine("Expired Products in set of drinks products: \n");

            foreach (var expiredProduct in expiredProducts)
            {
                expiredProduct.Info();
            }
        }
    }
}
