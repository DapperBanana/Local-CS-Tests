
using System;

class StockTradingSystem
{
    static void Main()
    {
        double balance = 10000; // Starting balance
        double stockPrice = 50; // Initial stock price
        int stockQuantity = 0; // Number of stocks owned

        Console.WriteLine("Welcome to the Stock Trading System!");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Balance: $" + balance);
            Console.WriteLine("Stock Price: $" + stockPrice);
            Console.WriteLine("Stocks Owned: " + stockQuantity);
            Console.WriteLine();

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Buy stock");
            Console.WriteLine("2. Sell stock");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the quantity to buy:");
                    int quantityToBuy = int.Parse(Console.ReadLine());
                    double totalPriceBuy = stockPrice * quantityToBuy;
                    if (totalPriceBuy > balance)
                    {
                        Console.WriteLine("Insufficient funds.");
                    }
                    else
                    {
                        balance -= totalPriceBuy;
                        stockQuantity += quantityToBuy;
                        Console.WriteLine("Stocks purchased successfully.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter the quantity to sell:");
                    int quantityToSell = int.Parse(Console.ReadLine());
                    if (quantityToSell > stockQuantity)
                    {
                        Console.WriteLine("Not enough stocks to sell.");
                    }
                    else
                    {
                        double totalPriceSell = stockPrice * quantityToSell;
                        balance += totalPriceSell;
                        stockQuantity -= quantityToSell;
                        Console.WriteLine("Stocks sold successfully.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Exiting program...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
