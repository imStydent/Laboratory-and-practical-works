using System.Text.RegularExpressions;

string input;
Regex regex = new(@"(?=^.{6,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$");

Console.WriteLine("Введите пароль (в пароле должна содержаться: " +
    "цифра, строчная и прописная буква и знак препинания). Длина пароля - не меньше 6 символов");
do
{
    input = Console.ReadLine();
}
while (!regex.IsMatch(input));
if (regex.IsMatch(input))
    Console.WriteLine("well done");
else Console.WriteLine("Введен некоректный пароль");