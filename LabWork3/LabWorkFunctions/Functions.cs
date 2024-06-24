namespace LabWorkFunctions
{
    public static class Functions
    {
        public static ulong GetFactorial(int n)
        {
            if (n < 0)
                return 0;
            return n > 0 ? (ulong)n * GetFactorial(n - 1) : 1;
        }

        public static double GetPower(double x, int n)
        {
            if (n == 0) 
                return 1;
            if (n < 0)
                return 1/GetPower(x, -n);
            return x * GetPower(x, n - 1);
        }

        public static double GetFastPower(double x, int n)
        {
            if(n < 0) 
                return -1;
            if (n == 0) 
                return 1;
            if (n % 2 == 0)
            {
                double temp = GetFastPower(x, n / 2);
                return temp * temp;
            }
            return x * GetFastPower(x, n - 1);
        }
    }
}
