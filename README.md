# cs_course_2
my second cs_course program
# Object-Oriented Programming (OOP) Essentials in C#

![C#](https://img.shields.io/badge/Language-C%23-purple)
![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![License](https://img.shields.io/badge/License-MIT-green)

## 📖 Overview

This project introduces the **fundamental concepts of Object-Oriented Programming (OOP)** using **C#**. OOP is a programming paradigm that organizes software into reusable objects containing both **data (fields/properties)** and **behavior (methods)**.

The examples in this project are designed for beginners learning C# and demonstrate how to create, use, and organize objects effectively.

---

# 🎯 Learning Objectives

After completing this project, you should be able to:

- Understand the principles of Object-Oriented Programming.
- Create classes and objects.
- Use constructors to initialize objects.
- Implement encapsulation using properties.
- Apply inheritance to reuse code.
- Override methods using polymorphism.
- Design reusable applications with abstraction.
- Organize code into multiple classes.

---

# 📚 OOP Concepts Covered

## 1. Classes

A class is a blueprint for creating objects.

```csharp
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

---

## 2. Objects

An object is an instance of a class.

```csharp
Student student = new Student();

student.Name = "John";
student.Age = 20;
```

---

## 3. Fields

Fields store data inside a class.

```csharp
public class Student
{
    private string schoolName = "ABC University";
}
```

---

## 4. Properties

Properties provide controlled access to fields.

```csharp
public string Name { get; set; }

public int Age { get; set; }
```

---

## 5. Constructors

Constructors initialize objects when they are created.

```csharp
public Student(string name, int age)
{
    Name = name;
    Age = age;
}
```

Usage:

```csharp
Student student = new Student("Mary", 22);
```

---

## 6. Methods

Methods define what an object can do.

```csharp
public void Display()
{
    Console.WriteLine($"{Name} is {Age} years old.");
}
```

---

# 🔒 Encapsulation

Encapsulation protects data by restricting direct access.

Example:

```csharp
private int age;

public int Age
{
    get { return age; }

    set
    {
        if (value > 0)
            age = value;
    }
}
```

Benefits:

- Data protection
- Validation
- Easier maintenance

---

# 👨‍👩‍👧 Inheritance

Inheritance allows one class to inherit properties and methods from another.

```csharp
public class Person
{
    public string Name { get; set; }
}

public class Student : Person
{
    public string Department { get; set; }
}
```

Benefits:

- Code reuse
- Less duplication
- Easier maintenance

---

# 🔄 Polymorphism

Polymorphism allows the same method to behave differently.

```csharp
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Bark");
    }
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

---

# 🧩 Abstraction

Abstraction hides implementation details while exposing only essential functionality.

```csharp
abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
```

---

# 📦 Example Project Structure

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

---

# 💻 Example Program

```csharp
using System;

class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"{Name} is {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Alice", 21);

        student.Display();
    }
}
```

Output

```
Alice is 21 years old.
```

---

# 🧠 The Four Pillars of OOP

| Principle | Description |
|-----------|-------------|
| Encapsulation | Protects data using properties and access modifiers |
| Inheritance | Reuses code by extending existing classes |
| Polymorphism | Allows methods to have multiple implementations |
| Abstraction | Hides unnecessary implementation details |

---

# 🎯 Real-World Examples

| Class | Object |
|--------|--------|
| Car | Toyota Camry |
| Student | Alice |
| Teacher | Mr. James |
| BankAccount | Savings Account |
| Book | "Clean Code" |
| Employee | Software Developer |

---

# 🏗 Sample Class Diagram

```
              Person
          ----------------
          Name
          Age
              ▲
      ┌───────┴────────┐
      │                │
   Student         Teacher
Department       Subject
```

---

# 📈 Advantages of OOP

- Reusable code
- Easier maintenance
- Better organization
- Improved scalability
- Increased security
- Simplified debugging
- Better collaboration in teams

---

# ⚠ Common Beginner Mistakes

- Forgetting to create objects before using them.
- Confusing classes with objects.
- Exposing fields instead of using properties.
- Not using constructors appropriately.
- Ignoring access modifiers (`public`, `private`, `protected`).
- Overusing inheritance when composition is more suitable.

---

# 📝 Practice Exercises

1. Create a `Car` class with properties for **Brand**, **Model**, and **Year**.
2. Add a constructor to initialize the object.
3. Create a `Person` class and derive `Student` and `Teacher` from it.
4. Override a method using polymorphism.
5. Create an abstract `Shape` class and implement `Rectangle` and `Circle`.
6. Add validation to properties using encapsulation.
7. Build a simple Library Management System using OOP principles.

---

# 🚀 How to Run

### Clone the repository

```bash
git clone https://github.com/yourusername/ObjectOrientedProgramming.git
```

### Navigate to the project

```bash
cd ObjectOrientedProgramming
```

### Run the project

```bash
dotnet run
```

---

# 📚 Recommended Learning Resources

- Microsoft Learn – C# Fundamentals
- Microsoft Learn – Object-Oriented Programming
- .NET Documentation
- C# Yellow Book by Rob Miles
- Head First Object-Oriented Analysis and Design

---

# 🎓 Prerequisites

- Basic understanding of C#
- .NET SDK installed
- Visual Studio or Visual Studio Code
- Command-line basics

---

# 🤝 Contributing

Contributions are welcome!

1. Fork the repository.
2. Create a new feature branch.
3. Commit your changes.
4. Push your branch.
5. Open a Pull Request.

---

# 📄 License

This project is licensed under the MIT License.

---

# 👨‍💻 Author

**Domo Ereku**

Computer Scientist | Software Developer | Digital Skills Trainer

*"Learning Object-Oriented Programming is the foundation for building scalable, maintainable, and professional software applications."*
