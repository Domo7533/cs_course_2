using System;

class Product
{
    // Task 1: Private field
    private decimal price;

    // Task 2: Property with validation
    public decimal Price
    {
        get { return price; }
        set
        {
            if (value > 0)
            {
                price = value;
            }
            else
            {
                Console.WriteLine("Price must be greater than 0.");
            }
        }
    }

    // Task 3: Auto-property
    public string Name { get; set; }

    // Task 4: Print product information
    public void PrintDetails()
    {
        Console.WriteLine($"Product Name: {Name}");
        Console.WriteLine($"Product Price: ₦{Price:N2}");
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product();

        product.Name = "Laptop";
        product.Price = 450000;

        product.PrintDetails();
    }
}

using System;

class Product
{
    private decimal price;
    private int stockQuantity;

    public int ProductId { get; set; }

    public string Name { get; set; }

    public string Category { get; set; }

    public string Brand { get; set; }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
            else
                Console.WriteLine("Price must be greater than 0.");
        }
    }

    public int StockQuantity
    {
        get { return stockQuantity; }
        set
        {
            if (value >= 0)
                stockQuantity = value;
            else
                Console.WriteLine("Stock quantity cannot be negative.");
        }
    }

    public double DiscountPercentage { get; set; }

    public double Rating { get; set; }

    public bool IsAvailable { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Price: ₦{Price:N2}");
        Console.WriteLine($"Stock Quantity: {StockQuantity}");
        Console.WriteLine($"Discount: {DiscountPercentage}%");
        Console.WriteLine($"Rating: {Rating}/5");
        Console.WriteLine($"Available: {IsAvailable}");
    }
}