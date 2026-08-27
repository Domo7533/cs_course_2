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