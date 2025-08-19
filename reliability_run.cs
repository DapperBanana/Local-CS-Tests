
using System;

class Program
{
    static void Main()
    {
        int limit;
        Console.Write("Enter the limit: ");
        if(!int.TryParse(Console.ReadLine(), out limit) || limit <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        int sum = 0;
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine($"The sum of all prime numbers up to {limit} is: {sum}");
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
