﻿using Task3;

IShape circle = new Circle();

IShape redCircle = new RedShapeDecorator(new Circle());

IShape redRectangle = new RedShapeDecorator(new Rectangle());
Console.WriteLine("Circle with normal border");
circle.Draw();

IShape blueCircle = new BlueShapeDecorator(new Circle());
Console.WriteLine("\nCircle of blue border");
blueCircle.Draw();

Console.WriteLine("\nCircle of red border");
redCircle.Draw();

Console.WriteLine("\nRectangle of red border");
redRectangle.Draw();