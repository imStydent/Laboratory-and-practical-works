using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Square
    {
        public static double GetSquare(double length) => length * length;

        public static double GetSquare(double height, double width) => height * width;
    }
}
