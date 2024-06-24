namespace Task3
{
    internal class RedShapeDecorator : ShapeDecorator
    {
        internal RedShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

        public override void Draw()
        {
            SetRedBorder(decoratedShape);
            decoratedShape.Draw();
        }
        private void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Цвет границы: красный");
        }
    }
}
