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

namespace LabWorks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new Pages.LabWork45Page());
        }

        private void LabWork45Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Pages.LabWork45Page());
        }

        private void LabWork46Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Pages.LabWork46Page());
        }

        private void LabWork47Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Pages.LabWork47Page());
        }

        private void LabWork48Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Pages.LabWork48Page());
        }
    }
}