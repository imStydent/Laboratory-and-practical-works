using System.Text.RegularExpressions;

Console.WriteLine("Введите строку");
string input = Console.ReadLine();

Regex regex = new(@"\s{2,}");
input = regex.Replace(input, " ");

Console.WriteLine($"Изменённая строка - {input}");