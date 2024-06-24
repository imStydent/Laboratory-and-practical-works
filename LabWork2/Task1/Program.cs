int[] array = { -2, -7, 0, 4, 10, 6, -5, 2, 13, -4 };
int position = -1;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}   ");
}
Console.WriteLine();

Console.Write("Введите значение искомого числа ");
int value = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == value)
    {
        position = i + 1;
        break;
    }
}
Console.Write($"Позиция искомого элемента - {position}");