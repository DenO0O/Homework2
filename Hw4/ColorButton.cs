using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Hw4
{
    internal class ColorButton : Button
    {
        public ColorButton()
        {
            Content = "OFF";
            Background = Brushes.Red;

            Click += (sender, e) => isToggled = !isToggled;
        }

        public bool isToggled
        {
            get { return (bool)GetValue(isToggledProperty); }
            set { SetValue(isToggledProperty, value); }
        }

        public static readonly DependencyProperty isToggledProperty =
            DependencyProperty.Register(
                nameof(isToggled),
                typeof(bool),
                typeof(ColorButton),
                new FrameworkPropertyMetadata(false, isToggledPropertyChanged));

        private static void isToggledPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var btn = (ColorButton)d;
            bool newValue = (bool)e.NewValue;

            if (newValue)
            {
                btn.Content = "ON";
                btn.Background = Brushes.Green;
            }
            else
            {
                btn.Content = "OFF";
                btn.Background = Brushes.Red;
            }

        }
    }
}
