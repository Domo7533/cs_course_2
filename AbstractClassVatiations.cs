1. Basic Abstract Class — Shape → Draw()
abstract class Shape
{
    public abstract void Draw();
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

Usage:

Shape circle = new Circle();
Shape rectangle = new Rectangle();

circle.Draw();
rectangle.Draw();

Output:

Drawing a circle.
Drawing a rectangle.
2. Abstract Class with Common Method

The abstract class can provide some functionality while leaving other functionality to derived classes.

abstract class Shape
{
    public abstract void Draw();

    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square.");
    }
}

Usage:

Shape shape = new Circle();

shape.Display();
shape.Draw();
3. Abstract Class with Properties
abstract class Shape
{
    public string Color { get; set; }

    public abstract void Draw();
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a {Color} circle.");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a {Color} rectangle.");
    }
}

Usage:

Circle circle = new Circle
{
    Color = "Red"
};

circle.Draw();

Output:

Drawing a Red circle.
4. Abstract Class with CalculateArea()

This is useful for demonstrating polymorphism.

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

Usage:

Shape circle = new Circle { Radius = 5 };
Shape rectangle = new Rectangle
{
    Width = 10,
    Height = 5
};

Console.WriteLine(circle.CalculateArea());
Console.WriteLine(rectangle.CalculateArea());
5. Multiple Abstract Methods

An abstract class can require derived classes to implement several methods.

abstract class Shape
{
    public abstract void Draw();

    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();
}

A derived class must implement all three:

class Square : Shape
{
    public double Side { get; set; }

    public override void Draw()
    {
        Console.WriteLine("Drawing a square.");
    }

    public override double CalculateArea()
    {
        return Side * Side;
    }

    public override double CalculatePerimeter()
    {
        return 4 * Side;
    }
}
6. Abstract Class with Constructor

An abstract class can have a constructor that initializes shared properties.

abstract class Shape
{
    public string Name { get; }

    protected Shape(string name)
    {
        Name = name;
    }

    public abstract void Draw();
}

class Circle : Shape
{
    public Circle() : base("Circle")
    {
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a {Name}.");
    }
}

Usage:

Circle circle = new Circle();

circle.Draw();
7. Different Shapes Using Polymorphism

This is a good example to place in a README because it demonstrates why abstract classes are useful.

abstract class Shape
{
    public abstract void Draw();
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Triangle");
    }
}

Then all shapes can be handled through the same Shape type:

Shape[] shapes =
{
    new Circle(),
    new Rectangle(),
    new Triangle()
};

foreach (Shape shape in shapes)
{
    shape.Draw();
}

Output:

Drawing Circle
Drawing Rectangle
Drawing Triangle
8. Real-World Variation — Payment

Abstract classes aren't limited to shapes.

abstract class Payment
{
    public abstract void ProcessPayment();
}

class CreditCardPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment.");
    }
}

class BankTransferPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing bank transfer.");
    }
}

class CashPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing cash payment.");
    }
}

Usage:

Payment[] payments =
{
    new CreditCardPayment(),
    new BankTransferPayment(),
    new CashPayment()
};

foreach (Payment payment in payments)
{
    payment.ProcessPayment();
}
Summary

The general pattern is:

abstract class BaseClass
{
    public abstract void SomeMethod();
}

class DerivedClass : BaseClass
{
    public override void SomeMethod()
    {
        // Implementation
    }
}