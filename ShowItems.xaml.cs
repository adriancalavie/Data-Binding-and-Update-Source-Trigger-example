using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBindingAndUpdateSourceTrigger
{
    /// <summary>
    /// Interaction logic for ShowItems.xaml
    /// </summary>
    public partial class ShowItems : Window
    {
        List<Product> products;
        public ShowItems(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
            DataContext = new ProductList(products);
        }

        private void SortAscendingCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SortDescendingCheckBox.IsChecked = false;
            products.Sort(delegate (Product x, Product y)
            {
                return x.Price.CompareTo(y.Price);
            });

            DataContext = new ProductList(products);
        }

        private void SortDescendingCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SortAscendingCheckBox.IsChecked = false;
            products.Sort(delegate (Product x, Product y)
            {
                return x.Price.CompareTo(y.Price);
            });

            products.Reverse();

            DataContext = new ProductList(products);
        }

        private void GroupByCategory_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
