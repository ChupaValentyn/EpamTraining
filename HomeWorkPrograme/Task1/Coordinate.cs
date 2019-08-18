using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_Implemented_properties
{
    class Coordinate
    {
        private double x;
        public double X
        {
            get {
                return this.x; }
            set { this.x = value; }
        }
        private double y;
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public Coordinate(double x , double y)
        {
            this.x = x;
            this.y = y;
        }
        public static Coordinate operator -(Coordinate c1, Coordinate c2)
        {
            return new Coordinate(c1.x - c2.x, c1.y - c2.y);
        }
        public static Coordinate operator +(Coordinate c1, Coordinate c2)
        {
            return new Coordinate(c1.x + c2.x, c1.y + c2.y);
        }



    }
}
    

