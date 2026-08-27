# cs\_course\_2

my second cs\_course program

\# Object-Oriented Programming (OOP) Essentials in C#



!\[C#](https://img.shields.io/badge/Language-C%23-purple)

!\[.NET](https://img.shields.io/badge/.NET-8.0-blue)

!\[License](https://img.shields.io/badge/License-MIT-green)



\## 📖 Overview



This project introduces the \*\*fundamental concepts of Object-Oriented Programming (OOP)\*\* using \*\*C#\*\*. OOP is a programming paradigm that organizes software into reusable objects containing both \*\*data (fields/properties)\*\* and \*\*behavior (methods)\*\*.



The examples in this project are designed for beginners learning C# and demonstrate how to create, use, and organize objects effectively.



\---



\# 🎯 Learning Objectives



After completing this project, you should be able to:



\- Understand the principles of Object-Oriented Programming.

\- Create classes and objects.

\- Use constructors to initialize objects.

\- Implement encapsulation using properties.

\- Apply inheritance to reuse code.

\- Override methods using polymorphism.

\- Design reusable applications with abstraction.

\- Organize code into multiple classes.



\---



\# 📚 OOP Concepts Covered



\## 1. Classes



A class is a blueprint for creating objects.



```csharp

public class Student

{

&#x20;   public string Name { get; set; }

&#x20;   public int Age { get; set; }

}

```



\---



\## 2. Objects



An object is an instance of a class.



```csharp

Student student = new Student();



student.Name = "John";

student.Age = 20;

```



\---



\## 3. Fields



Fields store data inside a class.



```csharp

public class Student

{

&#x20;   private string schoolName = "ABC University";

}

```



\---



\## 4. Properties



Properties provide controlled access to fields.



```csharp

public string Name { get; set; }



public int Age { get; set; }

```



\---



\## 5. Constructors



Constructors initialize objects when they are created.



```csharp

public Student(string name, int age)

{

&#x20;   Name = name;

&#x20;   Age = age;

}

```



Usage:



```csharp

Student student = new Student("Mary", 22);

```



\---



\## 6. Methods



Methods define what an object can do.



```csharp

public void Display()

{

&#x20;   Console.WriteLine($"{Name} is {Age} years old.");

}

```



\---



\# 🔒 Encapsulation



Encapsulation protects data by restricting direct access.



Example:



```csharp

private int age;



public int Age

{

&#x20;   get { return age; }



&#x20;   set

&#x20;   {

&#x20;       if (value > 0)

&#x20;           age = value;

&#x20;   }

}

```



Benefits:



\- Data protection

\- Validation

\- Easier maintenance



\---



\# 👨‍👩‍👧 Inheritance



Inheritance allows one class to inherit properties and methods from another.



```csharp

public class Person

{

&#x20;   public string Name { get; set; }

}



public class Student : Person

{

&#x20;   public string Department { get; set; }

}

```



Benefits:



\- Code reuse

\- Less duplication

\- Easier maintenance



\---



\# 🔄 Polymorphism



Polymorphism allows the same method to behave differently.



```csharp

public class Animal

{

&#x20;   public virtual void Speak()

&#x20;   {

&#x20;       Console.WriteLine("Animal sound");

&#x20;   }

}



public class Dog : Animal

{

&#x20;   public override void Speak()

&#x20;   {

&#x20;       Console.WriteLine("Bark");

&#x20;   }

}

```



Usage:



```csharp

Animal animal = new Dog();



animal.Speak();

```



Output:



```

Bark

```



\---



\# 🧩 Abstraction



Abstraction hides implementation details while exposing only essential functionality.



```csharp

abstract class Shape

{

&#x20;   public abstract double Area();

}



class Circle : Shape

{

&#x20;   public double Radius { get; set; }



&#x20;   public override double Area()

&#x20;   {

&#x20;       return Math.PI \* Radius \* Radius;

&#x20;   }

}

```



\---



\# 📦 Example Project Structure



```

ObjectOrientedProgramming/



│



├── Program.cs



├── Models/



│   ├── Person.cs



│   ├── Student.cs



│   ├── Teacher.cs



│



├── Interfaces/



│   └── IPrintable.cs



│



└── README.md

```



\---



\# 💻 Example Program



```csharp

using System;



class Student

{

&#x20;   public string Name { get; set; }



&#x20;   public int Age { get; set; }



&#x20;   public Student(string name, int age)

&#x20;   {

&#x20;       Name = name;

&#x20;       Age = age;

&#x20;   }



&#x20;   public void Display()

&#x20;   {

&#x20;       Console.WriteLine($"{Name} is {Age} years old.");

&#x20;   }

}



class Program

{

&#x20;   static void Main()

&#x20;   {

&#x20;       Student student = new Student("Alice", 21);



&#x20;       student.Display();

&#x20;   }

}

```



Output



```

Alice is 21 years old.

```



\---



\# 🧠 The Four Pillars of OOP



| Principle | Description |

|-----------|-------------|

| Encapsulation | Protects data using properties and access modifiers |

| Inheritance | Reuses code by extending existing classes |

| Polymorphism | Allows methods to have multiple implementations |

| Abstraction | Hides unnecessary implementation details |



\---



\# 🎯 Real-World Examples



| Class | Object |

|--------|--------|

| Car | Toyota Camry |

| Student | Alice |

| Teacher | Mr. James |

| BankAccount | Savings Account |

| Book | "Clean Code" |

| Employee | Software Developer |



\---



\# 🏗 Sample Class Diagram



```

&#x20;             Person

&#x20;         ----------------

&#x20;         Name

&#x20;         Age

&#x20;             ▲

&#x20;     ┌───────┴────────┐

&#x20;     │                │

&#x20;  Student         Teacher

Department       Subject

```



\---



\# 📈 Advantages of OOP



\- Reusable code

\- Easier maintenance

\- Better organization

\- Improved scalability

\- Increased security

\- Simplified debugging

\- Better collaboration in teams



\---



\# ⚠ Common Beginner Mistakes



\- Forgetting to create objects before using them.

\- Confusing classes with objects.

\- Exposing fields instead of using properties.

\- Not using constructors appropriately.

\- Ignoring access modifiers (`public`, `private`, `protected`).

\- Overusing inheritance when composition is more suitable.



\---



\# 📝 Practice Exercises



1\. Create a `Car` class with properties for \*\*Brand\*\*, \*\*Model\*\*, and \*\*Year\*\*.

2\. Add a constructor to initialize the object.

3\. Create a `Person` class and derive `Student` and `Teacher` from it.

4\. Override a method using polymorphism.

5\. Create an abstract `Shape` class and implement `Rectangle` and `Circle`.

6\. Add validation to properties using encapsulation.

7\. Build a simple Library Management System using OOP principles.



\---



\# 🚀 How to Run



\### Clone the repository



```bash

git clone https://github.com/yourusername/ObjectOrientedProgramming.git

```



\### Navigate to the project



```bash

cd ObjectOrientedProgramming

```



\### Run the project



```bash

dotnet run

```



\---



\# 📚 Recommended Learning Resources



\- Microsoft Learn – C# Fundamentals

\- Microsoft Learn – Object-Oriented Programming

\- .NET Documentation

\- C# Yellow Book by Rob Miles

\- Head First Object-Oriented Analysis and Design



\---



\# 🎓 Prerequisites



\- Basic understanding of C#

\- .NET SDK installed

\- Visual Studio or Visual Studio Code

\- Command-line basics



\---



\# 🤝 Contributing



Contributions are welcome!



1\. Fork the repository.

2\. Create a new feature branch.

3\. Commit your changes.

4\. Push your branch.

5\. Open a Pull Request.



\---



\# 📄 License



This project is licensed under the MIT License.



\---



\# 👨‍💻 Author



\*\*Domo Ereku\*\*



Computer Scientist | Software Developer | Digital Skills Trainer



\*"Learning Object-Oriented Programming is the foundation for building scalable, maintainable, and professional software applications."\*

C# Access Modifiers

Overview

Access modifiers in C# control the visibility and accessibility ofclasses, fields, properties, methods, and other members.

They are an important part of Object-Oriented Programming (OOP)because they help implement encapsulation by controlling which partsof a class can be accessed from outside.

Learning Objectives

By the end of this lesson, you should be able to:

Explain what access modifiers are.

Differentiate between public and private.

Identify when to use public members.

Identify when to use private members.

Apply access modifiers in C# classes.

Understand how access modifiers support encapsulation.

Common C# Access Modifiers

C# provides several access modifiers:

Modifier                            Accessibility

public                            Accessible from anywhere

private                           Accessible only within thecontaining class/type

protected                         Accessible within the containingclass and derived classes

internal                          Accessible within the sameassembly/project

protected internal                Accessible from the same assemblyor derived classes

For beginners, the most important modifiers to understand first arepublic and private.

1. Public Access Modifier

The public modifier makes a member accessible from other classes.

Example

using System;

class Student
{
    public string Name;

    public void DisplayName()
    {
        Console.WriteLine(Name);
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "John";
        student.DisplayName();
    }
}

Output

John

The Name property and DisplayName() method are public, so they canbe accessed from Program.

When to Use public

Use public when:

Other classes need to access a member.

You want to expose functionality to users of a class.

A method represents an operation that other parts of the programshould be able to perform.

2. Private Access Modifier

The private modifier restricts access to the containing class.

Example

using System;

class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Balance: ₦{balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.Deposit(10000);
        account.DisplayBalance();

        // account.balance = 50000; // ERROR
    }
}

The balance field is private, so it cannot be accessed directly fromProgram.

Instead, the class controls access through public methods such asDeposit().

3. Public vs Private

Consider a bank account.

class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

Here:

balance is private because it should be protected.

Deposit() is public because users need to deposit money.

GetBalance() is public because users may need to check theirbalance.

This is an example of encapsulation.

4. Why Use Private Members?

Private members prevent other classes from changing data incorrectly.

Without Encapsulation

class Student
{
    public double GPA;
}

Another class could do:

student.GPA = 100;

This may produce an invalid GPA.

With Encapsulation

class Student
{
    private double gpa;

    public void SetGPA(double value)
    {
        if (value >= 0 && value <= 5)
        {
            gpa = value;
        }
    }

    public double GetGPA()
    {
        return gpa;
    }
}

Now the class controls how the GPA is changed.

Student student = new Student();

student.SetGPA(4.5);

Console.WriteLine(student.GetGPA());

5. Private Helper Methods

A method can also be private when it is only needed internally.

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

Square() is public because other classes need to use it.

Multiply() is private because it is an internal implementation detail.

6. Real-World Example: Employee

using System;

class Employee
{
    public string Name { get; set; }

    private decimal salary;

    public void SetSalary(decimal amount)
    {
        if (amount > 0)
        {
            salary = amount;
        }
    }

    public decimal GetSalary()
    {
        return salary;
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee();

        employee.Name = "Grace";
        employee.SetSalary(250000);

        Console.WriteLine(employee.Name);
        Console.WriteLine(employee.GetSalary());
    }
}

Why?

Member          Modifier    Reason

Name          public    Other classes need to access the employee's namesalary        private   Salary should be controlled internallySetSalary()   public    Allows controlled salary updatesGetSalary()   public    Allows the salary to be retrieved

7. Access Modifier Comparison

Feature                            public                      private

Accessible inside the same class   Yes                           YesAccessible from another class      Yes                           NoAccessible from derived classes    Yes                           NoProvides data hiding               No                            YesSupports encapsulation             Yes, when carefully exposed   YesCommon use                         Public interface/API          Internal implementation

8. Best Practice

A common OOP principle is:

Keep members private by default and expose only what other classesactually need.

For example, prefer:

class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }
}

