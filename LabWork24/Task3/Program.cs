namespace Task3
{
    internal class Program
    {
        private static int GetDaysCount(int month, int year)
        {
            if (month > 12 || month < 1)
                throw new ArgumentException("Некорректный номер месяца");

            if (month == 2 && (year % 400 == 0 || year % 100 != 0 && year % 4 == 0))
                return 29;

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return daysInMonth[month - 1];
        }

        static void Main()
        {
            Console.WriteLine("Введите номер месяца");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество дней в {monthNumber} месяце - {GetDaysCount(monthNumber, year)}");
        }
    }
}
