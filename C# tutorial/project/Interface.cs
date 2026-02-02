using System;

namespace Project
{
    interface IShape
    {
        double Area();
    }

    class ICircle : IShape
    {
        public double Radius { get; set; }

        public ICircle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class IRectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public IRectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }
    }

    class Interface
    {
        public static void Run(string[] args)
        {
            IShape circle = new ICircle(5);
            Console.WriteLine($"Circle area: {circle.Area()}");

            IShape rectangle = new IRectangle(4, 6);
            Console.WriteLine($"Rectangle area: {rectangle.Area()}");
        }
    }
}