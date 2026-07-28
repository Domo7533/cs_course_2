using System;

public class Program
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }
        public int YearPublished { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }

        public int NumberOfPages { get; set; }
        public decimal Price { get; set; }

        public string Language { get; set; }
        public int Edition { get; set; }

        public bool IsAvailable { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine("Book Details");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Pages: {NumberOfPages}");
            Console.WriteLine($"Price: ${Price:F2}");
            Console.WriteLine($"Language: {Language}");
            Console.WriteLine($"Edition: {Edition}");
            Console.WriteLine($"Available: {IsAvailable}");
        }
	public bool IsClassic()
	{
    		return YearPublished < 1970;
	}

	public bool IsExpensive()
	{
    		return Price > 50;
	}

	public double PriceWithDiscount(double percentage)
	{
   		 return (double)(Price * (1 - (decimal)(percentage / 100)));
	}

	public void BorrowBook()
	{
    		if (IsAvailable)
    		{
        		IsAvailable = false;
        		Console.WriteLine($"{Title} has been borrowed.");
    		}
    		else
    		{
        		Console.WriteLine($"{Title} is currently unavailable.");
   		}
	}

	public void ReturnBook()
	{
    		IsAvailable = true;
    		Console.WriteLine($"{Title} has been returned.");
	}
    }

    public static void Main()
    {
        Book book1 = new Book
        {
            Title = "Things Fall Apart",
            Author = "Chinua Achebe",
            ISBN = "9780385474542",
            Publisher = "Anchor Books",
            YearPublished = 1958,
            Genre = "Historical Fiction",
            NumberOfPages = 209,
            Price = 18.99m,
            Language = "English",
            Edition = 1,
            IsAvailable = true
        };

        book1.PrintDetails();
    }
}