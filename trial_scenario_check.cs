
using System;

class Stock
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Stock(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main()
    {
        Stock apple = new Stock("AAPL", 150.00);
        Stock google = new Stock("GOOGL", 2000.00);

        Console.WriteLine("Welcome to the stock trading system!");
        Console.WriteLine("Available stocks:");
        Console.WriteLine("1. Apple (AAPL) - $150.00");
        Console.WriteLine("2. Google (GOOGL) - $2000.00");

        Console.WriteLine("Select a stock to trade (1 or 2):");
        int choice = int.Parse(Console.ReadLine());

        Stock selectedStock = null;

        switch (choice)
        {
            case 1:
                selectedStock = apple;
                break;
            case 2:
                selectedStock = google;
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine($"You selected {selectedStock.Name} - {selectedStock.Price}");

        Console.WriteLine("Enter the quantity to buy:");
        int quantity = int.Parse(Console.ReadLine());

        double totalCost = selectedStock.Price * quantity;
        Console.WriteLine($"Total cost: ${totalCost}");

        Console.WriteLine("Trade successful! Thank you for using the stock trading system.");
    }
}
