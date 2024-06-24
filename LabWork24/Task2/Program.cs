namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();
            Console.WriteLine("Введите подтверждение пароля");
            string passwordConfirmation = Console.ReadLine();

            User user = new();

            if (user.IsCorrectUserData(login, password, passwordConfirmation))
                Console.WriteLine("Регистрация прошла успешно");
            else
                Console.WriteLine("Не удалось зарегистрироваться");
        }
    }
}
