using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape to calculate area:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Triangle");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter length: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter width: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of Rectangle: {new ShapeArealib.Rectangle().Area(length, width)}");
                    break;

                case 2:
                    Console.Write("Enter side: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of Square: {new ShapeArealib.Square().Area(side)}");
                    break;

                case 3:
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of Circle: {new ShapeArealib.Circle().Area(radius)}");
                    break;

                case 4:
                    Console.Write("Enter base length: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of Triangle: {new ShapeArealib.Triangle().Area(baseLength, height)}");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
