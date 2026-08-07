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