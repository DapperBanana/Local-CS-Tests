
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num <= 1)
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
        Console.WriteLine("Enter the limit: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int sum = SumOfPrimes(limit);

        Console.WriteLine($"The sum of all prime numbers up to {limit} is: {sum}");
    }
}
