int[] array = { 7, 0, -4, 3, 1, -2, 5 };

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} \t");

Console.WriteLine();
Console.WriteLine();

for (int i = array.Length - 1; i > 0; i--)
{
    for (int j = array.Length - 1; j > 0; j--)
    {
        if (array[j] < array[j - 1])
        {
            (array[j], array[j - 1]) = (array[j - 1], array[j]);
        }
    }

    for (int j = 0; j < array.Length; j++)
        Console.Write($"{array[j]} \t");

    Console.WriteLine();
    Console.WriteLine();
}
