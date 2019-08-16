using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class RectangleWithProperty : FigureWithProperty
    {
        public RectangleWithProperty(double x , double y)
            :base(z:x,q:y)
        {
           
        }
        public override  void Draw()
        {
            Console.WriteLine("This is class Rectangle");
        }
    }
}
