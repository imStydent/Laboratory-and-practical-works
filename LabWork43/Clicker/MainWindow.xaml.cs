using System.Windows;
using System.Windows.Threading;
namespace Clicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Render);
        int cookie = 0;
        int grandmother = 0;
        int price = 15;

        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
            GrandmotherRectangle.IsEnabled = false;
            GrandmotherRectangle.Opacity = 0.5;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            GetEnable();
        }

        private void CookieEllipse_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            GetEnable();
        }

        private void GrandmotherRectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cookie = cookie - price;
            pechenieCount.Content = cookie;

            GetEnable();

            grandmother++;
            GrandmotherCount.Content = grandmother;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / (grandmother + 1));
            timer.Start();
        }

        private void GetEnable()
        {
            cookie++;
            pechenieCount.Content = cookie;
            GrandmotherRectangle.IsEnabled = (cookie >= price);
            GrandmotherRectangle.Opacity = (cookie >= price) ? 1 : 0.5;
        }
    }
}