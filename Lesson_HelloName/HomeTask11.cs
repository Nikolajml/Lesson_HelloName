using Lesson_HelloName.Classes.Lesson_11;
using static Lesson_HelloName.Classes.Lesson_11.PriceMonitor;

namespace Lesson_HelloName
{
    internal class HomeTask11
    {
        public static void Task1()
        {
            Person person = new Person("Ivan");
            PriceMonitor monitor = new PriceMonitor(ShowPrice);
            
            Random random = new Random();

            PriceDelegat priceDelegat = ShowPrice;
            ConvenientPrice += person.RentApartment;

            priceDelegat(random.Next(100, 700));
            priceDelegat(random.Next(100, 700));
            priceDelegat(random.Next(100, 700));
            priceDelegat(random.Next(100, 700));
            priceDelegat(random.Next(100, 700));
        }        
    }
}
