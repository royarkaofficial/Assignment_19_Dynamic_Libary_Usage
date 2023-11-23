using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArealib
{
    // Rectangle.cs
    public class Rectangle
    {
        public double Area(double length, double width)
        {
            return length * width;
        }
    }

    // Square.cs
    public class Square
    {
        public double Area(double side)
        {
            return side * side;
        }
    }

    // Circle.cs
    public class Circle
    {
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
    }

    // Triangle.cs
    public class Triangle
    {
        public double Area(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
    }

}
