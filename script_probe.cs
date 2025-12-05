using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number % 2 == 0)
                Console.WriteLine($"{number} is even.");
            else
                Console.WriteLine($"{number} is odd.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}