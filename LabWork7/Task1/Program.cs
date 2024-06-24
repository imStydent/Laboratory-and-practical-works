namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Apartment apartment1 = new() { Address = "Улица Абрамова 5", RoomsCount = 7, Square = 13 };
            apartment1.Print();

            Apartment apartment2 = new() { Address = "Улица Абрамова 5", RoomsCount = 7, Square = 21.4 };

            Apartment apartment3 = apartment1 + apartment2;
            apartment3.Print();

            Console.WriteLine(apartment1 == apartment2);

            Console.WriteLine(apartment1 != apartment2);

            apartment1++;
            apartment1.Print();

            if (apartment1)
                Console.WriteLine("Площадь больше или равна нуля ");
            else
                Console.WriteLine("Площадь меньше нуля");
        }
    }
}
