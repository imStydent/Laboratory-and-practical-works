using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
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

        bool buttonClick = false;

        private void hamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = menu.ActualHeight;

            if(buttonClick == false)
            {
                doubleAnimation.To = 150;
                doubleAnimation.Duration = TimeSpan.FromSeconds(1);
                menu.BeginAnimation(Button.WidthProperty, doubleAnimation);
                buttonClick = true;
            }
            else
            {
                doubleAnimation.To = 50;
                doubleAnimation.Duration = TimeSpan.FromSeconds(1);
                menu.BeginAnimation(Button.WidthProperty, doubleAnimation);
                buttonClick = false;
            }
        }
    }
}