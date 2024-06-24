using System.Windows;
using System.Windows.Controls;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> users = new()
            {
                new() { Id = 1, Login = "admin", Password = "12345"},
                new() { Id = 2, Login = "Artem", Password = "IAmTheStormThatIsApproaching"},
                new() { Id = 3, Login = "user", Password = "dsd2m2d8"},
                new() { Id = 4, Login = "ispp21", Password = "ispp21"},
                new() { Id = 5, Login = "guest", Password = "11111"}
            };

            userComboBox.ItemsSource = users;
            userListBox.ItemsSource = users;
            userListView.ItemsSource = users;
        }

        private void UserComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)userComboBox.SelectedItem;
            comboBoxLabel.Content = $"{user.Id} {user.Login} {user.Password}";
        }

        private void UserListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string users = "";
            foreach (User user in userListBox.SelectedItems)
            {
                users += $"{user.Login}\n";
            }
            listBoxLabel.Content = users;
        }

        private void UserListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string users = "";
            foreach (User user in userListView.SelectedItems)
            {
                users += $"{user.Login}\n";
            }
            listViewLabel.Content = users;
        }
    }
}