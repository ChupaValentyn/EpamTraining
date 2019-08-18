using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_Implemented_properties
{
    class Rectangle
    {
        private Coordinate firstp;
        public Coordinate FirstP
        {
            get { return this.firstp; }
            set { this.firstp = value; }
        }
        private Coordinate secondp;
        public Coordinate SecondP
        {
            get { return this.secondp; }
            set { this.secondp = value; }
        }
        public Rectangle(Coordinate firstp, Coordinate secondp)
        {
            this.firstp = firstp;
            this.secondp = secondp;
        }

        public double Square(Rectangle rec)
        {
            double square = 0;
            Coordinate rez = new Coordinate(0, 0);

            rez = this.SearchSite(rec);

            square = rez.X * rez.Y;

            if (square < 0)
            {
                square *= -1;
            }

            return square;
        }

        public double Perimeter(Rectangle rectangle)
        {
            double perimeter = 0;
            Coordinate rez = new Coordinate(0, 0);
            rez = this.SearchSite(rectangle);
            
            if (rez.Y < 0)
            {
                rez.Y *= -1;
            }

            if (rez.X < 0)
            {
               rez.X *= -1;
            }

            perimeter = (rez.X + rez.Y) * 2;

            return perimeter;
        }

        private Coordinate SearchSite(Rectangle rec)
        {
            Coordinate site = new Coordinate(0, 0);

            site = rec.firstp - rec.secondp;

            return site;
        }
    }
}
