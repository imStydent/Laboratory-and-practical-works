using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace Task4
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

            var result = files.Join().Where(files => files.CreationTime.Day == DateTime.Now.Day);

            resultDataGrid.ItemsSource = result;
        }
    }
}
