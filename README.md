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

Author

Domo Ereku
