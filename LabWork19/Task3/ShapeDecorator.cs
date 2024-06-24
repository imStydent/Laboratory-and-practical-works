namespace Task3
{
    public abstract class ShapeDecorator : IShape
    {
        internal IShape decoratedShape;

        internal ShapeDecorator(IShape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            decoratedShape.Draw();
        }
    }
}
