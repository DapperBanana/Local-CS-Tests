
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a limit: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        long sum = CalculatePrimeSum(limit);
        
        Console.WriteLine("Sum of prime numbers up to {0}: {1}", limit, sum);
    }

    static long CalculatePrimeSum(int limit)
    {
        long sum = 0;

        for (int num = 2; num <= limit; num++)
        {
            if (IsPrime(num))
            {
                sum += num;
            }
        }

        return sum;
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
