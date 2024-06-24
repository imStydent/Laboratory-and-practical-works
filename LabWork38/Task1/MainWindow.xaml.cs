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
            GetFilterData();
        }

        int pageSize = 5;

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetFilterData();
        }

        private void GetFilterData()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp21_1\МДК.01.01");
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

            var lastPageNumber = files.ToList().Count() % 5;
            var result = files.Where(files => files.Name.ToLower().Contains(inputTextBox.Text.ToLower())).ToList();
            resultDataGrid.ItemsSource = result.OrderBy(files => files.Name).Take(pageSize);
            fileCountTextBlock.Text = $"Показано {result.Count} файлов из {files.Count()}";
            if (result.Count == 0)
                fileCountTextBlock.Text = "Записей по заданному филтру не найдено";
        }

        private void SeeMoreButton_Click(object sender, RoutedEventArgs e)
        {
            pageSize += pageSize;
            GetFilterData();
        }     

        private void PageSizeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            pageSize = Convert.ToInt32(pageSizeTextBox.Text);
            GetFilterData();
        }
    }
}