using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_9.Products
{
    public class CocaCola : Product
    {
        public CocaCola(string name, double price, DateTime produceDate, DateTime expirationDate)
        {
            this.name = name;
            this.price = price;
            this.produceDate = produceDate;
            this.expirationDate = expirationDate;
        }

        public CocaCola(string name)
        {
            this.name = name;            ;
        }
    }
}
