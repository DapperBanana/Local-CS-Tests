
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
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

    static int SumOfPrimes(int limit)
    {
        int sum = 0;

        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a limit: ");
        int limit = int.Parse(Console.ReadLine());

        int sum = SumOfPrimes(limit);
        Console.WriteLine($"The sum of all prime numbers up to {limit} is: {sum}");
    }
}
