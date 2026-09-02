using System;
					
public class Program
{
	interface IReadable 
	{
		void Read(); 
	} 
	interface IWritable 
	{ 	
		void Write(); 
	} 
	class Document : IReadable, IWritable { 
			public void Read() 
			{
				Console.WriteLine("Reading document"); 
			}
		
			public void Write() 
			{ 
				Console.WriteLine("Writing document"); 
			} 
	}
	public static void Main()
	{
		 Document doc = new Document(); 
		doc.Read(); // Output: Reading document 
		doc.Write(); // Output: Writing.WriteLine("Hello World");
	}
}


using System;

interface IWork
{
    void Work();
}

interface IReport
{
    void GenerateReport();
}

interface IManage
{
    void ManageTeam();
}

class Manager : IWork, IReport, IManage
{
    public void Work()
    {
        Console.WriteLine("Manager is working.");
    }

    public void GenerateReport()
    {
        Console.WriteLine("Manager is generating a report.");
    }

    public void ManageTeam()
    {
        Console.WriteLine("Manager is managing the team.");
    }
}

class Developer : IWork, IReport
{
    public void Work()
    {
        Console.WriteLine("Developer is writing code.");
    }

    public void GenerateReport()
    {
        Console.WriteLine("Developer is generating a technical report.");
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager();
        Developer developer = new Developer();

        manager.Work();
        manager.GenerateReport();
        manager.ManageTeam();

        Console.WriteLine();

        developer.Work();
        developer.GenerateReport();
    }
}