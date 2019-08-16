using System;
using System.Collections.Generic;
using System.Text;

namespace StaticCircle
{
    static class StaticCircle
    {
        private static double pi = 3.14159265359;

        private static double radius;
        public static double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public static double Lenght(double radius)
        {
            return 2 * pi * radius;
        }

        public static double Perimeter(double radius)
        {
            return radius * pi * pi;
        }
    }
}
