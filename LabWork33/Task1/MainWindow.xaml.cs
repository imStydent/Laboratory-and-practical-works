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

            List<Game> games = new List<Game>
            { 
                new Game { GameId = 1, Name = "Fallout 4", Site = "", Category = "Шутер", Price = 1099},
                new Game { GameId = 2, Name = "Dota 2", Site = "", Category = "MOBA", Price = 0},
                new Game { GameId = 3, Name = "Helldivers 2", Site = "", Category = "Шутер", Price = 5157.43 },
                new Game { GameId = 4, Name = "Elden Ring", Site = "", Category = "RPG", Price = 3599 },
                new Game { GameId = 5, Name = "Minecraft", Site = "", Category = "Песочница", Price = 1599 }
            };

            gamesListView.ItemsSource = games;
        }
    }
}