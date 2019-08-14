
using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Console.WriteLine("Select radius:");
            circle.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Perimeter = {circle.Perimeter(circle.Radius)},Lenght={circle.Lenght(circle.Radius)}");

        }
    }
}
