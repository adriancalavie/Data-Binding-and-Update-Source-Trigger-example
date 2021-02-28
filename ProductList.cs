using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingAndUpdateSourceTrigger
{
    class ProductList
    {
        public ProductList(List<Product> products)
        {
            ListOfProducts = new ObservableCollection<string>();

            foreach (var product in products)
            {
                ListOfProducts.Add(product.ToString());
            }
        }

        public ObservableCollection<string> ListOfProducts { get; set; }
    }
}
