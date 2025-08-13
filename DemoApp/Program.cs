using DemoApp;
using System;
using System.Drawing;
using System.Reflection;
namespace DemoApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            I2DShape circle = new Circle(5);
            I2DShape rectangle = new Rectangle { Length = 4, Breadth = 5 };
            I3DShape cube = new Cube { Side = 5 };
            CalculateArea(circle);
            IPrinter printer = new Printer();
            printer.Print(circle);
            new Printer().Print(cube);
        }
        private static void CalculateArea(I2DShape circle)
        {
            Console.WriteLine(circle.GetArea());
        }



    }
}