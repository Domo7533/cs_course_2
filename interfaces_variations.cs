// Vehicle → Drive()
interface IVehicle
{
    void Drive();
}

class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Motorcycle is driving.");
    }
}

// Animal → Speak()
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

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cat says: Meow!");
    }
}


//Shape → Draw()
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

// Payment → Pay()
interface IPayment
{
    void Pay(double amount);
}

class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₦{amount} with cash.");
    }
}

class CardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₦{amount} with card.");
    }
}

// Employee → Work()
interface IEmployee
{
    void Work();
}

class Developer : IEmployee
{
    public void Work()
    {
        Console.WriteLine("Developer is writing code.");
    }
}

class Designer : IEmployee
{
    public void Work()
    {
        Console.WriteLine("Designer is creating designs.");
    }
}

// Printer → Print()
interface IPrinter
{
    void Print();
}

class LaserPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing using a laser printer.");
    }
}

class InkjetPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing using an inkjet printer.");
    }
}
// Notification → Send()
interface INotification
{
    void Send(string message);
}

class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}

class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
}

// Appliance → TurnOn()
interface IAppliance
{
    void TurnOn();
}

class Television : IAppliance
{
    public void TurnOn()
    {
        Console.WriteLine("Television is turned on.");
    }
}

class WashingMachine : IAppliance
{
    public void TurnOn()
    {
        Console.WriteLine("Washing machine is turned on.");
    }
}

// Database → Connect()
interface IDatabase
{
    void Connect();
}

class MySqlDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connected to MySQL.");
    }
}

class SqlServerDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connected to SQL Server.");
    }
}

//  Multiple Interfaces

A class can implement more than one interface.

interface IDriveable
{
    void Drive();
}

interface IServiceable
{
    void Service();
}

class Car : IDriveable, IServiceable
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }

    public void Service()
    {
        Console.WriteLine("Car is being serviced.");
    }
}