List<string> rivers = new() { "Северная Двина", "Обь", "Енисей" };

Console.WriteLine("Введите количество рек, которое вы хотите добавить: ");
int amount1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите название реки");
for (int i = 0; i < amount1; i++)
    rivers.Add(Console.ReadLine());

for (int i = 0; i < rivers.Count; i++)
    Console.WriteLine($"{i + 1} - река {rivers[i]}");
Console.WriteLine();

Console.WriteLine("Введите начальное значение");
int startPosition = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите конечное значение (<{rivers.Count})");
int finishPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = startPosition; i <= finishPosition; i++)
{
    Console.WriteLine($"{i + 1} - река {rivers[i]}");
}

