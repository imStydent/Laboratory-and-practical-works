namespace Task1
{
    internal abstract class Figure
    {
        public abstract double GetSquare();
        public abstract double GetPerimeter();
        public abstract void Print();
        public abstract string FigureName { get; }
    }
}
