using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumber
{
    public class ComplexNumbers
    {
        #region properties
        private double real;
        public double Real
        {
            get { return this.real; }
            set { this.real = value; }
        }
        private double imaginary;
        public double Imaginary
        {
            get { return this.imaginary; }
            set { this.imaginary = value; }
        }
        public ComplexNumbers(double imaginary, double real)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        #endregion

        #region overload*
        public static ComplexNumbers operator *(ComplexNumbers c1, ComplexNumbers c2)
        {
            return new ComplexNumbers(c1.imaginary * c2.imaginary, c1.real * c2.real);
        }
        #endregion

        #region overload /
        public static ComplexNumbers operator /(ComplexNumbers c1, ComplexNumbers c2)
        {
            return new ComplexNumbers(c1.imaginary / c2.imaginary, c1.real / c2.real);
        }
        #endregion

        #region display
        public void GetInfo(ComplexNumbers r)
        {
            Console.WriteLine($"real={real}");

            Console.WriteLine($"imaginary={imaginary}");

        }
        #endregion
    }
}