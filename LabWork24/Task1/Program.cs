namespace Task1
{
    internal class Program
    {
        private string _login;
        private string _password;

        public static bool IsCorrectUserData(string login, string password, string passwordConfirmation)
        {
            bool isLoginCorrect = !string.IsNullOrWhiteSpace(login);
            bool isPasswordCorrect = !string.IsNullOrWhiteSpace(password);
            bool isConfirmCorrect = password == passwordConfirmation;

            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }
        
        static void Main()
        {
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();
            Console.WriteLine("Введите подтверждение пароля");
            string passwordConfirmation = Console.ReadLine();

            if (IsCorrectUserData(login, password, passwordConfirmation))
                Console.WriteLine("Регистрация прошла успешно");
            else
                Console.WriteLine("Не удалось зарегистрироваться");
        }
    }
}
