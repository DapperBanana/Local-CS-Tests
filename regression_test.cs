
using System;
using System.Collections.Generic;
using System.Linq;

class Stock
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static List<Stock> portfolio = new List<Stock>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. View Portfolio");
            Console.WriteLine("2. Buy Stock");
            Console.WriteLine("3. Sell Stock");
            Console.WriteLine("4. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewPortfolio();
                    break;
                case 2:
                    BuyStock();
                    break;
                case 3:
                    SellStock();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ViewPortfolio()
    {
        if (portfolio.Count == 0)
        {
            Console.WriteLine("Portfolio is empty.");
        }
        else
        {
            foreach (Stock stock in portfolio)
            {
                Console.WriteLine($"{stock.Name} - Price: {stock.Price}, Quantity: {stock.Quantity}");
            }
        }
    }

    static void BuyStock()
    {
        Console.WriteLine("Enter stock name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter price:");
        double price = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter quantity:");
        int quantity = int.Parse(Console.ReadLine());

        portfolio.Add(new Stock { Name = name, Price = price, Quantity = quantity });
        Console.WriteLine("Stock bought successfully.");
    }

    static void SellStock()
    {
        Console.WriteLine("Enter stock name:");
        string name = Console.ReadLine();

        Stock stock = portfolio.FirstOrDefault(s => s.Name == name);
        if (stock != null)
        {
            Console.WriteLine("Enter quantity to sell:");
            int quantity = int.Parse(Console.ReadLine());

            if (quantity <= stock.Quantity)
            {
                stock.Quantity -= quantity;
                Console.WriteLine("Stock sold successfully.");
            }
            else
            {
                Console.WriteLine("Not enough quantity to sell.");
            }
        }
        else
        {
            Console.WriteLine("Stock not found in portfolio.");
        }
    }
}
