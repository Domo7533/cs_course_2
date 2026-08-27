// shape based samples method-overriding
using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

class Program
{
    static void Main()
    {
        Shape shape = new Shape();

        shape.Draw();
    }
}


using System;

// Base class
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a generic shape.");
    }
}

// Derived class: Circle
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

// Derived class: Rectangle
class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Polymorphism: Shape references point to different derived objects
        Shape shape1 = new Circle();
        Shape shape2 = new Rectangle();

        Console.WriteLine("Using Shape references:");

        shape1.Draw();   // Calls Circle's Draw()
        shape2.Draw();   // Calls Rectangle's Draw()
    }
}

