using System.Windows;
using System.Windows.Controls;

namespace LabWorks.Pages
{
    /// <summary>
    /// Логика взаимодействия для LabWork45Page.xaml
    /// </summary>
    public partial class LabWork45Page : Page
    {
        public LabWork45Page()
        {
            InitializeComponent();
            outputTextBlock.Text = $"Строка подключения: {DataAccessLayer.ConnectionString}";
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
                hintTextBlock.Visibility = Visibility.Hidden;
            else
                hintTextBlock.Visibility = Visibility.Visible;
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            if(task2RadioButton.IsChecked == true)
            {
                try
                {
                    outputTextBlock.Text = DataAccessLayer.GetValue(inputTextBox.Text).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (task3RadioButton.IsChecked == true)
            {
                try
                {
                    outputDataGrid.ItemsSource = DataAccessLayer.GetTable(inputTextBox.Text).DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (task4RadioButton.IsChecked == true)
            {
                try
                {
                    outputDataGrid.ItemsSource = DataAccessLayer.GetBooks(inputTextBox.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (task4RadioButton.IsChecked == true)
            {
                executeButton.Width = 200;
                executeButton.Content = "Вывести информацию о книгах";
            }
            else
            {
                executeButton.Width = 150;
                executeButton.Content = "Выполнить SQL команду";
            }
        }
    }
}
