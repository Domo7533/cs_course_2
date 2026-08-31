using System;

interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Speak();
    }
}
using System;

interface IVehicle
{
    void Start();
    void Stop();
    void Drive();
}

class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }

    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();

        car.Start();
        car.Drive();
        car.Stop();
    }
}

using System;

interface IStudent
{
    string Name { get; set; }
    int Age { get; set; }

    void DisplayInfo();
}

class Student : IStudent
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "John";
        student.Age = 20;

        student.DisplayInfo();
    }
}

using System;

interface IPayment
{
    void Pay(double amount);
}

class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₦{amount} using Credit Card.");
    }
}

class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₦{amount} using Cash.");
    }
}

class BankTransferPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₦{amount} using Bank Transfer.");
    }
}

class Program
{
    static void Main()
    {
        IPayment payment;

        payment = new CreditCardPayment();
        payment.Pay(50000);

        payment = new CashPayment();
        payment.Pay(20000);

        payment = new BankTransferPayment();
        payment.Pay(100000);
    }
}
using System;

interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

class Program
{
    static void Main()
    {
        IShape shape;

        shape = new Circle();
        shape.Draw();

        shape = new Rectangle();
        shape.Draw();
    }
}