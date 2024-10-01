
using System;

class Program
{
    static void Main()
    {
        int limit;
        do
        {
            Console.Write("Enter the limit: ");
        } while (!int.TryParse(Console.ReadLine(), out limit) || limit < 2);
        
        long sum = CalculateSumOfPrimes(limit);
        
        Console.WriteLine($"The sum of all prime numbers up to {limit} is: {sum}");
    }

    static long CalculateSumOfPrimes(int limit)
    {
        long sum = 0;
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }
        return sum;
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
