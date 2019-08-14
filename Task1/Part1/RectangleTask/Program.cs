using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleTask1
{
    public class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();
            double[] arr = new double[4] { 0, 0, 0, 0 };

            for (int i = 0; i < 4; i++)
            {
                if (i < 2)
                {
                    Console.Write($"Select { i + 1 } coordinates of first point:");
                }
                if (i > 1)
                {
                    Console.Write($"Select { i + 1 - 2 } coordinate of second point:");
                }
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }

            if (arr[0] != arr[2] && arr[1] != arr[3])
            {
                Console.WriteLine($"Perimeter={rectangle.Perimeter(arr)},Sqaure={rectangle.Square(arr)}");
            }
            else
            {
                Console.WriteLine("Error!! Point`s don`t correct.");
            }
        }
    }
}
