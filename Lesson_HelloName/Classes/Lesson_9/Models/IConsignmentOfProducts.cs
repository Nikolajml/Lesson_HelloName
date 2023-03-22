using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_9.Models
{
    public interface IConsignmentOfProducts : IProduct
    {
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        int count { get; set; }
    }
}
