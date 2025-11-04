
using System;

class Program
{
    static void Main()
    {
        int limit;
        do
        {
            Console.WriteLine("Enter a positive integer limit:");
        } while (!int.TryParse(Console.ReadLine(), out limit) || limit <= 0);

        int sum = 0;

        for (int num = 2; num <= limit; num++)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                sum += num;
            }
        }

        Console.WriteLine($"The sum of all prime numbers up to {limit} is: {sum}");
    }
}
