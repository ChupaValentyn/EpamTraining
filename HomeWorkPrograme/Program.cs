using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program disp = new Program();
            disp.DisplayTask2();
            disp.DisplayTask1();
        }

        public void DisplayTask2()
        {
            Console.WriteLine("----------------------------Part1--------------------------------");
            Part1.Rectangle r = new Part1.Rectangle();
            r.Draw();

            Part1.Square s = new Part1.Square();
            s.Draw();

            Console.WriteLine("----------------------------Part2--------------------------------");
            Part2.RectangleWithProperty Rec = new Part2.RectangleWithProperty(1,1);
            Rec.Draw();

            Part2.Square sq = new Part2.Square(0,0);
            sq.Draw();

            Console.WriteLine("----------------------------Part3--------------------------------");
            Part3.RectangleVirtual recv = new Part3.RectangleVirtual();
            recv.Draw();

            Part3.SquareVirual sqv = new Part3.SquareVirual();

            sqv.Draw();

            Console.WriteLine("----------------------------Part4--------------------------------");

        }

        void DisplayTask1()
        {
            Console.WriteLine("Rectangle");
            RectangleTask1.Rectangle t = new RectangleTask1.Rectangle();
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
                Console.WriteLine($"Perimeter={t.Perimeter(arr)},Sqaure={t.Square(arr)}");
            }
            else
            {
                Console.WriteLine("Error!! Point`s don`t correct.");
            }
            Console.WriteLine("-------------Auto-Implemented properties----------------------------");

            Console.WriteLine("--------------------Circle-----------------------------");
            Circle.Circle y = new Circle.Circle();

            Console.WriteLine("Select radius:");
            y.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Perimeter = {y.Perimeter(y.Radius)},Lenght={y.Lenght(y.Radius)}");

            Console.WriteLine("-----------------------------Static----------------------");
            Console.WriteLine("-----------------------------StaticCirle----------------------");

            Console.WriteLine("Select radius:");
            StaticCircle.StaticCircle.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Perimete={StaticCircle.StaticCircle.Perimeter(StaticCircle.StaticCircle.Radius)},Lenght={StaticCircle.StaticCircle.Lenght(StaticCircle.StaticCircle.Radius)}");

            Console.WriteLine("-----------------------------StaticRectangle----------------------");

            double[] array = new double[4] { 0, 0, 0, 0 };

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
                Console.WriteLine($"Perimeter={StaticRectangle.StaticRectangle.Perimeter(arr)},Sqaure={StaticRectangle.StaticRectangle.Square(arr)}");
            }
            else
            {
                Console.WriteLine("Error!! Point`s don`t correct.");
            }

            Console.WriteLine("-----------------------------Complex Number--------------------------------");
            ComplexNumber.ComplexNumbers NumbOne = new ComplexNumber.ComplexNumbers(0, 0);

            Console.Write("Enter real part on first number:");
            NumbOne.Real = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter imaginary part on first number:");
            NumbOne.Imaginary = Convert.ToInt32(Console.ReadLine());

            ComplexNumber.ComplexNumbers NumbTwo = new ComplexNumber.ComplexNumbers(0, 0);

            Console.Write("Enter real part on second number:");
            NumbTwo.Real = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter imaginary part on second number:");
            NumbTwo.Imaginary = Convert.ToInt32(Console.ReadLine());

            ComplexNumber.ComplexNumbers result = new ComplexNumber.ComplexNumbers(0, 0);


            result = NumbOne * NumbTwo;
            Console.Write("Result opration *:");
            result.GetInfo(result);

            result = NumbOne / NumbTwo;
            Console.Write("Result opration /:");
            result.GetInfo(result);
        }
    }
}
