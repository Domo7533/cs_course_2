//Example 1: Public Property, Private Field

// A bank account should not allow direct modification of its balance.

using System;

class BankAccount
{
    // Private field (hidden from outside)
    private decimal balance;

    // Public constructor
    public BankAccount(decimal initialDeposit)
    {
        balance = initialDeposit;
    }

    // Public method
    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    // Public method
    public void DisplayBalance()
    {
        Console.WriteLine($"Balance: ₦{balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(10000);

        account.Deposit(5000);
        account.DisplayBalance();

        // ERROR
        // account.balance = 100000;
    }
}

//Example 2: Student Class
using System;

class Student
{
    private double gpa;

    public string Name { get; set; }

    public void SetGPA(double value)
    {
        if (value >= 0 && value <= 5)
            gpa = value;
    }

    public void DisplayStudent()
    {
        Console.WriteLine($"{Name} - GPA: {gpa}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "John";

        student.SetGPA(4.5);

        student.DisplayStudent();

        // student.gpa = 10; // Not allowed
    }
}

//Example 3: Password Security
using System;

class User
{
    private string password;

    public string Username { get; set; }

    public void SetPassword(string pwd)
    {
        if (pwd.Length >= 8)
            password = pwd;
    }

    public bool Login(string pwd)
    {
        return password == pwd;
    }
}

class Program
{
    static void Main()
    {
        User user = new User();

        user.Username = "Alice";

        user.SetPassword("mypassword");

        Console.WriteLine(user.Login("mypassword"));

        // Console.WriteLine(user.password);
    }
}
//Example 4: Car Speed
using System;

class Car
{
    private int speed;

    public void Accelerate()
    {
        speed += 10;
    }

    public void DisplaySpeed()
    {
        Console.WriteLine($"Speed: {speed} km/h");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();

        car.Accelerate();
        car.Accelerate();

        car.DisplaySpeed();

        // car.speed = 300; // Not allowed
    }
}

//Example 6: Public vs Private Methods
using System;

class Calculator
{
    public int Square(int number)
    {
        return Multiply(number, number);
    }

    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine(calc.Square(5));

        // calc.Multiply(2,3); // Not allowed
    }
}