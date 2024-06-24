using System.Windows;
using System.Windows.Controls;

namespace LabWorks.Pages
{
    /// <summary>
    /// Логика взаимодействия для LabWork47Page.xaml
    /// </summary>
    public partial class LabWork47Page : Page
    {
        public LabWork47Page()
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

        private void InpuPriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (inputPriceTextBox.Text.Length > 0)
                hintPriceTextBlock.Visibility = Visibility.Hidden;
            else
                hintPriceTextBlock.Visibility = Visibility.Visible;
        }

        private void GenreOrTitleTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (genreOrTitleTextBox.Text.Length > 0)
                hintGenreOrTitleTextBlock.Visibility = Visibility.Hidden;
            else
                hintGenreOrTitleTextBlock.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (task2RadioButton.IsChecked == true)
            {
                hintPriceTextBlock.Visibility = Visibility.Collapsed;
                inputPriceTextBox.Visibility = Visibility.Collapsed;
                hintGenreOrTitleTextBlock.Visibility = Visibility.Collapsed;
                genreOrTitleTextBox.Visibility = Visibility.Collapsed;
                hintTextBlock.Text = "Введите SQL команду";
                executeButton.Width = 200;
                executeButton.Content = "Выполнить команду на вставку";
            }
            if (task3RadioButton.IsChecked == true)
            {
                hintPriceTextBlock.Visibility = Visibility.Visible;
                inputPriceTextBox.Visibility = Visibility.Visible;
                hintGenreOrTitleTextBlock.Visibility = Visibility.Visible;
                genreOrTitleTextBox.Visibility = Visibility.Visible;
                hintTextBlock.Visibility = Visibility.Collapsed;
                inputTextBox.Visibility = Visibility.Collapsed;
                executeButton.Content = "Выполнить команду на вставку";
            }
            if (task1RadioButton.IsChecked == true)
            {
                hintPriceTextBlock.Visibility = Visibility.Collapsed;
                inputPriceTextBox.Visibility = Visibility.Collapsed;
                hintGenreOrTitleTextBlock.Visibility = Visibility.Collapsed;
                genreOrTitleTextBox.Visibility = Visibility.Collapsed;
                hintTextBlock.Text = "Введите цену";
                executeButton.Width = 200;
                executeButton.Content = "Вывести количество книг";
            }
            if (task4RadioButton.IsChecked == true)
            {
                hintPriceTextBlock.Visibility = Visibility.Visible;
                inputPriceTextBox.Visibility = Visibility.Visible;
                hintGenreOrTitleTextBlock.Visibility = Visibility.Visible;
                genreOrTitleTextBox.Visibility = Visibility.Visible;
                hintTextBlock.Visibility = Visibility.Visible;
                inputTextBox.Visibility = Visibility.Visible;
                hintTextBlock.Text = "Введите id книги";
                hintGenreOrTitleTextBlock.Text = "Введите название книги";
                executeButton.Content = "Изменить цену";
            }
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            if (task1RadioButton.IsChecked == true)
            {
                try
                {
                    outputTextBlock.Text = $"Количество книг с ценой, меньше {inputTextBox.Text} - " + DataAccessLayer.GetBooksCountByPrice(Convert.ToDecimal(inputTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (task2RadioButton.IsChecked == true)
            {
                try
                {
                    outputTextBlock.Text = $"ID добавленной записи - " + DataAccessLayer.GetId(inputTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (task3RadioButton.IsChecked == true)
            {
                try
                {
                    outputDataGrid.ItemsSource = DataAccessLayer.GetBooksByPriceAndGenre(Convert.ToDecimal(inputPriceTextBox.Text), genreOrTitleTextBox.Text).DefaultView;
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
                    if (DataAccessLayer.ChangeBook(Convert.ToInt32(inputTextBox.Text), Convert.ToDecimal(inputPriceTextBox.Text), genreOrTitleTextBox.Text))
                        MessageBox.Show("Изменение данных прошло успешно", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении команды: {ex}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
