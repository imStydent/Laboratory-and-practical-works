using System.Globalization;
using Task4;

Product product = new() { Name = "пиво", Price = 70.5, ExpirationDate = new DateTime(1731, 12, 23) };
Console.WriteLine(product.ToString());
