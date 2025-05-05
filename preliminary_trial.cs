
using System;

class Stock
{
    public string Symbol { get; set; }
    public double Price { get; set; }

    public Stock(string symbol, double price)
    {
        Symbol = symbol;
        Price = price;
    }
}

class Program
{
    static void Main()
    {
        Stock appleStock = new Stock("AAPL", 150.50);
        Stock googleStock = new Stock("GOOGL", 2500.75);

        Console.WriteLine("Welcome to the stock trading system!");
        Console.WriteLine("Available stocks:");
        Console.WriteLine($"1. {appleStock.Symbol} - Price: ${appleStock.Price}");
        Console.WriteLine($"2. {googleStock.Symbol} - Price: ${googleStock.Price}");

        Console.Write("Enter the stock symbol you would like to trade: ");
        string input = Console.ReadLine();

        if (input.ToUpper() == appleStock.Symbol)
        {
            Console.WriteLine($"Trading {appleStock.Symbol} - Price: ${appleStock.Price}");
            // Add trading logic here for Apple stock
        }
        else if (input.ToUpper() == googleStock.Symbol)
        {
            Console.WriteLine($"Trading {googleStock.Symbol} - Price: ${googleStock.Price}");
            // Add trading logic here for Google stock
        }
        else
        {
            Console.WriteLine("Invalid stock symbol entered.");
        }
    }
}
