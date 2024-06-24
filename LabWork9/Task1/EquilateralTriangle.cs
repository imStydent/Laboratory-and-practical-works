namespace Task1
{
    internal class EquilateralTriangle : IPrinter, IFigure
    {
        public EquilateralTriangle() : this(7.4) { }

        public EquilateralTriangle(double side)
        {
            Side = side;
        }

        public double Side { get; set; }
        public string FigureName { get => "Равносторонний треугольник"; }

        public void FullPrint()
        {
            Console.WriteLine($"Площадь - {Math.Round(Square(7.1), 2)}, периметр - {Math.Round(Perimeter(7.1), 2)}\n");
        }

        public double Perimeter(double side)
        {
            return 3 * side;
        }

        public void Print()
        {
            Console.WriteLine($"Сторона: {Side}");
        }

        public double Square(double side)
        {
            return side * side * Math.Sqrt(3) / 4;
        }
    }
}
