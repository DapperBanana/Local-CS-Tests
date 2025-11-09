
using System;

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
    static void Main()
    {
        Stock apple = new Stock("Apple", 150.0);
        Stock microsoft = new Stock("Microsoft", 200.0);

        Console.WriteLine("Welcome to the stock trading system!");

        while (true)
        {
            Console.WriteLine($"1. Buy {apple.Name} - Price: {apple.Price}");
            Console.WriteLine($"2. Buy {microsoft.Name} - Price: {microsoft.Price}");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double total = 0.0;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the quantity to buy: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    total += quantity * apple.Price;
                    Console.WriteLine($"Bought {quantity} shares of {apple.Name} for a total of ${quantity * apple.Price}");
                    break;
                case 2:
                    Console.Write("Enter the quantity to buy: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total += quantity * microsoft.Price;
                    Console.WriteLine($"Bought {quantity} shares of {microsoft.Name} for a total of ${quantity * microsoft.Price}");
                    break;
                case 3:
                    Console.WriteLine($"Total amount invested: ${total}");
                    Console.WriteLine("Thank you for using the stock trading system!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
