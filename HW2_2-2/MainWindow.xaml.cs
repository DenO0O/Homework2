using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HW2_2_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var CTR_button = (Button)sender;
            var sizeH = CTR_Area.ActualHeight - CTR_button.ActualHeight;
            var sizeW = CTR_Area.ActualWidth - CTR_button.ActualWidth;

            CTR_button.Margin = new Thickness(rand.Next(0, (int)sizeW), rand.Next(0, (int)sizeH), 0, 0);

        }
    }
}