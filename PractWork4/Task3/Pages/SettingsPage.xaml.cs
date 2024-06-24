using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Task3.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();

            using (StreamReader reader = new StreamReader("userData.txt"))
            {
                string userData;

                foreach (var line in reader.ReadLine())
                {
                    MessageBox.Show(userData = line.ToString());
                }
            }

            //loginTextBox.Text = Properties.Settings.Default.Login;
            //emailTextBox.Text = Properties.Settings.Default.Email;
            //passwordTextBox.Text = Properties.Settings.Default.Password;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //Properties.Settings.Default.Login = loginTextBox.Text;
            //Properties.Settings.Default.Email = emailTextBox.Text;
            //Properties.Settings.Default.Password = passwordTextBox.Text;
            //Properties.Settings.Default.Save();

            var dialogResult = MessageBox.Show("Изменения сохранены, вернуться на главную", "Успешно",
                MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (dialogResult == MessageBoxResult.Yes)
                Manager.MainFrame.GoBack();
        }
    }
}
