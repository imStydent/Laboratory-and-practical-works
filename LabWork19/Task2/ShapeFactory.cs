namespace Task2
{
    public class ShapeFactory
    {
        internal IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.ToUpper().Equals("CIRCLE"))
            {
                return new Circle();
            }
            if (shapeType.ToUpper().Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            if (shapeType.ToUpper().Equals("SQUARE"))
            {
                return new Square();
            }
            if (shapeType.ToUpper().Equals("TRIANGLE"))
            {
                return new Triangle();
            }

            return null;
        }
    }
}
