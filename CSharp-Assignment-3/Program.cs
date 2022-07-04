using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_3
{
    abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
    class Circle : Shape
    {
        // pi instantiation
        static double PI = 3.1415;
        // get and set on var radius 
        public double radius { get; set; }
        // override the abstract methods
        public override double CalculateArea()
        {
            return (radius*radius)*PI;
        }
        public override double CalculatePerimeter()
        {
            return 2*(PI*radius);
        }
    }
    class Rectangle : Shape
    {
        
        // get and set on var length and width
        public double length { get; set; }
        public double Width { get; set; }
        // override the abstract methods
        public override double CalculateArea()
        {
            return (length * Width);
        }
        public override double CalculatePerimeter()
        {
            return 2 * (length + Width);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Rectangle r = new Rectangle();
            Console.WriteLine("enter the radius ");
            c.radius = double.Parse(Console.ReadLine());

            Console.WriteLine("area of the circle is " + c.CalculateArea());
            Console.WriteLine("Circumfrence of the circle is  " + c.CalculatePerimeter());



            Console.WriteLine("enter the Length ");
            r.length = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the Width ");
            r.Width = double.Parse(Console.ReadLine());

            Console.WriteLine("area of the Rectangle is " + r.CalculateArea());
            Console.WriteLine("Perimeter of the Rectangle is " + r.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
