using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class BlueShapeDecorator : ShapeDecorator
    {
        internal BlueShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

        public override void Draw()
        {
            SetBlueBorder(decoratedShape);
            decoratedShape.Draw();
        }
        private void SetBlueBorder(IShape decoratedShape)
        {
            Console.WriteLine("Цвет границы: синий");
        }
    }
}
