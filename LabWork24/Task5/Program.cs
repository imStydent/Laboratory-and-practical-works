namespace Task5
{
    internal class Program
    {
        public static double GetSquare(string figureName)
        {
            if (figureName.ToLower() == "прямоугольник")
            {
                Console.WriteLine("Введите высоту и ширину прямоугольника");
                double height = Convert.ToDouble(Console.ReadLine());
                double width = Convert.ToDouble(Console.ReadLine());
                return height * width;
            }
            if (figureName.ToLower() == "круг")
            {
                Console.WriteLine("Введите радиус круга");
                double radius = Convert.ToDouble(Console.ReadLine());
                return Math.PI * radius * radius;
            }

            Console.WriteLine("Введите внешний и внутренний радиусы кольца");
            double outerRadius = Convert.ToDouble(Console.ReadLine());
            double innerRaduis = Convert.ToDouble(Console.ReadLine());
            return Math.PI * (outerRadius - innerRaduis) * (outerRadius + innerRaduis);
        }

        static void Main()
        {
            Console.WriteLine("Введите название фигуры (прямоугольник, круг, кольцо)");
            string figureName = Console.ReadLine();
            Console.WriteLine($"Площадь фигуры - {GetSquare(figureName)}");
        }
    }
}
