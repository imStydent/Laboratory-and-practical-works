namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EquilateralTriangle equilateralTriangle1 = new();
            Console.WriteLine(equilateralTriangle1.FigureName);
            equilateralTriangle1.Print();
            equilateralTriangle1.FullPrint();

            Apartment apartment = new("Улица Галушина 5", 1, 5);
            apartment.Print();
            Console.WriteLine();

            IPrinter printer1 = new Apartment();
            printer1.Print();
            Console.WriteLine();

            IPrinter printer2 = new EquilateralTriangle();
            printer2.Print();
            Console.WriteLine();

            IPrinter[] printers = { new Apartment("Улица Папина 24", 1, 5) ,new Apartment("Улица Абрамова 5", 2, 52),
                new EquilateralTriangle(5), new EquilateralTriangle(15)};

            for (int i = 0; i < printers.Length; i++)
            {
                printers[i].Print();
                if (printers[i] is EquilateralTriangle equilateralTriangle2)
                {
                    Console.WriteLine(equilateralTriangle2.FigureName);
                }
            }
        }
    }
}
