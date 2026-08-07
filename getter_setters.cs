using System;
					
public class Program
{	
	public class Student{
		private int age;
		public int Age {
			get {return age;}
			set {
				if (value < 0) throw new Exception("Age cannot be negative");
				age = value;
			}
		}
	}
					
	public static void Main()
	{
		Student s1 = new Student();
		s1.Age = -40;
		Console.WriteLine($"The user is {s1.Age} years old");
		
	}
}
//GPA Property — Range 0–4
class Student
{
    private double gpa;

    public double GPA
    {
        get { return gpa; }
        set
        {
            if (value >= 0 && value <= 4)
            {
                gpa = value;
            }
            else
            {
                Console.WriteLine("GPA must be between 0 and 4.");
            }
        }
    }
}

// usage
Student student = new Student();

student.GPA = 3.5;   // Valid
student.GPA = 4.0;   // Valid
student.GPA = 5.0;   // Invalid

//Age Property — Minimum Age
class Person
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
            else
            {
                Console.WriteLine("Age cannot be negative.");
            }
        }
    }
}
// Exam Score — Range 0–100
class Student
{
    private double score;

    public double Score
    {
        get { return score; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                score = value;
            }
            else
            {
                Console.WriteLine("Score must be between 0 and 100.");
            }
        }
    }
}
//Age — Using an Exception
class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(Age),
                    "Age must be between 0 and 120."
                );
            }

            age = value;
        }
    }
}
// Key OOP Concept

//The important pattern is:
private data;
public property
{
    get { return data; }
    set
    {
        // validation
    }
}


//