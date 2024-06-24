using Task1;
using System.ComponentModel;

User user = new() { Login = "login@gmail.com", Password = "12345" };

user.PropertyChanged += User_PropertyChanged;

user.Login = "b[b[b";
user.Password = "12345";
user.Password = "12222345";
user.Login = "       ";
user.Password = "    ";

void User_PropertyChanged(object? sender, PropertyChangedEventArgs e)
{
    Console.WriteLine($"{e.PropertyName} изменён");
}
  
