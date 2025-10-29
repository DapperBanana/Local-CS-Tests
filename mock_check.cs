
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
    static List<Stock> stocks = new List<Stock>();

    static void Main(string[] args)
    {
        stocks.Add(new Stock("AAPL", 150.23));
        stocks.Add(new Stock("GOOGL", 2720.43));

        while (true)
        {
            Console.WriteLine("Stock Trading System");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. List Stocks");
            Console.WriteLine("2. Buy Stock");
            Console.WriteLine("3. Sell Stock");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ListStocks();
                    break;
                case "2":
                    BuyStock();
                    break;
                case "3":
                    SellStock();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ListStocks()
    {
        Console.WriteLine("Stocks Available:");
        foreach (Stock stock in stocks)
        {
            Console.WriteLine($"Symbol: {stock.Symbol}, Price: {stock.Price}");
        }
    }

    static void BuyStock()
    {
        Console.Write("Enter the symbol of the stock you want to buy: ");
        string symbol = Console.ReadLine();

        Stock stock = stocks.Find(s => s.Symbol == symbol);
        if (stock == null)
        {
            Console.WriteLine("Stock not found.");
        }
        else
        {
            Console.Write("Enter the quantity you want to buy: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double totalPrice = stock.Price * quantity;
            Console.WriteLine($"Bought {quantity} shares of {stock.Symbol} for ${totalPrice}");
        }
    }

    static void SellStock()
    {
        Console.Write("Enter the symbol of the stock you want to sell: ");
        string symbol = Console.ReadLine();

        Stock stock = stocks.Find(s => s.Symbol == symbol);
        if (stock == null)
        {
            Console.WriteLine("Stock not found.");
        }
        else
        {
            Console.Write("Enter the quantity you want to sell: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double totalPrice = stock.Price * quantity;
            Console.WriteLine($"Sold {quantity} shares of {stock.Symbol} for ${totalPrice}");
        }
    }
}
