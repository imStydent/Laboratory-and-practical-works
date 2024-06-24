using System.Reflection;
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

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<SolidColorBrush> brushes;
        private string[] tags = { "enemy", "hero", "treasure" };
        Ellipse ellipse = new();

        public MainWindow()
        {
            InitializeComponent();
            brushes = new List<SolidColorBrush>()
            {
                Brushes.Black,
                Brushes.AliceBlue,
                Brushes.Blue,
                Brushes.Green,
                Brushes.LightPink
            };
        }

        private void MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show((string)ellipse.Tag);
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
                Random random = new();
                ellipse = new Ellipse();
                int radius = random.Next(300);
                int x = random.Next(300);
                int y = random.Next(300);
                ellipse.Width = radius;
                ellipse.Height = radius;
                ellipse.Fill = brushes[random.Next(brushes.Count)];
                ellipse.Tag = tags[random.Next(3)];
                circlesCanvas.Children.Add(ellipse);
                ellipse.MouseDown += MouseDown;
                Canvas.SetTop(ellipse, y);
                Canvas.SetLeft(ellipse, x);
        }
    }
}