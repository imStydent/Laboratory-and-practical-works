using System.Windows;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Manager.MainFrame = ContentFrame;
            ContentFrame.Navigate(new Pages.StartPage());
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.GoBack();
        }

        private void ContentFrame_ContentRendered(object sender, System.EventArgs e)
        {
            if (ContentFrame.CanGoBack)
                GoBackButton.Visibility = Visibility.Visible;
            else
                GoBackButton.Visibility = Visibility.Collapsed;
        }
    }
}
