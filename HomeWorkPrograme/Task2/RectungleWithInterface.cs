using System;
using System.Collections.Generic;
using System.Text;

namespace Part4
{
    class RectungleWithInterface : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("This is Rectungle");
        }
    }
}
