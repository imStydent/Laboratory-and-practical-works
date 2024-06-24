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
            birthdayDatePicker.DisplayDateEnd = DateTime.Now;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(loginTextBox.Text) && passwordBox.Password == confirmationPasswordBox.Password
                    && !String.IsNullOrEmpty(userTextBox.Text) && !String.IsNullOrEmpty(passwordBox.Password))
                MessageBox.Show($"{loginTextBox.Text}, вы зарегистрированы");
        }

        private void AgeDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var today = DateTime.Today;
            var age = today.Year - birthdayDatePicker.SelectedDate.Value.Year;

            if (birthdayDatePicker.SelectedDate.Value.Date > today.AddYears(-age))
                    age--;

            ageLabel.Content = $"Возраст: {age}";
        }
    }
}