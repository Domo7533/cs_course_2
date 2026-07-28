//Basic Student Class
using System;

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            StudentId = 101,
            Name = "John Doe",
            Age = 20
        };

        student.DisplayInfo();
    }
}
// Variation 2: Student Class with GPA

//Introduces an additional property.

using System;

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"GPA: {GPA:F2}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            StudentId = 101,
            Name = "Jane Smith",
            Age = 22,
            GPA = 3.82
        };

        student.DisplayInfo();
    }
}
//Variation 3: Student Class with IsAdult()

//Demonstrates a method that returns a Boolean.

using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public bool IsAdult()
    {
        return Age >= 18;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "Michael",
            Age = 17
        };

        Console.WriteLine($"{student.Name} Adult? {student.IsAdult()}");
    }
}

//Output

//Michael Adult? False

//Variation 4: Student Class with Grade Classification

//Determines academic standing based on GPA.

using System;

class Student
{
    public string Name { get; set; }
    public double GPA { get; set; }

    public string GetGradeClassification()
    {
        if (GPA >= 3.7)
            return "First Class";

        if (GPA >= 3.3)
            return "Second Class Upper";

        if (GPA >= 2.5)
            return "Second Class Lower";

        if (GPA >= 2.0)
            return "Third Class";

        return "Pass";
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "Sarah",
            GPA = 3.65
        };

        Console.WriteLine(student.GetGradeClassification());
    }
}

//Variation 5: Student Class with Full Name

//Uses two properties and a computed method.

using System;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            FirstName = "David",
            LastName = "Johnson"
        };

        Console.WriteLine(student.GetFullName());
    }
}

//Variation 6: Student Class with Email Generator

//Automatically creates a student email.

using System;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetSchoolEmail()
    {
        return $"{FirstName.ToLower()}.{LastName.ToLower()}@school.edu";
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            FirstName = "Mary",
            LastName = "Brown"
        };

        Console.WriteLine(student.GetSchoolEmail());
    }
}


//Variation 7: Student Class with Pass/Fail Check

//Demonstrates decision-making.

using System;

class Student
{
    public string Name { get; set; }
    public int Score { get; set; }

    public bool HasPassed()
    {
        return Score >= 50;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "Emma",
            Score = 74
        };

        Console.WriteLine($"{student.Name} Passed: {student.HasPassed()}");
    }
}


//Variation 8: Student Class with Constructor

//Shows object initialization through a constructor.

using System;

class Student
{
    public int StudentId { get; }
    public string Name { get; }
    public int Age { get; }

    public Student(int studentId, string name, int age)
    {
        StudentId = studentId;
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{StudentId} - {Name} ({Age} years old)");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student(101, "Alice", 21);

        student.DisplayInfo();
    }
}


//Variation 9: Student Class with Scholarship Eligibility

//Combines multiple conditions.

using System;

class Student
{
    public string Name { get; set; }
    public double GPA { get; set; }
    public int Attendance { get; set; }

    public bool IsEligibleForScholarship()
    {
        return GPA >= 3.5 && Attendance >= 80;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "Daniel",
            GPA = 3.8,
            Attendance = 92
        };

        Console.WriteLine(student.IsEligibleForScholarship());
    }
}

//Variation 10: Student Class with Multiple Utility Methods

//A more realistic object-oriented example.

using System;

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }
    public int Score { get; set; }

    public bool IsAdult()
    {
        return Age >= 18;
    }

    public bool HasPassed()
    {
        return Score >= 50;
    }

    public bool IsHonorStudent()
    {
        return GPA >= 3.5;
    }

    public string GetStatus()
    {
        return HasPassed() ? "Passed" : "Failed";
    }

    public void DisplaySummary()
    {
        Console.WriteLine("Student Summary");
        Console.WriteLine("-----------------------");
        Console.WriteLine($"ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"GPA: {GPA:F2}");
        Console.WriteLine($"Score: {Score}");
        Console.WriteLine($"Adult: {IsAdult()}");
        Console.WriteLine($"Honor Student: {IsHonorStudent()}");
        Console.WriteLine($"Result: {GetStatus()}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            StudentId = 101,
            Name = "John Doe",
            Age = 20,
            GPA = 3.85,
            Score = 88
        };

        student.DisplaySummary();
    }
}