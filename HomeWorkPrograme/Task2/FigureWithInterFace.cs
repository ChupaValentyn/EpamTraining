using System;
using System.Collections.Generic;
using System.Text;

namespace Part4
{
    class FigureWithInterFace : IDrawable
    {
        void IDrawable.Draw()
        {
            Console.WriteLine("This is class Figure ");
        }
       
    }
}
