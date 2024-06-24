using System.IO;
using System.Windows;
using System.Windows.Controls;

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
            GetFilterData();
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetFilterData();
        }

        private void GetFilterData()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp21_1\МДК.01.01");
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

            var result = files.Where(files => files.Name.ToLower().Contains(inputTextBox.Text.ToLower())).ToList();
            resultDataGrid.ItemsSource = result;
            fileCountTextBlock.Text = $"Показано {result.Count} файлов из {files.Count()}";
            if (result.Count == 0)
                fileCountTextBlock.Text = "Записей по заданному филтру не найдено";

        }
    }
}