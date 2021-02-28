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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingAndUpdateSourceTrigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Product> products;

        public MainWindow()
        {
            InitializeComponent();

            products.Add(new Product("Gaming computer", 3599.99, Category.ELECTRONICS));
            products.Add(new Product("Office computer", 1999.99, Category.ELECTRONICS));
            products.Add(new Product("Microwave oven", 400.0, Category.ELECTRONICS));
            products.Add(new Product("Monitor", 350.0, Category.ELECTRONICS));
            
            products.Add(new Product("Running shoes", 250.0, Category.SPORTS));
            products.Add(new Product("Gym bag", 100.0, Category.SPORTS));
            products.Add(new Product("Dumbbell set", 85.0, Category.SPORTS));
            products.Add(new Product("Gym trousers", 89.99, Category.SPORTS));
            products.Add(new Product("Basketball jersey", 30.0, Category.SPORTS));
            products.Add(new Product("Tennis ball", 5.99, Category.SPORTS));
            products.Add(new Product("Football gloves", 17.99, Category.SPORTS));

            products.Add(new Product("Björkåsen", 24.99, Category.HOME));
            products.Add(new Product("Lenast", 12.99, Category.HOME));
            products.Add(new Product("Undvika", 29.99, Category.HOME));
            products.Add(new Product("Rådfråga", 9.99, Category.HOME));
            products.Add(new Product("Älvstarr", 34.99, Category.HOME));
            products.Add(new Product("Glenn", 79.99, Category.HOME));
            products.Add(new Product("Sagstua", 169.0, Category.HOME));
        }
    }
}
