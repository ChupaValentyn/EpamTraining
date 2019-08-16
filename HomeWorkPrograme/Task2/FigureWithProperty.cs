using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    public abstract class FigureWithProperty
    {
        protected readonly double X;
        protected readonly double Y;

        protected FigureWithProperty(double z, double q)
        {

             X = z;
             Y = q;
        }

    
        public abstract void Draw();
    }
}
