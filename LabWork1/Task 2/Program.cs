int[] arr = { 7, 0, -4, 3, 1, -2, 5 };

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}\t");
}
Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{

    for (int j = 0; j < arr.Length - 1 - i; j++)
    {

        if (arr[j] > arr[j + 1])
        {
            int tmpParam = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = tmpParam;
        }
    }
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]}\t");
    }
    Console.WriteLine();
}

