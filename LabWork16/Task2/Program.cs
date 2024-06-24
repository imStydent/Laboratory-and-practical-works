using Task2;

User user = new() { Login = "login@gmail.com", Password = "12345" };

user.PropertyChanged += User_PropertyChanged;

user.Login = "sdsadasds";
user.Password = "54321";
user.Login = "sdsadasds";
user.Password = "54321";
user.Login = "           ";
user.Password = "     ";

void User_PropertyChanged(object? sender, EventArgs e)
{
    User user = (User)sender;
    Console.WriteLine($"Изменены данные пользователя со следующим логином: {user.Login}");
}

