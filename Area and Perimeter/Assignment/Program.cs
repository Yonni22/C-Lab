using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @base
{
    abstract class Base
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
    class Circle : Base
    {

        static readonly double PI = 3.1415;
        public double rad { get; set; }
        public override double CalculateArea()
        {
            return Math.Pow(rad, 2) * PI;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (PI * rad);

        }
    }
    class Rectangle : Base
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public override double CalculateArea()
        {
            return Width * Length;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Length);

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Circle c = new Circle();
                Rectangle r = new Rectangle();
                Console.WriteLine("Wnter the radius ");
                c.rad = double.Parse(Console.ReadLine());
                Console.WriteLine("Area of the circle is " + c.CalculateArea());
                Console.WriteLine("Circumfrence of the circle is  " + c.CalculatePerimeter());
                Console.WriteLine("enter the Length ");
                r.Length = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the Width ");
                r.Width = double.Parse(Console.ReadLine());
                Console.WriteLine("Area of the Rectangle is " + r.CalculateArea());
                Console.WriteLine("Perimeter of the Rectangle is " + r.CalculatePerimeter());
                Console.ReadKey();
            }
        }
    }
}