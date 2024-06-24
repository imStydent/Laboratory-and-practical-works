namespace Task1
{
    internal class Rectangle : Figure
    {
        public double Height;
        public double Width;

        public override string FigureName { get => "прямоугольник"; }

        public override double GetPerimeter() => 2 * (Height + Width);

        public override double GetSquare() => Height * Width;

        public override void Print()
        {
            Console.WriteLine($"Высота фигуры: {Height}, ширина фигуры: {Width}, название фигуры: {FigureName}."); ;
        }
    }
}
