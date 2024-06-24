using System.Windows;

namespace Task1._1
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

        private void NewWindowMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new();
            window.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ClosingDialog closingWindow = new();
            closingWindow.Owner = this;
            closingWindow.ShowDialog();
            if (closingWindow.DialogResult != true)
                e.Cancel = true;
        }
    }
}