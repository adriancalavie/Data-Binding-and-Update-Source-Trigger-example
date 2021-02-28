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


using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingAndUpdateSourceTrigger
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddItem : Window
    {
        private List<Product> productList;
        private bool hasChanged;
        private Product product;

        public AddItem(List<Product> products)
        {
            product = new Product();
            this.productList = products;
            hasChanged = false;

            InitializeComponent();

            DataContext = new CategoryList();
        }

        private void DescirptionChanged(object sender, TextChangedEventArgs e)
        {
            product.Description = NewItemDesciption.Text;
            hasChanged = true;
        }
        private void PriceChanged(object sender, TextChangedEventArgs e)
        {

            if (double.TryParse(NewItemPrice.Text, out double result))
            {
                product.Price = result;
            }
            else
            {
                Console.WriteLine("Error parsing double");
            }

            hasChanged = true;
        }
        private void SubmitNewItem(object sender, RoutedEventArgs e)
        {
            //TODO 
            if (hasChanged)
            {
                productList.Add(product);
            }
            Hide();
        }

        private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            product.Category = ((string)CategoryComboBox.SelectedItem).ToCategoryValue();
            hasChanged = true;
        }
    }
}
