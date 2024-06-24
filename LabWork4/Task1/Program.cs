int rows, columns, xStart, yStart;

Console.WriteLine("Введите количество строк и столбцов");
rows = Convert.ToInt32(Console.ReadLine());
columns = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Введите начальные координаты: ");
    xStart = Convert.ToInt32(Console.ReadLine()) - 1;
    yStart = Convert.ToInt32(Console.ReadLine()) - 1;
} while (xStart >= rows || yStart >= columns);
Console.WriteLine();

int[,] map = new int[rows, columns];

Random random = new Random();

for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        map[i, j] = -1;
        map[random.Next(i, rows), random.Next(j, columns)] = -2;
        map[xStart, yStart] = 0;
    }
}
map[random.Next(rows), random.Next(columns)] = 99;

for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        Console.Write($"{map[i, j]}\t");
    }
    Console.WriteLine();
}

//Эвристика
int xGoal = 0, yGoal = 0;
double temp;
Console.WriteLine();
for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        if (map[i, j] == 99)
        {
            xGoal = i;
            yGoal = j;
        }
    }
}

for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    { 
        temp = Math.Abs(i - xGoal) + Math.Abs(j - yGoal);
        Console.WriteLine($"Эвристика из точки {map[i,j]} равна {temp}");
    }
}




