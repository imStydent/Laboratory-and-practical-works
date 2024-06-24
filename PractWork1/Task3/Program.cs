Console.WriteLine("Введите имя файла");
string fileName = Console.ReadLine();
Console.WriteLine("Введите текст для поиска");
string textSearch = Console.ReadLine();

if (File.Exists(fileName))
{
    var lines = File.ReadAllLines(fileName);
    int count = 1;
    foreach (string line in lines)
    {
        if (line.Contains(textSearch))
            Console.WriteLine($"Текст {line} содержится в строке номер {count}");
        count++;
    }
}
else
    Console.WriteLine($"Файл {fileName} не существует");


