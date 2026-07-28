using System;
					
public class Program
{
	class Student
	{
   		public string Name; 
		public int Age; 
		public void PrintInfo() { 
			Console.WriteLine($"Name: {Name}, Age: {Age}"); 
		}
	}

	public static void Main()
	{
		Student s1 = new Student(); 
		Console.WriteLine("Enter student name: ");	
		string studentName = Console.ReadLine();
		s1.Name = studentName;
		Console.WriteLine("Enter student Age: ");
		if (int.TryParse(Console.ReadLine(), out int studentAge)) {
			s1.Age = studentAge;
			s1.PrintInfo();
		} else { 
			Console.WriteLine("Invalid Age");
		}
	}
}