
using System;

namespace StockTradingSystem
{
    class Program
    {
        static double initialBalance = 10000;
        static double balance = initialBalance;
        static double stockPrice = 50;
        static int stockQuantity = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Stock Price: $" + stockPrice);
                Console.WriteLine("Balance: $" + balance);
                Console.WriteLine("Stock Quantity: " + stockQuantity);
                Console.WriteLine();

                Console.WriteLine("1. Buy");
                Console.WriteLine("2. Sell");
                Console.WriteLine("3. Quit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Buy();
                        break;
                    case 2:
                        Sell();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void Buy()
        {
            Console.Write("Enter the quantity you want to buy: ");
            int quantity = int.Parse(Console.ReadLine());

            double totalCost = quantity * stockPrice;

            if (totalCost > balance)
            {
                Console.WriteLine("Not enough funds to buy this quantity.");
            }
            else
            {
                balance -= totalCost;
                stockQuantity += quantity;
                Console.WriteLine("Stocks bought successfully.");
            }
        }

        static void Sell()
        {
            Console.Write("Enter the quantity you want to sell: ");
            int quantity = int.Parse(Console.ReadLine());

            if (quantity > stockQuantity)
            {
                Console.WriteLine("Not enough stocks to sell this quantity.");
            }
            else
            {
                double totalSale = quantity * stockPrice;
                balance += totalSale;
                stockQuantity -= quantity;
                Console.WriteLine("Stocks sold successfully.");
            }
        }
    }
}
