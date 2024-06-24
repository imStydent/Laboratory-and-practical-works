using System.IO;
using System.Windows;
using System.Linq;

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

        private void GetFilterData()
        {
            DirectoryInfo directory = new(@"C:\Temp");
            //"C:\Temp\ispp21_1\МДК.01.01"
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
            DirectoryInfo[] directories = directory.GetDirectories("*", SearchOption.AllDirectories);

            var result = files.Select(files => files.DirectoryName).Union(files.Select(files => files.Name));

            resultDataGrid.ItemsSource = result;
        }
    }
}
