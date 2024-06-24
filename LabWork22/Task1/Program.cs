namespace Task1
{
    internal class Program
    {
        static void ShowPower(double a, int x)
        {
            double result = 1;
            if (x > 0)
                for (int i = 0; i < x; i++)
                    result *= a;
            if (x < 0) 
            {
                for (int i = 0; i > x; i--)
                    result *= a;
                result = 1 / result;
            }
            Console.WriteLine($"{a} ^ {x} = {result}");
        }

        static async Task Main()
        {
            await Task.Run(() => ShowPower(5, 2));
            await Task.Run(() => ShowPower(4, -1));
            await Task.Run(() => ShowPower(2, 0));
            Console.WriteLine();

            await Task.WhenAll(Task.Run(() => ShowPower(5, 2)), 
                Task.Run(() => ShowPower(4, -1)), 
                Task.Run(() => ShowPower(2, 0)));
            Console.WriteLine();
        }
    }
}
