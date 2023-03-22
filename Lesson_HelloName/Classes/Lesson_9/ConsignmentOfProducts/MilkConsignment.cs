using Lesson_HelloName.Classes.Lesson_9.Models;

namespace Lesson_HelloName.Classes.Lesson_9.ConsignmentOfProducts
{
    public class MilkConsignment : IConsignmentOfProducts
    {
        public MilkConsignment(string name, double price, DateTime produceDate, DateTime expirationDate, int count)
        {
            this.name = name;
            this.price = price;
            this.produceDate = produceDate;
            this.expirationDate = expirationDate;
            this.count = count;
        }

        public int count { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public DateTime produceDate { get; set; }
        public DateTime expirationDate { get; set; }
    }
}
