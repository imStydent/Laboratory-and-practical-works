int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Введите искомое число: ");
int x = Convert.ToInt32(Console.ReadLine());

int jumpStep = (int)Math.Sqrt(integers.Length);
int prev = 0;

for (int minStep = Math.Min(jumpStep, integers.Length) - 1; integers[minStep] < x; minStep = Math.Min(jumpStep, integers.Length) - 1)
{
    prev = jumpStep;
    jumpStep += (int)Math.Sqrt(integers.Length);
    if (prev >= integers.Length)
        break;  
}

while (integers[prev] < x)
{
    prev++;
    if (prev == Math.Min(jumpStep, integers.Length))
        break;
}

if (integers[prev] == x)
    Console.WriteLine("Число найдено");