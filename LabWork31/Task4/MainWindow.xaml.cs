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

namespace Task4
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

        private void PriceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            priceLabel.Content = Math.Round(priceSlider.Value, 2);
            resultLabel.Content = Math.Round(priceSlider.Value - (discountSlider.Value * priceSlider.Value) / 100, 2);
        }

        private void DiscountSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            discountLabel.Content = Math.Round(discountSlider.Value, 2);
            resultLabel.Content = Math.Round(priceSlider.Value - (discountSlider.Value * priceSlider.Value) / 100 , 2);
        }
    }
}