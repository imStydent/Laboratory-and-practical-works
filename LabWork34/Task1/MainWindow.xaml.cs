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
            dateStatusBarItem.Content = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            symbolStatusBarItem.Content = inputTextBox.Text.Length;
        }

        private void StatusBarMenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            statusBar.Visibility = Visibility.Collapsed;
        }

        private void StatusBarMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            if(statusBar != null)
                statusBar.Visibility = Visibility.Visible;
        }

        private void ScaleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (scaleValueStatusBarItem != null)
                scaleValueStatusBarItem.Content = Math.Round(scaleSlider.Value) + "%";
        }

        private void ClearMenuItem_Click(object sender, RoutedEventArgs e)
        {
            inputTextBox.Clear();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}