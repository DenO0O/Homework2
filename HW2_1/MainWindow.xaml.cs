using System.Windows;

namespace HW2_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int ClickCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            CTR_Clicks.Text = ClickCount.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClickCount++;
            CTR_Clicks.Text = ClickCount.ToString();
        }
    }
}