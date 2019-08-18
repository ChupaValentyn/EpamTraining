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

        public double Square
        {
            get
            {
                Coordinate square = new Coordinate(0,0);
                double ret=0;
                square = (firstp - secondp);
                ret = square.X * square.Y;
                if (ret < 0)
                {
                    ret *= -1;  
                }

                return ret;
            }
        }

        public double Perimeter
        {
            get
            {
                Coordinate Perim = new Coordinate(0, 0);
                double ret = 0;
                Perim = (firstp - secondp);
                ret = (Perim.X  + Perim.Y)*2;
                if (ret < 0)
                {
                    ret *= -1;
                }

                return ret;
            }

        }
    }
}
