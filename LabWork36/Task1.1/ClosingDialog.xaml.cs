using System.Windows;

namespace Task1._1
{
    /// <summary>
    /// Логика взаимодействия для ClosingDialog.xaml
    /// </summary>
    public partial class ClosingDialog : Window
    {
        public ClosingDialog()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
