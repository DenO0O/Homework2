using System.Windows;
using System.Windows.Controls;

namespace hw2_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CTR_Name.Text == "" || CTR_Name.Text == null)
            {
                MessageBox.Show("Введите ваше имя");
                return;
            }
            if (CTR_Check.IsChecked != true)
            {
                MessageBox.Show("Требуется согласие на обработку даных");
                return;
            }

            var txt = string.Join(",", CTR_CourseNames.SelectedItems.Cast<ListBoxItem>().Select(x => x.Content));
            var txt2 = CTR_FullTime.IsChecked == true ? "Очная" : "Заочная";

            MessageBox.Show($"Студент: {CTR_Name.Text}\nФакультет: {CTR_FakultetNames.Text}\nКурсы: {txt}\nФорма: {txt2}\nЧасов в неделю: {CTR_Hours.Value}", "Данные отправлены");

        }
    }
}