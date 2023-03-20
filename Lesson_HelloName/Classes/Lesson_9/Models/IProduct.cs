using Microsoft.VisualBasic;

namespace Lesson_HelloName.Classes.Lesson_9.Models
{
    public interface IProduct
    {
        /// <summary>
        /// Gets or sets product name
        /// </summary>
        public string name { get; set; }
        
        /// <summary>
        /// Gets or sets product price
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// Gets or sets date of manufactore product
        /// </summary>
        public DateTime produceDate { get; set; }

        /// <summary>
        /// Gets or sets expiration date
        /// </summary>
        public DateTime expirationDate { get; set; }
    }
}
