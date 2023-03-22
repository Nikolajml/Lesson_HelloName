namespace Lesson_HelloName.Classes.Lesson_9.Models
{
    public interface ISetOfProducts
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
        /// Gets or Sets products list
        /// </summary>
        public List<Product> products { get; set; }
    }
}
