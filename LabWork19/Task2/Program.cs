using Task2;

ShapeFactory shapeFactory = new();

IShape shape = shapeFactory.GetShape("CIRCLE");
shape.Draw();

shape = shapeFactory.GetShape("RECTANGLE");
shape.Draw();

shape = shapeFactory.GetShape("sQUARE");
shape.Draw();

shape = shapeFactory.GetShape("TRIANGLE");
shape.Draw();