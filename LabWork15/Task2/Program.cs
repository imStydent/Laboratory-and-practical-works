namespace Task2
{
    internal class Program
    {
        public delegate void Mathematics(int x, int y);

        static void Main()
        {
            Mathematics mathematics = (int x, int y) => Console.WriteLine($"Сумма чисел равна {x + y}");
            mathematics += (int x, int y) => Console.WriteLine($"Разность чисел равна {x - y}");
            mathematics += (int x, int y) => Console.WriteLine($"Произведение чисел равно {x * y}");
            mathematics += (int x, int y) => Console.WriteLine($"Частное чисел равно {x / y}");
            mathematics?.Invoke(7, 4);
        }
    }
}
