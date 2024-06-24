using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text == "admin" && passwordTextBox.Text == "qwerty")
            {
                Hide();
                AdminWindow adminWindow = new();
                adminWindow.ShowDialog();
                ShowDialog();
                return;
            }
            if (loginTextBox.Text == "manager" && passwordTextBox.Text == "12345")
            {
                Hide();
                ManagerWindow managerWindow = new();
                managerWindow.ShowDialog();
                ShowDialog();
                return;
            }
            MessageBox.Show("Введены некорректные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
