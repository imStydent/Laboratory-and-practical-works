Console.WriteLine("Введите строку");
string text = Console.ReadLine();

string[] symbols = { "!", "?", ".", "!?", "?!" };

string[] arrayText = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < arrayText.Length; i++)
{
    arrayText[i] = arrayText[i].Trim();
    Console.WriteLine(arrayText[i]);
}
