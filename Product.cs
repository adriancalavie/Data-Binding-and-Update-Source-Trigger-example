using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingAndUpdateSourceTrigger
{
    public class Product: IEquatable<Product> , IComparable<Product>

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

        public int CompareTo(Product compareProduct)
        {
            // A null value means that this object is greater.
            if (compareProduct == null)
                return 1;

            else
                return this.Price.CompareTo(compareProduct.Price);
        }

        public override int GetHashCode() => base.GetHashCode();

        public bool Equals(Product other)
        {
            if (other == null) return false;
            return (this.Price.Equals(other.Price));
        }
    }
}
