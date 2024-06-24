using System.Text.RegularExpressions;

Console.WriteLine("Введите E-mail адрес (например: xxx@gmail.com)");
string input = Console.ReadLine();

Regex regex = new(@"\w+@[a-z0-9-]*i", RegexOptions.IgnoreCase);

if (regex.IsMatch(input))
    Console.WriteLine("E-mail введён верно");
else
    Console.WriteLine("Введён некорректный E-mail");