int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}   ");
}
Console.WriteLine();

int position = -1;
int left = 0;
int right = array.Length;
int middle;

Console.Write("Введите искомый элемент ");
int value = Convert.ToInt32(Console.ReadLine());

do
{
    middle = (right + left) / 2;
    Console.WriteLine($"{left}   {middle}   {right}");
    Console.ReadLine();
    if (value == array[middle])
    {
        position = middle + 1;
        break;
    }
    if (value > array[middle])
    {
        left = middle;
    }
    else
    {
        right = middle;
    }
} while (right > left);
Console.Write($"Позиция искомого элемента - {position}");


