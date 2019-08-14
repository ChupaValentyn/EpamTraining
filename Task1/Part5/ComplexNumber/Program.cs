using System;

namespace ComplexNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumbers NumbOne = new ComplexNumbers(0,0);

            Console.Write("Enter real part on first number:");
            NumbOne.Real = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter imaginary part on first number:");
            NumbOne.Imaginary = Convert.ToInt32(Console.ReadLine());

            ComplexNumbers NumbTwo = new ComplexNumbers(0, 0);

            Console.Write("Enter real part on second number:");
            NumbTwo.Real = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter imaginary part on second number:");
            NumbTwo.Imaginary = Convert.ToInt32(Console.ReadLine());

            ComplexNumbers rezult = new ComplexNumbers(0, 0);

            rezult = NumbOne * NumbTwo;
            rezult.GetInfo(rezult);

            rezult = NumbOne / NumbTwo;
            rezult.GetInfo(rezult);
        }
    }
}
