
using System;
using System.Collections.Generic;

class Stock
{
    public string Symbol { get; set; }
    public double Price { get; set; }
}

class Program
{
    static List<Stock> stocks = new List<Stock>();

    static void Main()
    {
        stocks.Add(new Stock { Symbol = "AAPL", Price = 145.52 });
        stocks.Add(new Stock { Symbol = "GOOGL", Price = 2780.48 });

        Console.WriteLine("Welcome to the Stock Trading System!");

        while (true)
        {
            Console.WriteLine("\nAvailable Stocks:");
            foreach (var stock in stocks)
            {
                Console.WriteLine($"{stock.Symbol} - ${stock.Price}");
            }

            Console.Write("\nEnter the symbol of the stock you want to trade (or 'Q' to quit): ");
            string symbol = Console.ReadLine().ToUpper();

            if (symbol == "Q")
            {
                break;
            }

            Stock selectedStock = stocks.Find(s => s.Symbol == symbol);
            if (selectedStock == null)
            {
                Console.WriteLine("Invalid stock symbol. Please try again.");
                continue;
            }

            Console.Write("Enter the quantity you want to buy/sell: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter 'B' to buy or 'S' to sell: ");
            char transactionType = Console.ReadLine().ToUpper()[0];

            if (transactionType == 'B')
            {
                double totalCost = selectedStock.Price * quantity;
                Console.WriteLine($"Buying {quantity} shares of {selectedStock.Symbol} for ${totalCost}");
            }
            else if (transactionType == 'S')
            {
                double totalValue = selectedStock.Price * quantity;
                Console.WriteLine($"Selling {quantity} shares of {selectedStock.Symbol} for ${totalValue}");
            }
            else
            {
                Console.WriteLine("Invalid transaction type. Please try again.");
            }
        }

        Console.WriteLine("Thank you for using the Stock Trading System!");
    }
}
