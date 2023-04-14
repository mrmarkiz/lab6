using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Task4
    {
        public static void Run()
        {
            List<Figure> figures = new List<Figure> { new Rectangle(5, 6), new Circle(4), new RectangularTriangle(6, 8), new Trapeze(5, 4) };
            foreach(Figure f in figures)
            {
                Console.WriteLine($"Figures area: {f.Area()}");
            }
        }
    }

    abstract class Figure
    {
        public abstract double Area();
    }

    class Rectangle : Figure
    {
        public double side_a { get; set; }
        public double side_b { get; set; }

        public Rectangle()
        {
            this.side_a = 2;
            this.side_b = 3;
        }

        public Rectangle(double side_a, double side_b)
        {
            this.side_a = side_a;
            this.side_b = side_b;
        }

        public override double Area()
        {
            return side_a * side_b;
        }
    }

    class Circle : Figure
    {
        public double radius { get; set; }

        public Circle()
        {
            this.radius = 5;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return radius * radius * Math.PI;
        }
    }

    class RectangularTriangle : Figure
    {
        public double katet_a { get; set; }
        public double katet_b { get; set; }

        public RectangularTriangle()
        {
            this.katet_a = 3;
            this.katet_b = 4;
        }

        public RectangularTriangle(double katet_a, double katet_b)
        {
            this.katet_a = katet_a;
            this.katet_b = katet_b;
        }

        public override double Area()
        {
            return katet_a * katet_b / 2;
        }
    }

    class Trapeze : Figure
    {
        public double side_a { get; set; }
        public double height_a { get; set; }

        public Trapeze()
        {
            this.side_a = 5;
            this.height_a = 4;
        }

        public Trapeze(double side_a, double height_a)
        {
            this.side_a = side_a;
            this.height_a = height_a;
        }

        public override double Area()
        {
            return side_a * height_a;
        }
    }
}
