using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        byte redValue = 0, greenValue = 0, blueValue = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void ColorCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ChangeColor();
        }

        private void ColorCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeColor();
        }

        private void ChangeColor()
        {
            redValue = redCheckBox.IsChecked == true ? (byte)redSlider.Value : (byte)0;
            greenValue = greenCheckBox.IsChecked == true ? (byte)greenSlider.Value : (byte)0;
            blueValue = blueCheckBox.IsChecked == true ? (byte)blueSlider.Value : (byte)0;

            Background = new SolidColorBrush(Color.FromRgb(redValue, greenValue, blueValue));
        }
    }
}