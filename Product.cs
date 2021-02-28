using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingAndUpdateSourceTrigger
{
    class Product
    {
        string Description { get; set; }
        double Price { get; set; }
        internal Category Category { get; set; }

        public Product(string description, double price, Category category)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Price = price;
            Category = category;
        }

        public Product()
        {
            Description = "unknown";
            Price = 0.0;
            Category = Category.UNKNOWN;
        }
    }
}
