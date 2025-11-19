
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
        new Stock("GOOGL", 2500.00),
        new Stock("MSFT", 300.00)
    };

    static double balance = 1000.00;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Your current balance is: ${0}", balance);
            Console.WriteLine("Available stocks:");
            foreach (var stock in stocks)
            {
                Console.WriteLine("{0} - ${1}", stock.Name, stock.Price);
            }

            Console.WriteLine("Enter 'buy [stock] [quantity]' to buy stock or 'sell [stock] [quantity]' to sell stock:");
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');

            if (tokens.Length != 3)
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            string action = tokens[0];
            string stockName = tokens[1];
            int quantity = Int32.Parse(tokens[2]);

            Stock selectedStock = stocks.Find(s => s.Name == stockName);
            if (selectedStock == null)
            {
                Console.WriteLine("Stock not found. Please try again.");
                continue;
            }

            double totalPrice = selectedStock.Price * quantity;
            if (action == "buy")
            {
                if (totalPrice > balance)
                {
                    Console.WriteLine("Insufficient funds. Please try again.");
                    continue;
                }

                balance -= totalPrice;
                Console.WriteLine("Purchased {0} shares of {1} for ${2}. Current balance: ${3}", quantity, stockName, totalPrice, balance);
            }
            else if (action == "sell")
            {
                if (quantity > 0)
                {
                    double newBalance = balance + totalPrice;
                    Console.WriteLine("Sold {0} shares of {1} for ${2}. Current balance: ${3}", quantity, stockName, totalPrice, newBalance);
                    balance = newBalance;
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid action. Please try again.");
            }
        }
    }
}
