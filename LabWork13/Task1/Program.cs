using System.Text;

Console.WriteLine("Введите строку");
string text = Console.ReadLine();
int lettersCount = 0;

Console.WriteLine($"Количество символов в пользовательской строке- {text.Length}");

Console.WriteLine($"Количество символов без пробелов - {text.Replace(" ", "").Length}");

for (int i = 0; i < text.Length; i++)
{
    if (char.IsLetter(text[i]))
        lettersCount++;
}
Console.WriteLine($"Количество букв в строке - {lettersCount}");

Console.Write("Введите искомый символ: ");
char userSymbol = Convert.ToChar(Console.ReadLine());
if (text.Contains(userSymbol))
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == userSymbol)
            Console.WriteLine($"Позиция указанного символа {userSymbol} - {i + 1}");
    }
}
else
    Console.WriteLine("Указанного символа нет в текущей строке");
Console.WriteLine();