using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Program disp = new Program();

            disp.DisplayTask1();

            disp.DisplayTask2();

        }

        public void DisplayTask2()
        {
            Console.WriteLine("----------------------------Part1--------------------------------");
            Part1.Rectangle rectangle = new Part1.Rectangle();
            rectangle.Draw();

            Part1.Square square = new Part1.Square();
            square.Draw();

            Console.WriteLine("----------------------------Part2--------------------------------");
            Part2.RectangleWithProperty recwithpro = new Part2.RectangleWithProperty(1,1);
            recwithpro.Draw();

            Part2.Square sqwithpro = new Part2.Square(0,0);
            sqwithpro.Draw();

            Console.WriteLine("----------------------------Part3--------------------------------");
            Part3.RectangleVirtual recvirtual = new Part3.RectangleVirtual();
            recvirtual.Draw();

            Part3.SquareVirual sqvirtual = new Part3.SquareVirual();

            sqvirtual.Draw();

            Console.WriteLine("----------------------------Part4--------------------------------");
            Part4.RectungleWithInterface recI = new Part4.RectungleWithInterface();

            Part4.FigureWithInterFace fiI = new Part4.FigureWithInterFace();

            Part4.SquareWithInterface sqI = new Part4.SquareWithInterface();

            Program.DrawAll(recI, fiI, sqI) ;
        }

        public static void DrawAll(params Part4.IDrawable[] array)
        {
            foreach (var item in array)
            {

              item.Draw();

            }
        }

        void DisplayTask1()
        {
            Console.WriteLine("--------------------------Rectangle------------------------------");

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
