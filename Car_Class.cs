using System;
					
public class Program
{
	class Car {
		public string Brand;
		public int year;
    	public void Drive(){
			Console.WriteLine($"{Brand} {year} car is Driving ");
	}
	
	public static void Main()
	{
		Car car1 = new Car();
		Car car2 = new Car();
		car1.Brand="camry";
		car1.year= 2026;
		car1.Drive();
		}
					
	}
}