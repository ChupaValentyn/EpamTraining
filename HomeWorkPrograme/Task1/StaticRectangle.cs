using System;
using System.Collections.Generic;
using System.Text;

namespace StaticRectangle
{
    static class  StaticRectangle
    {
        public static double Square(double[] array)
        {
            double square = 0;
            double[] site;

            site = SearchSite(array);

            square = site[0] * site[1];

            if (square < 0)
            {
                square *= -1;
            }

            return square;
        }

        public static double Perimeter(double[] array)
        {
            double perimeter = 0;
            double[] site;

            site = SearchSite(array);

            if (site[0] < 0)
            {
                site[0] *= -1;
            }

            if (site[1] < 0)
            {
                site[1] *= -1;
            }

            perimeter = (site[0] + site[1]) * 2;

            return perimeter;
        }

        private static double[] SearchSite(double[] array)
        {
            double[] site = new double[2];

            site[0] = array[0] - array[2];
            site[1] = array[1] - array[3];

            return site;
        }
    }
}