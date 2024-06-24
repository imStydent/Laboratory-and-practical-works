namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Apartment apartment1 = new();
            apartment1.Print();

            Apartment apartment2 = new("Улица Абрамова 5", 4, 21.7);
            apartment2.house = House.BlockOfFlats;
            apartment2.Print();

            Apartment apartment3 = new(" ", -1, -2);
            apartment3.Print();
            Console.WriteLine();

            Apartment[] apartments = { new("Улица Пушкина 12", 3, 26.4), new("Улица Калатушкина 3", 5, 13), new("Улица Гидролизная 12", 34, 290) };
            apartments[2].house = House.BlockOfFlats;

            for (int i = 0; i < apartments.Length; i++)
            {
                if (apartments[i].house == House.PrivateHouse)
                    apartments[i].Print();
            }
            Console.WriteLine();

            Abonent abonent1 = new("Алексей Леха Леший", 89600043011, 1.2);
            Abonent abonent2 = new("Зубенко Михаил Петрович", 89004545456, 234.5);
            Abonent abonent3 = new("Зубенко Михаил Петрович", 89004545456, 234.5);
            Console.WriteLine(abonent1);
            Console.WriteLine(abonent2);
            Console.WriteLine(abonent3);

            Console.WriteLine(abonent2.Equals(abonent3));
            Console.WriteLine(abonent2.Equals(abonent1));
        }
    }
}