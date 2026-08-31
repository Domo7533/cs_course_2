using System;

interface IShape
{
    void Draw();
    double CalculateArea();
    double CalculatePerimeter();
}

class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }

    public double CalculateArea()
    {
        return Length * Width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism using IShape reference
        IShape shape = new Circle(5);

        shape.Draw();
        Console.WriteLine($"Circle Area: {shape.CalculateArea():F2}");
        Console.WriteLine($"Circle Perimeter: {shape.CalculatePerimeter():F2}");

        Console.WriteLine();

        shape = new Rectangle(10, 5);

        shape.Draw();
        Console.WriteLine($"Rectangle Area: {shape.CalculateArea():F2}");
        Console.WriteLine($"Rectangle Perimeter: {shape.CalculatePerimeter():F2}");
    }
}
//output
Drawing a Circle.
Circle Area: 78.54
Circle Perimeter: 31.42

Drawing a Rectangle.
Rectangle Area: 50.00
Rectangle Perimeter: 30.00