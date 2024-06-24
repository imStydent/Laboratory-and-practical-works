Console.WriteLine("Введите имя файла");
string fileName = Console.ReadLine();

if (File.Exists(fileName))
    Console.WriteLine("Файл открыт на дозапись");
else
    Console.WriteLine($"Файл {fileName} создан и открыт на запись");

Console.WriteLine("Введите строку на запись (end для завершения записи)");
while (true)
{
    string userString = Console.ReadLine();
    if (userString == "end")
        break;
    File.AppendAllText(fileName, userString);
}