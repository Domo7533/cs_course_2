//inheritance variations for vehicle class
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle is starting.");
    }
}

class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class ElectricCar : Car
{
    public void ChargeBattery()
    {
        Console.WriteLine("Electric car is charging.");
    }
}

class Program
{
    static void Main()
    {
        ElectricCar car = new ElectricCar();

        car.Start();          // From Vehicle
        car.Drive();          // From Car
        car.ChargeBattery();  // From ElectricCar
    }
}

///Animal → Mammal → Dog

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Mammal : Animal
{
    public void Breathe()
    {
        Console.WriteLine("Mammal is breathing.");
    }
}

class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

///Animal
   ↓
Mammal
   ↓
 Dog
3. Person → Employee → Manager
///
class Person
{
    public string Name { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"My name is {Name}.");
    }
}

class Employee : Person
{
    public int EmployeeId { get; set; }

    public void Work()
    {
        Console.WriteLine("Employee is working.");
    }
}

class Manager : Employee
{
    public void ManageTeam()
    {
        Console.WriteLine("Manager is managing the team.");
    }
}

///Person
  ↓
Employee
  ↓
Manager
4. Shape → Rectangle → Square
///

class Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }
}

class Square : Rectangle
{
    public void SetSide(double side)
    {
        Width = side;
        Height = side;
    }
}

////
Shape
  ↓
Rectangle
  ↓
Square
5. Account → SavingsAccount → PremiumSavingsAccount
/////

class Account
{
    public decimal Balance { get; protected set; }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
}

class SavingsAccount : Account
{
    public decimal InterestRate { get; set; }

    public void AddInterest()
    {
        Balance += Balance * InterestRate / 100;
    }
}

class PremiumSavingsAccount : SavingsAccount
{
    public void ApplyBonus()
    {
        Balance += 1000;
    }
}

//***Account
   ↓
SavingsAccount
   ↓
PremiumSavingsAccount
Device → Computer → Laptop
**//

class Device
{
    public void TurnOn()
    {
        Console.WriteLine("Device turned on.");
    }
}

class Computer : Device
{
    public void RunProgram()
    {
        Console.WriteLine("Computer is running a program.");
    }
}

class Laptop : Computer
{
    public void FoldScreen()
    {
        Console.WriteLine("Laptop screen folded.");
    }
}

// Device
  ↓
 //Computer
  ↓
Laptop
// Employee → Developer → SeniorDeveloper


class Employee
{
    public string Name { get; set; }

    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}

class Developer : Employee
{
    public void WriteCode()
    {
        Console.WriteLine($"{Name} is writing code.");
    }
}

class SeniorDeveloper : Developer
{
    public void ReviewCode()
    {
        Console.WriteLine($"{Name} is reviewing code.");
    }
}
//Employee
   ↓
Developer
   ↓
//SeniorDeveloper
// Multilevel + Hierarchical Inheritance

/***You can also combine inheritance structures.

             Vehicle
            /       \
         Car       Truck
          |
      ElectricCar
***///

class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started.");
    }
}

class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car driving.");
    }
}

class ElectricCar : Car
{
    public void Charge()
    {
        Console.WriteLine("Charging battery.");
    }
}

class Truck : Vehicle
{
    public void LoadCargo()
    {
        Console.WriteLine("Loading cargo.");
    }
}
