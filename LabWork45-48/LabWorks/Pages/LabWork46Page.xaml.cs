using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWorks.Pages
{
    /// <summary>
    /// Логика взаимодействия для LabWork46Page.xaml
    /// </summary>
    public partial class LabWork46Page : Page
    {
        public LabWork46Page()
        {
            InitializeComponent();
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
                hintTextBlock.Visibility = Visibility.Hidden;
            else
                hintTextBlock.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (task2RadioButton.IsChecked == true)
            {
                hintPriceTextBlock.Visibility = Visibility.Visible;
                inputPriceTextBox.Visibility = Visibility.Visible;
                hintTextBlock.Text = "Введите id книги";
                executeButton.Width = 200;
                executeButton.Content = "Сменить цену книги";
            }
            if (task3RadioButton.IsChecked == true)
                hintTextBlock.Text = "Введите имя таблицы";
            if (task1RadioButton.IsChecked == true)
            {
                hintPriceTextBlock.Visibility = Visibility.Collapsed;
                inputPriceTextBox.Visibility = Visibility.Collapsed;
                hintTextBlock.Text = "Введите SQL запрос";
                executeButton.Width = 150;
                executeButton.Content = "Выполнить SQL команду";
            }
        }

        private void InpuPriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(inputPriceTextBox.Text.Length > 0)
                hintPriceTextBlock.Visibility = Visibility.Hidden;
            else
                hintPriceTextBlock.Visibility = Visibility.Visible;
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            if (task1RadioButton.IsChecked == true)
            {
                try
                {
                    outputTextBlock.Text = "Строк изменено - " + DataAccessLayer.GetAffectedRows(inputTextBox.Text);
                }
                catch(Exception ex)
                {
                    System.Windows.MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (task2RadioButton.IsChecked == true)
            {
                try
                {
                    if (DataAccessLayer.UpdateBookById(Convert.ToInt32(inputTextBox.Text), Convert.ToDecimal(inputPriceTextBox.Text)))
                        outputTextBlock.Text = "Команда выполнена успешно";
                    else
                        outputTextBlock.Text = $"Книги с ID {inputTextBox.Text} - не существует";
                }
                catch(Exception ex)
                {
                    System.Windows.MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (task3RadioButton.IsChecked == true)
            {
                try
                {
                    outputDataGrid.ItemsSource = DataAccessLayer.GetTableByName(inputTextBox.Text).DefaultView;
                }
                catch(Exception ex)
                {
                    System.Windows.MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
