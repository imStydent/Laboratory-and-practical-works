namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Apartment apartment1 = new("Улица Абрамова 5", 2, 21.4);
            Console.WriteLine("Корректные данные");
            apartment1.Print();

            Apartment apartment2 = new("           ", -1, -23);
            Console.WriteLine("Некорректные данные");
            apartment2.Print();

            Apartment apartment3 = new();
            apartment3.Print();

            Apartment[] apartments = { new("Улица Абрамова 5", 2, 21.4), new("Улица Буденого 16", 3, 60), new("Улица Логиново 23", 2, 30)};
            Console.WriteLine();

            var value1 = "Улица Логиново 23";
            for (int i = 0; i < apartments.Length; i++)
            {
                if (apartments[i].Address == value1)
                {
                    Console.WriteLine($"{apartments[i].Address}, количесво комнат - {apartments[i].RoomsCount}, площадь квартиры - {apartments[i].Square}");
                }
            }

            Console.WriteLine();

            var value2 = 25.4;
            for (int i = 0; i < apartments.Length; i++)
            {
                if (apartments[i].Square > value2)
                {
                    Console.WriteLine($"{apartments[i].Address}, количесво комнат - {apartments[i].RoomsCount}, площадь квартиры - {apartments[i].Square}");
                }
            }
        }
        
    }
}

