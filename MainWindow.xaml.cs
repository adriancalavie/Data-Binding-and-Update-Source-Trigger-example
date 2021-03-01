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

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingAndUpdateSourceTrigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {

        internal List<Product> Products { get => products; set => products = value; }

        private string _test;
        public string Test
        {
            get => _test;
            set
            { 
                if(value != _test)
                {
                    _test = value;
                    OnPropertyChanged();
                }
            } 
        }



        public static List<Product> products;
        private ShowItems show;
        private AddItem addItem;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Category category = Category.ELECTRONICS;

            Test = category.ToString();

            products = new List<Product>();
            //show = new ShowItems(products);
            //addItem = new AddItem(products);

            Products.Add(new Product("Gaming computer", 3599.99, Category.ELECTRONICS));
            Products.Add(new Product("Office computer", 1999.99, Category.ELECTRONICS));
            Products.Add(new Product("Microwave oven", 400.0, Category.ELECTRONICS));
            Products.Add(new Product("Monitor", 350.0, Category.ELECTRONICS));

            Products.Add(new Product("Running shoes", 250.0, Category.SPORTS));
            Products.Add(new Product("Gym bag", 100.0, Category.SPORTS));
            Products.Add(new Product("Dumbbell set", 85.0, Category.SPORTS));
            Products.Add(new Product("Gym trousers", 89.99, Category.SPORTS));
            Products.Add(new Product("Basketball jersey", 30.0, Category.SPORTS));
            Products.Add(new Product("Tennis ball", 5.99, Category.SPORTS));
            Products.Add(new Product("Football gloves", 17.99, Category.SPORTS));

            Products.Add(new Product("Björkåsen", 24.99, Category.HOME));
            Products.Add(new Product("Lenast", 12.99, Category.HOME));
            Products.Add(new Product("Undvika", 29.99, Category.HOME));
            Products.Add(new Product("Rådfråga", 9.99, Category.HOME));
            Products.Add(new Product("Älvstarr", 34.99, Category.HOME));
            Products.Add(new Product("Glenn", 79.99, Category.HOME));
            Products.Add(new Product("Sagstua", 169.0, Category.HOME));
        }

        private void Button_Click_Show_Items(object sender, RoutedEventArgs e)
        {
            show = new ShowItems(products);
            //Test = "2";
            show.Show();
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            if(show!=null)
                show.Close();
            if(addItem!=null)
                addItem.Close();
            Close();
        }

        private void Button_Click_Add_Item(object sender, RoutedEventArgs e)
        {
            addItem = new AddItem(products);
            addItem.Show();
        }

    }

   
}
