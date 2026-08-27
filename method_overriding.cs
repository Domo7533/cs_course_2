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

using System;

class Bird
{
    public virtual void Speak()
    {
        Console.WriteLine("The bird makes a sound.");
    }
}

class Sparrow : Bird
{
    public override void Speak()
    {
        Console.WriteLine("Sparrow: Chirp Chirp!");
    }
}

class Program
{
    static void Main()
    {
        Bird bird = new Sparrow();
        bird.Speak();
    }
}
//Animal → Speak() → Bark()
using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog: Woof Woof!");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Dog();
        animal.Speak();
    }
}


//Animal → Speak() → Meow()
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat: Meow!");
    }
}