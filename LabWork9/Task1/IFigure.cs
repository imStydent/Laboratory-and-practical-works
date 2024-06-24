namespace Task1
{
    internal interface IFigure
    {
        public double Square(double side);
        public double Perimeter(double side);
        public void FullPrint();
        public string FigureName { get => "Фигура"; }
    }
}
