namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Apartment apartment1 = new("Улица Абрамова 5", 2, 21.4);
            apartment1.Print();
            Console.WriteLine(apartment1["Количество комнат"]);
            Console.WriteLine($"Символ по индексу - {apartment1[3]}");

            Apartment apartment2 = new();
            apartment2.Print();

            Console.WriteLine($"Площадь квадрата - {Square.GetSquare(4)}");
            Console.WriteLine($"Площадь квадрата - {Square.GetSquare(7, 8)}");

            Console.WriteLine($"Значение функции - {Function.GetFunction(2.5, 2)}");
        }
    }
}
