using System;
					
public class Program
	{
		abstract class Animal 
		{
			public abstract void Speak(); // abstract method 
			public void Eat() 
			{          // regular method
				Console.WriteLine("Animal is eating"); 
			}
		 }
		class Dog : Animal { 
			public override void Speak() { 
				Console.WriteLine("Dog barks"); 
			} 
		}
	
	public static void Main()
	{
		Dog d = new Dog(); d.Speak(); // Output: Dog barks d.Eat(); // Output: Animal is eating
	}
}

//samples

abstract class Animal
{
    // Abstract method
    public abstract void MakeSound();

    // Normal method
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();

        dog.MakeSound();
        dog.Sleep();
    }
}


//abstract class with properties
abstract class Animal
{
    // Abstract method
    public abstract void MakeSound();

    // Normal method
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();

        dog.MakeSound();
        dog.Sleep();
    }
}

abstract class Employee
{
    public string Name { get; set; }

    public abstract double CalculateSalary();
}

class FullTimeEmployee : Employee
{
    public double MonthlySalary { get; set; }

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }
}

class PartTimeEmployee : Employee
{
    public double HoursWorked { get; set; }
    public double HourlyRate { get; set; }

    public override double CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }
}
class Program
{
    static void Main()
    {
        FullTimeEmployee employee1 = new FullTimeEmployee
        {
            Name = "John",
            MonthlySalary = 300000
        };

        PartTimeEmployee employee2 = new PartTimeEmployee
        {
            Name = "Mary",
            HoursWorked = 80,
            HourlyRate = 3000
        };

        Console.WriteLine(employee1.Name + ": " + employee1.CalculateSalary());
        Console.WriteLine(employee2.Name + ": " + employee2.CalculateSalary());
    }
}


abstract class Shape
{
    public abstract double CalculateArea();

    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
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
class Program
{
    static void Main()
    {
        Shape circle = new Circle { Radius = 5 };
        Shape rectangle = new Rectangle
        {
            Width = 10,
            Height = 5
        };

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(rectangle.CalculateArea());
    }
}
abstract class Vehicle
{
    public string Brand;

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public abstract void Start();
}



class Car : Vehicle
{
    public Car(string brand) : base(brand)
    {
    }

    public override void Start()
    {
        Console.WriteLine($"{Brand} car is starting.");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota");

        car.Start();
    }
}
using System;

abstract class Shape
{
    public abstract void Draw();

    public void Describe()
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

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle();
        Shape rectangle = new Rectangle();

        circle.Describe();
        circle.Draw();

        rectangle.Describe();
        rectangle.Draw();
    }
}

