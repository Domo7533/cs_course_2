using System;

// Base class
class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }

    // Virtual method
    public virtual void Work()
    {
        Console.WriteLine(Name + " is working.");
    }
}

// Derived class
class Manager : Employee
{
    public Manager(string name)
        : base(name)
    {
    }

    // Override Work()
    public override void Work()
    {
        Console.WriteLine(Name + " is managing the team.");
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism
        Employee employee = new Manager("John");

        employee.Work();
    }
}