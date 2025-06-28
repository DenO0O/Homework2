using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace HW2_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CTR_StatusString.Text = "Готов";
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                CTR_Text.Text = File.ReadAllText(openFileDialog.FileName);
                CTR_StatusString.Text = $"Открыт {openFileDialog.FileName}";
            }
        }

        private void ButtonSaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, CTR_Text.Text);
                CTR_StatusString.Text = $"Сохранено в {saveFileDialog.FileName}";
            }
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            var window = new WindowAbout();
            window.ShowDialog();
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Закрыть программу?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
                e.Cancel = true;
        }
    }
}