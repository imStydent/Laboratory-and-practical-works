Console.WriteLine("Введите имя файла");
string fileName = Console.ReadLine();

if (File.Exists(fileName))
    Console.WriteLine($"Содержимое файла {fileName}: \n{File.ReadAllText(fileName)}");
else
    Console.WriteLine($"Файла {fileName} не существует");