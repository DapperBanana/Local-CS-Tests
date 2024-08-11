
using System;

namespace StockTradingSystem
{
    class Program
    {
        static double balance = 10000;
        static int stockPrice = 50;
        static int stockQuantity = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stock Trading System!");

            while (true)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Balance: $" + balance);
                Console.WriteLine("Stock Price: $" + stockPrice);
                Console.WriteLine("Stock Quantity: " + stockQuantity);
                Console.WriteLine("------------------------------------");

                Console.WriteLine("1. Buy Stock");
                Console.WriteLine("2. Sell Stock");
                Console.WriteLine("3. Quit");

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BuyStock();
                        break;
                    case 2:
                        SellStock();
                        break;
                    case 3:
                        Console.WriteLine("Exiting program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void BuyStock()
        {
            Console.WriteLine("Enter the quantity of stock you want to buy: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double totalCost = quantity * stockPrice;

            if (totalCost > balance)
            {
                Console.WriteLine("Insufficient funds!");
            }
            else
            {
                balance -= totalCost;
                stockQuantity += quantity;
                Console.WriteLine("Stock purchased successfully!");
            }
        }

        static void SellStock()
        {
            Console.WriteLine("Enter the quantity of stock you want to sell: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (quantity > stockQuantity)
            {
                Console.WriteLine("You do not have enough stock to sell!");
            }
            else
            {
                double totalSale = quantity * stockPrice;
                balance += totalSale;
                stockQuantity -= quantity;
                Console.WriteLine("Stock sold successfully!");
            }
        }
    }
}
