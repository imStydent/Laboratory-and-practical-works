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

namespace Task2
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

        private void ShowPasswordCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (showPasswordCheckBox.IsChecked == true)
            {
                passwordBox.Visibility = Visibility.Collapsed;
                visiblePasswordTextBox.Visibility = Visibility.Visible;
                visiblePasswordTextBox.Text = passwordBox.Password;
            }
            else
            {
                passwordBox.Visibility = Visibility.Visible;
                visiblePasswordTextBox.Visibility = Visibility.Collapsed;
                passwordBox.Password = visiblePasswordTextBox.Text; 
            }
        }
    }
}