Instead of:

class BankAccount
{
    public decimal balance;
}

The first approach gives the class control over its data.

9. Public Properties with Private Fields

A common C# pattern is to use a private field with a public property orcontrolled methods.

class Student
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

A shorter version uses an auto-property:

class Student
{
    public string Name { get; set; }
}

For more control, validation can be added:

class Student
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }
}

10. Access Modifiers and Encapsulation

Encapsulation means keeping an object's data and implementationdetails protected while providing controlled ways to interact with theobject.

For example:

             BankAccount
        ┌─────────────────────┐
        │ private balance     │
        │                     │
        │ public Deposit()    │
        │ public GetBalance() │
        └──────────┬──────────┘
                   │
             Controlled Access
                   │
                   ▼
             Other Classes

The outside world interacts with the object through its public interfacerather than directly modifying its internal data.

11. Practice Exercise

Create a Car class with:

A private field called speed.

A public method called Accelerate().

A public method called Brake().

A public method called DisplaySpeed().

Prevent speed from being accessed directly from Main().

Starter Code

using System;

class Car
{
    // Add your private speed field here

    // Add Accelerate() here

    // Add Brake() here

    // Add DisplaySpeed() here
}

class Program
{
    static void Main()
    {
        Car car = new Car();

        // Test your methods here
    }
}

