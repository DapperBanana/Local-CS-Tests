
using System;

class StockTrader
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-Based Stock Trading System!");

        double balance = 1000;
        double stockPrice = 10;
        int stockQuantity = 0;

        while (true)
        {
            Console.WriteLine("\nBalance: $" + balance);
            Console.WriteLine("Stock Price: $" + stockPrice);
            Console.WriteLine("Stock Quantity: " + stockQuantity);

            Console.WriteLine("\n1. Buy Stock");
            Console.WriteLine("2. Sell Stock");
            Console.WriteLine("3. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the quantity of stock to buy: ");
                    int buyQuantity = Convert.ToInt32(Console.ReadLine());

                    double totalBuyPrice = stockPrice * buyQuantity;

                    if (totalBuyPrice > balance)
                    {
                        Console.WriteLine("Insufficient funds to buy stock!");
                    }
                    else
                    {
                        stockQuantity += buyQuantity;
                        balance -= totalBuyPrice;
                        Console.WriteLine("Stock bought successfully!");
                    }
                    break;

                case 2:
                    Console.Write("Enter the quantity of stock to sell: ");
                    int sellQuantity = Convert.ToInt32(Console.ReadLine());

                    if (sellQuantity > stockQuantity)
                    {
                        Console.WriteLine("Not enough stock to sell!");
                    }
                    else
                    {
                        double totalSellPrice = stockPrice * sellQuantity;
                        stockQuantity -= sellQuantity;
                        balance += totalSellPrice;
                        Console.WriteLine("Stock sold successfully!");
                    }
                    break;

                case 3:
                    Console.WriteLine("Exiting program...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}

