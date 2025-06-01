
using System;
using System.Collections.Generic;

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
    static List<Stock> stocks = new List<Stock>()
    {
        new Stock("AAPL", 150.00),
        new Stock("MSFT", 200.00),
        new Stock("GOOGL", 2500.00)
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the stock trading system!");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. View stock prices");
            Console.WriteLine("2. Buy stock");
            Console.WriteLine("3. Sell stock");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewStockPrices();
                    break;
                case 2:
                    BuyStock();
                    break;
                case 3:
                    SellStock();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the stock trading system!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ViewStockPrices()
    {
        Console.WriteLine("\nStock Prices:");
        foreach (var stock in stocks)
        {
            Console.WriteLine($"{stock.Symbol}: {stock.Price:C}");
        }
    }

    static void BuyStock()
    {
        Console.Write("Enter the symbol of the stock you want to buy: ");
        string symbol = Console.ReadLine();

        Stock stock = stocks.Find(s => s.Symbol == symbol);
        if (stock != null)
        {
            Console.Write("Enter the quantity you want to buy: ");
            int quantity = int.Parse(Console.ReadLine());

            double totalCost = stock.Price * quantity;
            Console.WriteLine($"Total cost: {totalCost:C}");
        }
        else
        {
            Console.WriteLine("Stock not found. Please try again.");
        }
    }

    static void SellStock()
    {
        Console.Write("Enter the symbol of the stock you want to sell: ");
        string symbol = Console.ReadLine();

        Stock stock = stocks.Find(s => s.Symbol == symbol);
        if (stock != null)
        {
            Console.Write("Enter the quantity you want to sell: ");
            int quantity = int.Parse(Console.ReadLine());

            double totalAmount = stock.Price * quantity;
            Console.WriteLine($"Total amount received: {totalAmount:C}");
        }
        else
        {
            Console.WriteLine("Stock not found. Please try again.");
        }
    }
}