12. Key Takeaways

public allows access from other classes.

private restricts access to the containing class.

Private members help protect data.

Public methods can provide controlled access to private data.

Access modifiers are fundamental to encapsulation.

Avoid making everything public.

Expose only the functionality that other classes actually need.

Quick Rule

Does another class need direct access?
        │
       Yes
        │
        ▼
     public

       No
        │
        ▼
     private

Recommended Principle

Hide implementation details and expose a clear public interface.

Technologies

C#

.NET

Object-Oriented Programming (OOP)
## Getters and Setters in C#

### Overview

**Getters and setters** are used to control how data is accessed and modified in a class.

In C#, they are commonly implemented using **properties**.

- **Getter (`get`)** → Retrieves the value of a property.
- **Setter (`set`)** → Assigns or changes the value of a property.

They are important for **encapsulation**, because they allow a class to control access to its internal data.

---

## Basic Example

```csharp
class Student
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
}


# Inheritance in C#

## Overview

**Inheritance** is an Object-Oriented Programming (OOP) concept that allows one class to **inherit properties and methods from another class**.

The existing class is called the **base class** (or parent class), while the class that inherits from it is called the **derived class** (or child class).

Inheritance promotes **code reuse**, reduces duplication, and allows classes to represent relationships between objects.

---

## Basic Syntax

```csharp
class BaseClass
{
    // Members of the base class
}

