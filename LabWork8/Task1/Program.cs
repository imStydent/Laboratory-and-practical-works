namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExtendedRandom random = new ExtendedRandom();
            Console.WriteLine(random.GetString(10, 20));

            Apartment apartment1 = new("Улица Галушина 5", 5, 21.4);
            Apartment apartment2 = new("Улица Галушина 5", 5, 21.4);

            apartment1.ToString();
            Console.WriteLine(apartment1);

            Console.WriteLine(apartment2.Equals(apartment1));

            Rectangle rectangle = new() { Width = 10, Height = 5 };

            rectangle.Print();
            Console.WriteLine($"Периметр: {rectangle.GetPerimeter()}.");
            Console.WriteLine($"Площадь: {rectangle.GetSquare()}.");
        }
    }
}
