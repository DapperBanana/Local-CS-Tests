
using System;
using System.Collections.Generic;

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
    static List<Stock> stocks = new List<Stock>
    {
        new Stock("AAPL", 150.00),
        new Stock("GOOGL", 2000.00),
        new Stock("AMZN", 3000.00)
    };

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the stock trading system!");
            Console.WriteLine("Available stocks:");
            foreach (var stock in stocks)
            {
                Console.WriteLine($"{stock.Name} - ${stock.Price}");
            }

            Console.WriteLine("Enter the stock symbol you want to buy or sell (or 'exit' to quit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                running = false;
                continue;
            }

            Stock selectedStock = stocks.Find(s => s.Name.ToLower() == input.ToLower());
            if (selectedStock == null)
            {
                Console.WriteLine("Invalid stock symbol. Please try again.");
                continue;
            }

            Console.WriteLine($"Current price of {selectedStock.Name}: ${selectedStock.Price}");
            Console.WriteLine("Enter 'buy' or 'sell':");
            string action = Console.ReadLine();

            if (action.ToLower() == "buy")
            {
                Console.WriteLine($"How many shares of {selectedStock.Name} do you want to buy?");
                int quantity = int.Parse(Console.ReadLine());
                double totalPrice = selectedStock.Price * quantity;
                Console.WriteLine($"Total cost: ${totalPrice}");
            }
            else if (action.ToLower() == "sell")
            {
                Console.WriteLine($"How many shares of {selectedStock.Name} do you want to sell?");
                int quantity = int.Parse(Console.ReadLine());
                double totalProfit = selectedStock.Price * quantity;
                Console.WriteLine($"Total profit: ${totalProfit}");
            }
            else
            {
                Console.WriteLine("Invalid action. Please try again.");
            }
        }
    }
}
