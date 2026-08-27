using System;
					
public class Program
{
	class Person 
	{ 
		public string Name; 
		public Person(string name) 
				{
				Name = name; 
				Console.WriteLine("Person constructor called"); 
			} 
	} 
	class Student : Person 
		{ 
			public int StudentID; 
			public Student(string name, int id) : base(name) 
				{
					StudentID = id; 
					Console.WriteLine("Student constructor called"); 
				} 
	}
	public static void Main()
	{
		Student s = new Student("Alice", 101);
		
	}
}
using System;

class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
        Console.WriteLine("Employee constructor called");
    }
}

class Manager : Employee
{
    public string Department;

    public Manager(string name, string department)
        : base(name)
    {
        Department = department;
        Console.WriteLine("Manager constructor called");
    }
}

class Director : Manager
{
    public int NumberOfTeams;

    public Director(string name, string department, int numberOfTeams)
        : base(name, department)
    {
        NumberOfTeams = numberOfTeams;
        Console.WriteLine("Director constructor called");
    }
}

class Program
{
    static void Main()
    {
        Director director = new Director(
            "John Okoro",
            "Information Technology",
            5
        );

        Console.WriteLine("\nDirector: " + director.Name);
        Console.WriteLine("Department: " + director.Department);
        Console.WriteLine("Teams: " + director.NumberOfTeams);
    }
}
using System;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
        Console.WriteLine("Person constructor called");
    }
}

class Employee : Person
{
    public int EmployeeID;

    public Employee(string name, int employeeID)
        : base(name)
    {
        EmployeeID = employeeID;
        Console.WriteLine("Employee constructor called");
    }
}

class Manager : Employee
{
    public string Department;

    public Manager(string name, int employeeID, string department)
        : base(name, employeeID)
    {
        Department = department;
        Console.WriteLine("Manager constructor called");
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager(
            "Mary Johnson",
            1001,
            "Finance"
        );
    }
}


using System;

class Vehicle
{
    public string Brand;

    public Vehicle(string brand)
    {
        Brand = brand;
        Console.WriteLine("Vehicle constructor called");
    }
}

class Car : Vehicle
{
    public string Model;

    public Car(string brand, string model)
        : base(brand)
    {
        Model = model;
        Console.WriteLine("Car constructor called");
    }
}

class ElectricCar : Car
{
    public int BatteryCapacity;

    public ElectricCar(
        string brand,
        string model,
        int batteryCapacity)
        : base(brand, model)
    {
        BatteryCapacity = batteryCapacity;
        Console.WriteLine("ElectricCar constructor called");
    }
}

class Program
{
    static void Main()
    {
        ElectricCar car = new ElectricCar(
            "Tesla",
            "Model 3",
            75
        );
    }
}

using System;

class Animal
{
    public string Name;

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine("Animal constructor called");
    }
}

class Mammal : Animal
{
    public bool HasFur;

    public Mammal(string name, bool hasFur)
        : base(name)
    {
        HasFur = hasFur;
        Console.WriteLine("Mammal constructor called");
    }
}

class Dog : Mammal
{
    public string Breed;

    public Dog(string name, bool hasFur, string breed)
        : base(name, hasFur)
    {
        Breed = breed;
        Console.WriteLine("Dog constructor called");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog(
            "Buddy",
            true,
            "German Shepherd"
        );
    }
}


using System;

class BankAccount
{
    public string AccountNumber;

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
        Console.WriteLine("BankAccount constructor called");
    }
}

class SavingsAccount : BankAccount
{
    public double InterestRate;

    public SavingsAccount(
        string accountNumber,
        double interestRate)
        : base(accountNumber)
    {
        InterestRate = interestRate;
        Console.WriteLine("SavingsAccount constructor called");
    }
}

class PremiumSavingsAccount : SavingsAccount
{
    public double BonusRate;

    public PremiumSavingsAccount(
        string accountNumber,
        double interestRate,
        double bonusRate)
        : base(accountNumber, interestRate)
    {
        BonusRate = bonusRate;
        Console.WriteLine("PremiumSavingsAccount constructor called");
    }
}

class Program
{
    static void Main()
    {
        PremiumSavingsAccount account =
            new PremiumSavingsAccount(
                "ACC10025",
                5.5,
                2.0
            );
    }
}