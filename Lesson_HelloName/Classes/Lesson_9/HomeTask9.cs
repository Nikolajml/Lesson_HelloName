using Lesson_HelloName.Classes.Lesson_9.ConsignmentOfProducts;
using Lesson_HelloName.Classes.Lesson_9.Models;
using Lesson_HelloName.Classes.Lesson_9.Products;
using Lesson_HelloName.Classes.Lesson_9.SetsOfProducts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_9
{
    internal class HomeTask9
    {
        public static void Task0()
        {
            ArrayList list = new ArrayList();

            try
            {
                object s = list[18];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine($"Message: {ex.Message}");
            }

            var newList = new Dictionary<string, int>()
            {
                ["One"] = 1,
                ["Two"] = 2,
                ["Three"] = 3,
                ["Four"] = 4,
                ["Five"] = 5,
                ["Six"] = 6,
                ["Seven"] = 7,
                ["Eight"] = 8,
                ["Nine"] = 9,
                ["Ten"] = 10,
            };

            foreach (var value in newList)
            {
                Console.WriteLine(value);
            }
        }

        public static void Task1()
        {
            var products = new List<Product>()
            {
                new Milk("Milkavita", 1.4, new DateTime(2023, 1, 11), new DateTime(2023, 3, 21)),
                new Milk("Borisov", 2.2, new DateTime(2023, 1, 31), new DateTime(2023, 4, 26)),
                new Milk("Belakt", 0.7, new DateTime(2023, 2, 19), new DateTime(2023, 3, 19)),
                new Milk("Pinsk", 1.88, new DateTime(2023, 3, 1), new DateTime(2023, 3, 10)),
                new Milk("Brest Milk", 0.99, new DateTime(2022, 12, 30), new DateTime(2023, 3, 29)),
            };

            var expiredProducts = new List<Product>();

            Console.WriteLine("All Products: \n");

            foreach (var product in products)
            {
                product.Info();
                            
                if (product.CheckIfProductExpired())
                {
                    expiredProducts.Add(product);
                }
            }

            Console.WriteLine("Expired Products: \n");

            foreach (var expiredProduct in expiredProducts)
            {
                expiredProduct.Info();
            }

            MilkConsignment milkConConsignment = new MilkConsignment("Milkavita", 100, new DateTime(2023, 1, 11), new DateTime(2023, 3, 21), 120);

            var drinkHappyProducts = new List<Product>()
            {
                new Milk("Milkavita", 1.4, new DateTime(2023, 1, 11), new DateTime(2023, 3, 21)),
                new Milk("Borisov", 2.2, new DateTime(2023, 1, 31), new DateTime(2023, 4, 26)),
                new Milk("Belakt", 0.7, new DateTime(2023, 2, 19), new DateTime(2023, 3, 19)),
                new Milk("Pinsk", 1.88, new DateTime(2023, 3, 1), new DateTime(2023, 3, 10)),
                new Milk("Brest Milk", 0.99, new DateTime(2022, 12, 30), new DateTime(2022, 3, 29)),
                new CocaCola("CocaCola 1", 1.99, new DateTime(2022, 12, 30), new DateTime(2024, 3, 29)),
                new CocaCola("Spanish Cola", 2.99, new DateTime(2021, 12, 30), new DateTime(2024, 9, 13)),
                new CocaCola("BelaCola", 0.99, new DateTime(2023, 12, 30), new DateTime(2022, 7, 15)),
            };

            SetOfDrinkProducts setOfDrinkProducts = new SetOfDrinkProducts("Happy drinks", 300, drinkHappyProducts);

            setOfDrinkProducts.Info();
            setOfDrinkProducts.CheckIfProductExpired();


            //Task 1.1

            List<Product> products_1 = new List<Product>()
            {
                new Milk("Borisov", 2.2, new DateTime(2023, 1, 31), new DateTime(2023, 4, 26)),
                new Milk("Belakt", 0.7, new DateTime(2023, 2, 19), new DateTime(2023, 3, 19)),
                new Milk("Borisov", 2.2, new DateTime(2023, 1, 31), new DateTime(2023, 4, 26)),
                new Milk("Belakt", 0.7, new DateTime(2023, 2, 19), new DateTime(2023, 3, 19)),
                new CocaCola("Spanish Cola", 2.99, new DateTime(2021, 12, 30), new DateTime(2024, 9, 13)),
                new CocaCola("BelaCola", 0.99, new DateTime(2023, 12, 30), new DateTime(2022, 7, 15)),
            };

            foreach (var product in products_1)
            {                
                product.Info();
            }

            // Change price

            products_1[4] = new CocaCola("Spanish Cola", 100.00, new DateTime(2021, 12, 30), new DateTime(2024, 9, 13));

            //Delete the last product

            products_1.RemoveAt(products_1.Count - 1);

            Console.WriteLine("\nThe result after delet:");

            foreach (var product in products_1)
            {
                product.Info();
            }
             
            //Remove all products
            products_1.Clear();


            //Task 1.2

            List<Product> products_2 = new List<Product>()
            {
                new Milk("Borisov", 200.00, new DateTime(2023, 1, 31), new DateTime(2023, 4, 26)),
                new Milk("Belakt", 122.22, new DateTime(2023, 2, 19), new DateTime(2023, 3, 19)),
                new CocaCola("Spanish Cola", 332.78, new DateTime(2021, 12, 30), new DateTime(2024, 9, 13)),
                new CocaCola("BelaCola", 100.99, new DateTime(2023, 12, 30), new DateTime(2022, 7, 15)),
                new CocaCola("BelaCola", 200.99, new DateTime(2023, 12, 30), new DateTime(2022, 7, 15)),
                new CocaCola("BelaCola", 400.99, new DateTime(2023, 12, 30), new DateTime(2022, 7, 15)),
            };
              
            foreach (var product in products_2)
            {
                if(product.price > 300)
                {
                    var higherPriceProducts = new List<Product>(products_2);                                        
                    Console.WriteLine(product.price);                                        
                }
            }


            //HomeTask 1.3

            var currentProducts = new Dictionary<Product, int>()
            {
                [new Milk("Borisov")] = 11,
                [new Milk("Belakt")] = 22,
                [new Milk("Milkavita")] = 30,
                [new CocaCola("BelaCola")] = 22,
            };

            foreach (KeyValuePair<Product, int> product in currentProducts)
            {
                Console.WriteLine($"{product.Key}, Count = {product.Value}");
            }

            foreach (KeyValuePair<Product, int> product in currentProducts)
            {
                Console.WriteLine($"{product.Key}");
            }

            foreach (KeyValuePair<Product, int> product in currentProducts)
            {
                Console.WriteLine($"Price:{product.Value}");
            }              
        }
    }       
}
