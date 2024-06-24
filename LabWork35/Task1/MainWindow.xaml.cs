using Microsoft.Win32;
using System.IO;
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
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "Текстовые файлы|*.txt|Файлы C#|*.cs|Файлы HTML|*.html|Файлы CSS|*.css|Файлы JavaScript|*.js|" +
                "Файлы SQL|*.sql",
                InitialDirectory = Environment.CurrentDirectory,
            };

            if (dialog.ShowDialog() != true)
                return;
            Title = dialog.SafeFileName;
            outputTextBox.Text = File.ReadAllText(dialog.FileName);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Filter = "Текстовые файлы|*.txt|Файлы C#|*.cs|Файлы HTML|*.html|Файлы CSS|*.css|Файлы JavaScript|*.js|" +
                "Файлы SQL|*.sql",
                InitialDirectory = Environment.CurrentDirectory,
            };

            if (dialog.ShowDialog() != true)
                return;
            File.WriteAllText(dialog.FileName, outputTextBox.Text);
            MessageBox.Show("Файл успешно сохранён", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть приложение?", "Подтверждение", MessageBoxButton.YesNo, 
                MessageBoxImage.Question) != MessageBoxResult.Yes)
                e.Cancel = true;
        }
    }
}