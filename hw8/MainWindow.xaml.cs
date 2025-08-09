using System.Collections.ObjectModel;
using System.Windows;

namespace hw8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products = new ObservableCollection<Product>();

        public MainWindow()
        {
            InitializeComponent();

            products.Add(new Product() {
                Name = "Телевизор1",
                ProductCategory = Category.homeTechnic,
                Price = 123216,
                PicturePath = "pic/hometech.png"
            });
            products.Add(new Product() {
                Name = "Торт1",
                ProductCategory = Category.food,
                Price = 555,
                PicturePath = "pic/food.png"
            });
            products.Add(new Product() {
                Name = "Телевизор2",
                ProductCategory = Category.homeTechnic,
                Price = 50000,
                PicturePath = "pic/hometech.png"
            });
            products.Add(new Product() {
                Name = "Торт2",
                ProductCategory = Category.food,
                Price = 555,
                PicturePath = "pic/food.png"
            });

            lstProducts.ItemsSource = products;

        }
    }
}