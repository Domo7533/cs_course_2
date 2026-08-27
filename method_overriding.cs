using System;
					
public class Program
{
	class Animal 
	{ 
		public virtual void Speak() 
		{ 
				Console.WriteLine("Animal makes a sound"); 
		}
	} 
	class Dog : Animal 
	{ 
		public override void Speak() 
		{ 
				Console.WriteLine("Dog barks"); 
		}
	}
	public static void Main()
	{
	 Animal a = new Dog(); a.Speak(); // Output: Dog barks
	}
}