class DerivedClass : BaseClass
{
    // Members of the derived class
}
```

The colon (`:`) indicates that the derived class inherits from the base class.

---

## Simple Example

```csharp
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
```

The `Car` class inherits the `Start()` method from `Vehicle`.

### Using the Classes

```csharp
Car car = new Car();

car.Start();
car.Drive();
```

Output:

```text
Vehicle is starting.
Car is driving.
```

The `Car` object can use:

* `Start()` → inherited from `Vehicle`
* `Drive()` → defined in `Car`

---

## Inheritance Hierarchy

A simple inheritance relationship can be represented as:

```text
Vehicle
   |
   ↓
  Car
```

Here:

* `Vehicle` is the **base class**.
* `Car` is the **derived class**.

---

## Multilevel Inheritance

Inheritance can occur across multiple levels.

```text
Vehicle
   |
   ↓
  Car
   |
   ↓
ElectricCar
```

### Example

```csharp
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
        Console.WriteLine("Car is driving.");
    }
}

class ElectricCar : Car
{
    public void ChargeBattery()
    {
        Console.WriteLine("Battery is charging.");
    }
}
```

### Usage

```csharp
ElectricCar car = new ElectricCar();

car.Start();
car.Drive();
car.ChargeBattery();
```

The `ElectricCar` object can access methods from both `Car` and `Vehicle`.

---

## Hierarchical Inheritance

Hierarchical inheritance occurs when **multiple classes inherit from the same base class**.

```text
          Vehicle
         /       \
        ↓         ↓
      Car       Truck
```

### Example

```csharp
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
        Console.WriteLine("Car is driving.");
    }
}

class Truck : Vehicle
{
    public void LoadCargo()
    {
        Console.WriteLine("Loading cargo.");
    }
}
```

Both `Car` and `Truck` inherit `Start()` from `Vehicle`.

---

## Inheritance with Properties

A derived class can also use properties inherited from its base class.

```csharp
class Person
{
    public string Name { get; set; }
}

class Student : Person
{
    public int StudentId { get; set; }
}
```

Usage:

```csharp
Student student = new Student();

student.Name = "John";
student.StudentId = 101;

Console.WriteLine(student.Name);
Console.WriteLine(student.StudentId);
```

Output:

```text
John
101
```

`Name` comes from `Person`, while `StudentId` belongs to `Student`.

---

## Protected Members and Inheritance

The `protected` access modifier is particularly useful with inheritance.

A `protected` member can be accessed:

* Inside the class where it is declared.
* Inside classes that inherit from it.

### Example

```csharp
class Vehicle
{
    protected int speed;

    public void DisplaySpeed()
    {
        Console.WriteLine($"Speed: {speed} km/h");
    }
}

class Car : Vehicle
{
    public void Accelerate()
    {
        speed += 10;
    }
}
```

The `Car` class can access `speed` because it is `protected`.

However, external classes cannot directly access it:

```csharp
Car car = new Car();

