
using System;

namespace StockTradingSystem
{
    class Program
    {
        static double balance = 10000;
        static double stockPrice = 50;
        static int stocksOwned = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Balance: $" + balance);
                Console.WriteLine("Stock price: $" + stockPrice);
                Console.WriteLine("Stocks owned: " + stocksOwned);
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Buy");
                Console.WriteLine("2. Sell");
                Console.WriteLine("3. Quit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BuyStock();
                        break;
                    case 2:
                        SellStock();
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

        static void BuyStock()
        {
            Console.WriteLine("How many stocks would you like to buy?");
            int quantity = int.Parse(Console.ReadLine());

            double totalCost = stockPrice * quantity;

            if (totalCost > balance)
            {
                Console.WriteLine("Insufficient funds. Cannot buy stocks.");
            }
            else
            {
                balance -= totalCost;
                stocksOwned += quantity;
                Console.WriteLine("Bought " + quantity + " stocks for $" + totalCost);
            }
        }

        static void SellStock()
        {
            Console.WriteLine("How many stocks would you like to sell?");
            int quantity = int.Parse(Console.ReadLine());

            if (quantity > stocksOwned)
            {
                Console.WriteLine("You do not own enough stocks to sell.");
            }
            else
            {
                double totalValue = stockPrice * quantity;
                balance += totalValue;
                stocksOwned -= quantity;
                Console.WriteLine("Sold " + quantity + " stocks for $" + totalValue);
            }
        }
    }
}
