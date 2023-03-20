namespace Lesson_HelloName.Classes.Lesson_9.Products
{
    public class Milk : Product
    {
        public Milk(string name, double price, DateTime produceDate, DateTime expirationDate)
        {
            this.name = name;
            this.price = price;
            this.produceDate = produceDate;
            this.expirationDate = expirationDate;
        }

        public Milk(string name)
        {
            this.name = name;            
        }
    }
}
