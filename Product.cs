using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingAndUpdateSourceTrigger
{
    public class Product
    {
        internal string Description { get; set; }
        internal double Price { get; set; }
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

        public override string ToString()
        {
            return Description + "(" + Category.ToString() + ")" + " price: " + Price;
        }

        public override bool Equals(object obj)
        {
            return Category == ((Product)obj).Category &&
                Description == ((Product)obj).Description &&
                Price == ((Product)obj).Price;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
