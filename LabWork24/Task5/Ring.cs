using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Ring : Figure
    {
        private double _outerRadius;
        private double _innerRadius;

        public override double GetSquare()
        {
            return Math.PI * (_outerRadius - _innerRadius) * (_outerRadius + _innerRadius);
        }
    }
}
