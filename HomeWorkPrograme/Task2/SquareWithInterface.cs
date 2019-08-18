using System;
using System.Collections.Generic;
using System.Text;

namespace Part4
{
    class SquareWithInterface : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("This is Draw in Square");
        }
       
    }
}
