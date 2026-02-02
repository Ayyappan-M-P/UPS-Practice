namespace Project
{
    public class Circle
    {
        public double Radius{ get; set; }
        public Circle(double radius)
        {
            this.Radius=radius;
        }
    }
    public class Rectangle
    {
        public double Length{ get; set; }
        public double Width{ get; set; }
        public Rectangle(double length, double width)
        {
            this.Length=length;
            this.Width=width;
        }
    }
    public class Triangle
    {
        public double Base{ get; set; }
        public double Height{ get; set; }
        public Triangle(double b, double height)
        {
            this.Base=b;
            this.Height=height;
        }
    }

    public static class ShapeExtensions
    {
        public static double GetArea(this Circle c)
        {
            return Math.PI*c.Radius*c.Radius;
        }
        public static double GetArea(this Rectangle r)
        {
            return r.Length*r.Width;
        }
        public static double GetArea(this Triangle t)
        {
            return 0.5*t.Base*t.Height;
        }
    }
    class Extensionmethod
    {
        public static void Run(string[] args)
        {
            Circle c=new Circle(5);
            Rectangle r=new Rectangle(4,6);
            Triangle t=new Triangle(3,4);
            Console.WriteLine("Area of Circle: "+c.GetArea());
            Console.WriteLine("Area of Rectangle: "+r.GetArea());
            Console.WriteLine("Area of Triangle: "+t.GetArea());
        }
    }
}