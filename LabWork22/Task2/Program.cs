using System.Security.Cryptography;

namespace Task2
{
    internal class Program
    {
        static double GetPower(double a, int x)
        {
            double result = 1;
            if (x > 0)
                for (int i = 0; i < x; i++)
                    result *= a;
            if (x < 0)
            {
                for (int i = 0; i > x; i--)
                    result *= a;
                return 1 / result;
            }
            return result;
        }

        static async Task DoOperationAsync(double a1, double a2, double a3, double a4, 
            int x1, int x2, int x3, int x4)
        {
            Console.WriteLine($"({a1} ^ {x1} + {a2} ^ {x2}) / ({a3} ^ {x3} - {a4} ^ {x4}) " +
                $"= { (GetPower(a1, x1) + GetPower(a2, x2)) / (GetPower(a3, x3) - GetPower(a4, x4))}");
        }

        static async Task Main()
        {
            await DoOperationAsync(3, 4, 6, 2, -1, 2, 0, 2);
            Console.WriteLine();

            var results = await Task.WhenAll(
                Task.Run(() => GetPower(7, 3)),
                Task.Run(() => GetPower(2, -1)),
                Task.Run(() => GetPower(2, 0)));
            foreach (var result in results)
                Console.WriteLine(result);
        }
    }
}
