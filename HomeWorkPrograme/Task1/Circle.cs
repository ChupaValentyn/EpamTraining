namespace Circle
{
    class Circle
    {
        private double pi=3.14159265359;

        private  double radius;
        public  double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public  double Lenght(double radius)
        {
            return 2 * pi * radius;
        }

        public  double Perimeter(double radius)
        {
            return radius * pi * pi;
        }
    }
}
