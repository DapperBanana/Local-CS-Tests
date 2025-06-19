
using System;

class Stock
{
    public string Symbol { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Stock(string symbol, double price, int quantity)
    {
        Symbol = symbol;
        Price = price;
        Quantity = quantity;
    }

    public double GetValue()
    {
        return Price * Quantity;
    }
}

class Program
{
    static void Main()
    {
        Stock apple = new Stock("AAPL", 150.0, 10);
        Stock google = new Stock("GOOGL", 2000.0, 5);

        Console.WriteLine($"Stocks available for trading:");
        Console.WriteLine($"1. {apple.Symbol}: {apple.Price} per share");
        Console.WriteLine($"2. {google.Symbol}: {google.Price} per share");

        Console.Write("Enter the stock symbol you want to buy: ");
        string symbol = Console.ReadLine();

        Stock selectedStock = symbol == apple.Symbol ? apple : google;

        Console.Write("Enter the quantity you want to buy: ");
        int quantity = int.Parse(Console.ReadLine());

        if (quantity <= 0)
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        double totalPrice = selectedStock.Price * quantity;

        if (totalPrice > selectedStock.GetValue())
        {
            Console.WriteLine("Not enough funds to make this purchase.");
        }
        else
        {
            selectedStock.Quantity += quantity;
            Console.WriteLine($"Successfully bought {quantity} shares of {selectedStock.Symbol}.");
        }

        Console.WriteLine($"Total value of your {apple.Symbol} shares: {apple.GetValue()}");
        Console.WriteLine($"Total value of your {google.Symbol} shares: {google.GetValue()}");
    }
}
