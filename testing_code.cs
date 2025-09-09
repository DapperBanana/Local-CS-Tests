
using System;

class Stock
{
    public string Symbol { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        Stock appleStock = new Stock { Symbol = "AAPL", Price = 150.0, Quantity = 10 };
        Stock microsoftStock = new Stock { Symbol = "MSFT", Price = 200.0, Quantity = 5 };

        Console.WriteLine("Welcome to the Stock Trading System");
        Console.WriteLine("Current Stocks:");
        DisplayStock(applStock);
        DisplayStock(microsoftStock);

        bool done = false;
        while (!done)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Buy stock");
            Console.WriteLine("2. Sell stock");
            Console.WriteLine("3. Display current stocks");
            Console.WriteLine("4. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BuyStock(appleStock);
                    break;
                case 2:
                    SellStock(appleStock);
                    break;
                case 3:
                    DisplayStock(appleStock);
                    DisplayStock(microsoftStock);
                    break;
                case 4:
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Stock Trading System");
    }

    static void DisplayStock(Stock stock)
    {
        Console.WriteLine($"Stock: {stock.Symbol}, Price: {stock.Price}, Quantity: {stock.Quantity}");
    }

    static void BuyStock(Stock stock)
    {
        Console.WriteLine("Enter the quantity to buy:");
        int quantity = int.Parse(Console.ReadLine());
        stock.Quantity += quantity;
        Console.WriteLine("Stock bought successfully");
    }

    static void SellStock(Stock stock)
    {
        Console.WriteLine("Enter the quantity to sell:");
        int quantity = int.Parse(Console.ReadLine());
        if (stock.Quantity >= quantity)
        {
            stock.Quantity -= quantity;
            Console.WriteLine("Stock sold successfully");
        }
        else
        {
            Console.WriteLine("Insufficient quantity to sell");
        }
    }
}
