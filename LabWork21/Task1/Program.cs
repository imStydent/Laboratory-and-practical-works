// Task 1
int Sum(int a, int b) => a + b;

// Task 2
int r1 = 2, r2 = 2;
double square = Math.PI * (r1 - r2) * (r1 + r2);

int n = 100, sum;
sum = n * (1 + n) / 2;

// Task 3
int bytes = 1073741824;
string GetSize(int bytes)
{
    return bytes >= 1 << 30 ? $"{bytes >> 30} ГБ" : 
        bytes >= 1 << 20 ? $"{bytes >> 20} МБ" : 
        bytes >= 1 << 10 ? $"{bytes >> 10} КБ" :
        $"{bytes} Б";
}
Console.WriteLine(GetSize(bytes));

// Task 4
int GetDaysCount(int month, int year)
{
    if (month > 12 || month < 1)
        return -1;

    if (month == 2 && (year % 400 == 0 || year % 100 != 0 && year % 4 == 0))
        return 29;

    int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    return daysInMonth[month - 1];
}

// Task 5
double GetPower(double x, int n)
{
    if (n == 0)
        return 1;
    if (x > 0)
    {
        double temp = GetPower(x, n / 2);
        temp *= temp;
        return n % 2 == 0 ? temp : x * temp;
    }
    return -1;
}
Console.WriteLine(GetPower(2, 15));