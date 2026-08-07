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