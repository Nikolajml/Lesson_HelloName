namespace Lesson_HelloName.Classes.Lesson_11
{
    public class PriceMonitor
    {
        public delegate void PriceDelegat(int price);
        public static event PriceDelegat ConvenientPrice;

        public PriceMonitor(PriceDelegat priceDelegat)
        {
        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine("Enter a price you prefer:");
            int userPrice = int.Parse(Console.ReadLine());

            if (price < userPrice)
            {
                ConvenientPrice(price);
            }
            else
            {
                Console.WriteLine($"The current price ({price}) is more than price you prefer ({userPrice}).");
            }
        }
    }
}