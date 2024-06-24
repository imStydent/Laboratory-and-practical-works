using System.Configuration;
using System.IO;
using System.Threading.Channels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Xml.Linq;
using Task2.Properties;

namespace Task2.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();

            loginTextBox.Text = ConfigurationManager.AppSettings["Login"];
            emailTextBox.Text = ConfigurationManager.AppSettings["Email"];
            passwordTextBox.Text = ConfigurationManager.AppSettings["Password"];
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Login"].Value = loginTextBox.Text;
            config.AppSettings.Settings["Email"].Value = emailTextBox.Text;
            config.AppSettings.Settings["Password"].Value = passwordTextBox.Text;
            config.Save(ConfigurationSaveMode.Full);

            var dialogResult = MessageBox.Show("Изменения сохранены, вернуться на главную", "Успешно", 
                MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (dialogResult == MessageBoxResult.Yes)
                Manager.MainFrame.GoBack();
        }
    }
}
