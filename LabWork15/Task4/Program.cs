namespace Task4
{
    internal class Program
    {
        public delegate int Function(int x);

        public static int GetFactorial(int x) => x < 0 ? -1 : x <= 1 ? 1 : x * GetFactorial(x - 1);

        public static int GetSquare(int x) => x * x;

        public static int GetModule(int x) => x < 0 ? -x : x;

        public static void Method(int x, Function func)
        {
            Console.WriteLine(func(x));
        }
        static void Main()
        {
            Function[] functions = { GetFactorial, GetSquare, GetModule };

            for (int i = 0; i < functions.Length; i++)
            {
                Console.WriteLine(functions[i](5));
            }
            Console.WriteLine();

            for (int i = 0;i < functions.Length;i++)
            {
                Function function = functions[i];
                Method(6, function);
            }
        }
    }
}
