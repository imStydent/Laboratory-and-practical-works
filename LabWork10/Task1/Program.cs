using System.Collections;
using System.Collections.Concurrent;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Apartment[] apartments1 = { new Apartment("Улица Тимме 21", 5, 21.2), new Apartment("Улица Галушина 5", 4, 31.7),
                new Apartment("Улица Папанина 24", 3, 14.5) };

            Console.WriteLine("Неотсортированный массив");
            for (int i = 0; i < apartments1.Length; i++)
            {
                apartments1[i].Print();
            }

            Array.Sort(apartments1);
            Console.WriteLine("\nОтсортированный по возрастанию площади");

            for (int i = 0; i < apartments1.Length; i++)
            {
                apartments1[i].Print();
            }

            Array.Sort(apartments1);
            Console.WriteLine("\nОтсортированный по возврастанию площади");

            for (int i = 0; i < apartments1.Length; i++)
            {
                apartments1[i].Print();
            }
            Console.WriteLine();

            Apartment apartment1 = new Apartment("Улица Абрамова 5", 7, 21.4);

            Apartment apartment2 = new Apartment("Улица Абрамова 5", 89, 21.4);

            Console.WriteLine($"Сравнение объектов: {apartment1.Equals(apartment2)}\n");

            Console.Write("Оригинальный объект - ");
            apartment1.Print();

            Console.Write("Клонированный объект - ");
            Apartment apartment3 = (Apartment)apartment1.Clone();
            apartment3.Print();

            Console.WriteLine("\nНеотсортированный массив");

            Apartment[] apartments2 = { new Apartment("Улица Тимме 25", 15, 18.6), new Apartment("Улица Табуляции 12", 90, 14.4),
                new Apartment("Улица Варавино 46", 3, 16.3) };

            for (int i = 0; i < apartments2.Length; i++)
            {
                apartments2[i].Print();
            }
            Console.WriteLine("\nОтсортированный по убыванию количества комнат");

            Array.Sort(apartments2, new DescendingComparer());

            for (int i = 0; i < apartments2.Length; i++)
            {
                apartments2[i].Print();
            }
            Console.WriteLine("\nОтсортированный по возрастанию символов в адресе");

            Array.Sort(apartments2, new StringComparer());

            for (int i = 0; i < apartments2.Length; i++)
            {
                apartments2[i].Print();
            }
        }
    }
}
