
using System;

class Program
{
    static void Main()
    {
        int limit;
        Console.WriteLine("Enter a limit to calculate the sum of all prime numbers up to that limit:");
        int.TryParse(Console.ReadLine(), out limit);

        long sum = 0;
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine($"The sum of all prime numbers up to {limit} is: {sum}");
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
