using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Square:FigureWithProperty
    {
        public Square(double x, double y)
            : base(z: x, q: y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("This is class Square");
        }
    }
}
