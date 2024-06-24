using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Circle : Figure
    {
        private double _radius;

        public override double GetSquare()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
