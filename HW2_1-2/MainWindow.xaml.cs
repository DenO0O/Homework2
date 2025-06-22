using System.Windows;
using System.Windows.Media;

namespace HW2_1_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CTR_RedSignal.Fill = Brushes.Red;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CTR_RedSignal.Fill == Brushes.Red)
            {
                CTR_RedSignal.Fill = Brushes.Gray;
                CTR_YellowSignal.Fill = Brushes.Yellow;
            }
            else if (CTR_YellowSignal.Fill == Brushes.Yellow)
            {
                CTR_YellowSignal.Fill = Brushes.Gray;
                CTR_GreenSignal.Fill = Brushes.Green;
            }
            else if (CTR_GreenSignal.Fill == Brushes.Green)
            {
                CTR_GreenSignal.Fill = Brushes.Gray;
                CTR_RedSignal.Fill = Brushes.Red;
            }
        }
    }
}