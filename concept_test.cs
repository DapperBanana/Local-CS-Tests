
using System;

namespace StockTradingSystem
{
    class Program
    {
        static double balance = 1000.00;
        static int numShares = 0;
        static double stockPrice = 50.00;
        
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Welcome to the Stock Trading System!");
                Console.WriteLine("Options:");
                Console.WriteLine("1. Buy Stock");
                Console.WriteLine("2. Sell Stock");
                Console.WriteLine("3. View Portfolio");
                Console.WriteLine("4. Exit");
                
                int choice = int.Parse(Console.ReadLine());
                
                switch(choice)
                {
                    case 1:
                        BuyStock();
                        break;
                    case 2:
                        SellStock();
                        break;
                    case 3:
                        ViewPortfolio();
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
            Console.WriteLine($"Current stock price: ${stockPrice}");
            
            Console.Write("Enter the number of shares to buy: ");
            int buyShares = int.Parse(Console.ReadLine());
            double cost = buyShares * stockPrice;
            
            if(cost > balance)
            {
                Console.WriteLine("Not enough balance to buy this many shares.");
            }
            else
            {
                numShares += buyShares;
                balance -= cost;
                Console.WriteLine($"Successfully bought {buyShares} shares for ${cost}");
            }
        }
        
        static void SellStock()
        {
            Console.WriteLine($"Current stock price: ${stockPrice}");
            
            Console.Write("Enter the number of shares to sell: ");
            int sellShares = int.Parse(Console.ReadLine());
            
            if(sellShares > numShares)
            {
                Console.WriteLine("Not enough shares to sell.");
            }
            else
            {
                double earnings = sellShares * stockPrice;
                numShares -= sellShares;
                balance += earnings;
                Console.WriteLine($"Successfully sold {sellShares} shares for ${earnings}");
            }
        }
        
        static void ViewPortfolio()
        {
            Console.WriteLine($"Current balance: ${balance}");
            Console.WriteLine($"Number of shares: {numShares}");
            Console.WriteLine($"Total portfolio value: ${balance + numShares * stockPrice}");
        }
    }
}
