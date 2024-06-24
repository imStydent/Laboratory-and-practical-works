using System.Windows;
using System.Windows.Controls;

namespace LabWorks.Pages
{
    /// <summary>
    /// Логика взаимодействия для LabWork48Page.xaml
    /// </summary>
    public partial class LabWork48Page : Page
    {
        public LabWork48Page()
        {
            InitializeComponent();
        }

        private void SurnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (surnameTextBox.Text.Length > 0)
                hintSurnameTextBlock.Visibility = Visibility.Hidden;
            else
                hintSurnameTextBlock.Visibility = Visibility.Visible;
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (nameTextBox.Text.Length > 0)
                hintNameTextBlock.Visibility = Visibility.Hidden;
            else
                hintNameTextBlock.Visibility = Visibility.Visible;
        }

        private void CountryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (countryTextBox.Text.Length > 0)
                hintCountryTextBlock.Visibility = Visibility.Hidden;
            else
                hintCountryTextBlock.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
           if(task4RadioButton.IsChecked == true)
           {
                countryTextBox.Visibility = Visibility.Collapsed;
                hintCountryTextBlock.Visibility = Visibility.Collapsed;

                hintSurnameTextBlock.Text = "Введите начальную цену";
                hintNameTextBlock.Text = "Введите конечную цену";
            }
           else
           {
                surnameTextBox.Visibility = Visibility.Visible;
                hintSurnameTextBlock.Visibility = Visibility.Visible;
                nameTextBox.Visibility = Visibility.Visible;
                hintNameTextBlock.Visibility = Visibility.Visible;
                countryTextBox.Visibility = Visibility.Visible;
                hintCountryTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            if(task2RadioButton.IsChecked == true)
            {
                try
                {
                    DataAccessLayer.AddAuthor(surnameTextBox.Text, nameTextBox.Text, countryTextBox.Text);
                    outputTextBlock.Text = "Автор добавлен";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if(task3RadioButton.IsChecked == true)
            {
                try
                {
                    outputTextBlock.Text = $"Добавлен автор с идентификатором  - {DataAccessLayer.GetAuthorId(surnameTextBox.Text, nameTextBox.Text, countryTextBox.Text)}";
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if(task4RadioButton.IsChecked == true)
            {
                try
                {
                    outputDataGrid.ItemsSource = DataAccessLayer.GetBooks(Convert.ToDecimal(surnameTextBox.Text), Convert.ToDecimal(nameTextBox.Text)).DefaultView;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
