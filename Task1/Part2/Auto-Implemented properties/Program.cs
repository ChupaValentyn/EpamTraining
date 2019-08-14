using System;

namespace Auto_Implemented_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;

            Console.Write("Chose x of first point:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Chose y of first point:");
            y = Convert.ToDouble(Console.ReadLine());

            Coordinate firstpoint = new Coordinate(x,y);

            Console.Write("Chose x of second point:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Chose y of second point:");
            y = Convert.ToDouble(Console.ReadLine());

            Coordinate secondpoint =new Coordinate(x, y);

            Rectangle rec = new Rectangle(firstpoint, secondpoint);

            Console.WriteLine($" Sqiare={rec.Square(rec)},Perimeter={rec.Perimeter(rec)}");
        }
    }
}
