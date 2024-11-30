
using System;

namespace StockTradingSystem
{
    class Program
    {
        static double accountBalance = 10000;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Buy Stock");
                Console.WriteLine("2. Sell Stock");
                Console.WriteLine("3. View Account Balance");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
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
                        ViewAccountBalance();
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

        static void BuyStock()
        {
            Console.Write("Enter the stock price: ");
            double stockPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            double totalCost = stockPrice * quantity;

            if (totalCost > accountBalance)
            {
                Console.WriteLine("Insufficient funds. Account balance is {0}", accountBalance);
            }
            else
            {
                accountBalance -= totalCost;
                Console.WriteLine("Stock bought successfully. Account balance is now {0}", accountBalance);
            }
        }

        static void SellStock()
        {
            Console.Write("Enter the stock price: ");
            double stockPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            double totalValue = stockPrice * quantity;

            accountBalance += totalValue;
            Console.WriteLine("Stock sold successfully. Account balance is now {0}", accountBalance);
        }

        static void ViewAccountBalance()
        {
            Console.WriteLine("Account balance is {0}", accountBalance);
        }
    }
}
