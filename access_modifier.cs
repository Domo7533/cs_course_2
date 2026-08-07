using System;
					
public class Program
{
	class Student { 
		
		public string Name; // accessible everywhere 
		private int age; // accessible only inside Student 
		protected string Grade; // accessible inside Student and subclasses 
		internal string School; // accessible within same assembly 
	}
	public static void Main()
	{
		Student student1 = new Student();
		student1.Name = "Domo";		
		Console.WriteLine($"Name:{student1.Name}");
	}
}