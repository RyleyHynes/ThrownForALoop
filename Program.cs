
// Creates a new list and adds 5 items to it that are in a collection initializer
// This list is being saved in a variable called prodicts 

List<Product> products = new List<Product>()
{
    new Product()
    // curly braces below are called the initializer
    {
        Name = "Football",
        Price = 15.00M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 4.2
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12.00M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 2.2
    },
    new Product()
    {
        Name = "Lacross Stick",
        Price = 52.00M,
        Sold = true,
        StockDate = new DateTime(2022, 10, 22),
        ManufactureYear = 2010,
        Condition = 6.7
    },
    new Product()
    {
        Name = "Basketball",
        Price = 15.00M,
        Sold = false,
        StockDate = new DateTime(2021, 10, 20),
        ManufactureYear = 2010,
        Condition = 3.4
    },
    new Product()
    {
        Name = "Rock Climbing Shoes",
        Price = 120.00M,
        Sold = false,
        StockDate = new DateTime(2022, 11, 20),
        ManufactureYear = 2010,
        Condition = 7.9
    },
    new Product()
    {
        Name = "Rope",
        Price = 100.00M,
        Sold = true,
        StockDate = new DateTime(2020, 10, 20),
        ManufactureYear = 2010,
        Condition = 1.4
    }
};

string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);
string? choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Choose an option:
    0. Exit
    1. View All Products
    2. View Product Details");
    choice = Console.ReadLine()!;
    if (choice == "0")
    {
        Console.WriteLine("Goodbye!");
    }
    else if (choice == "1")
    {
        ListProducts();
    }
    else if (choice == "2")
    {
        ViewProductDetails();

    }
}

// decimal totalValue = 0.0M;
// foreach (Product product in products)
// {
//     if (!product.Sold)
//     {
//         totalValue += product.Price;
//     }
// }
// Console.WriteLine($"Total inventory value: ${totalValue}");



void ViewProductDetails()
{
    ListProducts();
    Product? chosenProduct = null;
    while (chosenProduct == null)
    {
        Console.WriteLine("Please enter a product number: ");
        try
        {
            int response = int.Parse(Console.ReadLine()!.Trim());
            chosenProduct = products[response - 1];
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type only integers!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please choose an existing item only!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Do Better!");
        }
    }
}

void ListProducts()
{
    decimal totalValue = 0.0M;
    foreach (Product product in products)
    {
        if (!product.Sold)
        {
            totalValue += product.Price;
        }
    }
    Console.WriteLine($"Total inventory value: ${totalValue}");
    Console.WriteLine("Products:");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }
};