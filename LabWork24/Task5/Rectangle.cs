using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Rectangle : Figure
    {
        private double _height;
        private double _width;

        public override double GetSquare()
        {
            return _width * _height;
        }
    }
}
