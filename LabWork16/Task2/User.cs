namespace Task2
{
    internal class User
    {
        private string login;
        private string password;

        public string Login
        {
            get => login;
            set
            {
                if (login != value && !string.IsNullOrWhiteSpace(value))
                {
                    login = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (password != value && !string.IsNullOrWhiteSpace(value))
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }

        public event EventHandler? PropertyChanged;

        private void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
