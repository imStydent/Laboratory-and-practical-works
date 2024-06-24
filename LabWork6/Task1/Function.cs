namespace Task1
{
    internal class Function
    {
        public static double GetFunction(double x, int n)
        {
            double function = 1;
            if (n < 0)
                return -1;
            if (n == 0)
                return 1;
            else
            {
                while (n > 0)
                {
                    function = 1 / (function * x);
                    n--;
                }
                return function;
            }
        }
    }
}
