namespace LabWork15
{
    internal class Program
    {
        public delegate int Function(int x);

        public static int GetFactorial(int x) => x < 0 ? -1 : x <= 1 ? 1 : x * GetFactorial(x - 1);

        static void Main()
        {
            Function math = x => x * x;
            Console.WriteLine($"Квадрат числа равен {math?.Invoke(5)}");

            math = GetFactorial;
            Console.WriteLine($"Факториал числа равен {math?.Invoke(-3)}");

            math = x => x < 0 ? -x : x;
            Console.WriteLine($"Модуль числа равен {math?.Invoke(-7)}");
        }
    }
}
