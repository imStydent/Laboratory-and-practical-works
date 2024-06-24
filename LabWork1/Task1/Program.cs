int[] array = { 7, 0, -4, 3, 1, -2, 5 };
int min, temp;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}\t");
}
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < array.Length - 1; i++)
{
    min = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[min])
            min = j;
    }
    if (min != i)
    {
        temp = array[min];
        array[min] = array[i];
        array[i] = temp;
    }

    for (int k = 0; k < array.Length; k++)
    {
        Console.Write($"{array[k]}\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}

