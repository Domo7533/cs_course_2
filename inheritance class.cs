using System;
					
public class Program
{
	public class Animal 
	{ 
		public void Eat() { 
			Console.WriteLine("Animal is eating"); 
		}
	}

	public class Dog : Animal 
	{ 
		public void Bark() { 
			Console.WriteLine("Dog is barking");
		}
	}

	public static void Main()
	{
		Dog d = new Dog(); 
		d.Eat(); // inherited	
		d.Bark();
		
	}