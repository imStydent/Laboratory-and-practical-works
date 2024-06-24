Console.WriteLine("Введите путь к папке");
string path = Console.ReadLine();
Console.WriteLine("Введите часть имени файла");
string searchPattern = Console.ReadLine() + "*";

DirectoryInfo directory = new(path);
var files = directory.GetFiles(searchPattern, SearchOption.AllDirectories);
foreach (var file in files)
    Console.WriteLine($"Имя файла: {file}, размер: {file.Length} байт");