// car.speed = 100; // ERROR
```

---

## Method Overriding

Inheritance also allows a derived class to provide its own implementation of a method.

The base method must be declared with `virtual`, while the derived method uses `override`.

```csharp
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks.");
    }
}
```

Usage:

```csharp
Dog dog = new Dog();

dog.Speak();
```

Output:

```text
Dog barks.
```

This is an example of **polymorphism**.

---

## The `base` Keyword

The `base` keyword is used to access members of the parent class.

### Example

```csharp
class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }
}

class Car : Vehicle
{
    public string Model { get; set; }

    public Car(string brand, string model)
        : base(brand)
    {
        Model = model;
    }
}
```

Here:

```csharp
: base(brand)
```

calls the constructor of the `Vehicle` class.

---

## Why Use Inheritance?

Inheritance provides several advantages:

### 1. Code Reuse

Common functionality can be placed in a base class instead of being repeated.

### 2. Maintainability

Changes to shared functionality can be made in one place.

### 3. Extensibility

Derived classes can add new properties and methods.

### 4. Polymorphism

Different derived classes can provide different implementations of the same method.

### 5. Logical Relationships

Inheritance models relationships such as:

```text
Vehicle → Car
Animal → Dog
Person → Student
Employee → Manager
Product → Smartphone
```

---

## Inheritance vs Composition

Inheritance represents an **"is-a"** relationship.

```text
Car is a Vehicle
Dog is an Animal
Student is a Person
```

Composition represents a **"has-a"** relationship.

```text
Car has an Engine
Computer has a Processor
House has a Room
```

Use inheritance when there is a genuine **is-a relationship**.

---

## Common Types of Inheritance

| Type         | Description                                    | Example                               |
| ------------ | ---------------------------------------------- | ------------------------------------- |
| Single       | One derived class inherits from one base class | `Vehicle → Car`                       |
| Multilevel   | Inheritance occurs across multiple levels      | `Vehicle → Car → ElectricCar`         |
| Hierarchical | Multiple classes inherit from one base class   | `Vehicle → Car/Truck`                 |
| Multiple     | One class inherits from multiple classes       | Not supported directly for C# classes |
| Hybrid       | Combination of inheritance structures          | Possible using classes and interfaces |

> C# does not support multiple inheritance of classes, but a class can implement multiple interfaces.

---

## Complete Example

```csharp
using System;

class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public virtual void Start()
    {
        Console.WriteLine($"{Brand} vehicle is starting.");
    }
}

class Car : Vehicle
{
    public string Model { get; set; }

    public Car(string brand, string model)
        : base(brand)
    {
        Model = model;
    }

    public override void Start()
    {
        Console.WriteLine($"{Brand} {Model} car is starting.");
    }
}

class ElectricCar : Car
{
    public int BatteryCapacity { get; set; }

    public ElectricCar(
        string brand,
        string model,
        int batteryCapacity)
        : base(brand, model)
    {
        BatteryCapacity = batteryCapacity;
    }

    public void Charge()
    {
        Console.WriteLine("Electric car is charging.");
    }
}

class Program
{
    static void Main()
    {
        ElectricCar car =
            new ElectricCar("Tesla", "Model 3", 75);

        car.Start();
        car.Charge();

        Console.WriteLine(
            $"Battery: {car.BatteryCapacity} kWh");
    }
}
```

### Output

```text
Tesla Model 3 car is starting.
Electric car is charging.
Battery: 75 kWh
```

---

## Key Takeaways

* **Inheritance** allows a class to acquire members from another class.
* The **base class** contains common functionality.
* The **derived class** inherits and extends the base class.
* Use `:` to specify inheritance.
* Use `protected` when derived classes need access to a member.
* Use `virtual` and `override` to implement method overriding.
* Use `base` to access the parent class's constructor or members.
* Inheritance represents an **"is-a" relationship**.
* C# supports single, multilevel, and hierarchical class inheritance.
* C# does **not** support multiple inheritance between classes.

### Quick Reference

```text
Base Class
    │
    │ inherits
    ▼
Derived Class
    │
    │ can extend
    ▼
Additional Functionality
```

**Recommended principle:** Use inheritance when the derived class genuinely represents a specialized version of the base class.

Author

Domo Ereku
