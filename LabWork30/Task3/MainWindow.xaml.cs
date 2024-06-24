using System.Windows;
using System.Windows.Controls;

namespace Task3
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

        private void FontSizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            inputTextBox.FontSize = Convert.ToInt32(radioButton.Content);
        }

        private void LeftAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            inputTextBox.TextAlignment = TextAlignment.Left;
        }

        private void CenterAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            inputTextBox.TextAlignment = TextAlignment.Center;
        }

        private void RightAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            inputTextBox.TextAlignment = TextAlignment.Right;
        }
    }
}