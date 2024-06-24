using System.Text;

Console.WriteLine("Введите строку");
string text = Console.ReadLine();
while (text.Contains("  "))
{
    text = text.Replace("  ", " ");
}

Console.WriteLine($"Отформатированная строка - {text.Trim()}");
Console.WriteLine("Введите требуемый регистр (1 - нижний, 2 - верхний, 3 - инвертированный)");
int registerNumber = Convert.ToInt32(Console.ReadLine());

switch (registerNumber)
{
    case 1:
        text = text.ToLower();
        break;
    case 2:
        text = text.ToUpper();
        break;
    case 3:
        StringBuilder sb = new();
        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsLower(text[i]))
                sb.Append(Char.ToUpper(text[i]));
            else
                sb.Append(Char.ToLower(text[i]));
        }
        text = sb.ToString();
        break;
}
Console.WriteLine(text);