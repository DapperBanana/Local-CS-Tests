
using System;

class Program
{
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

    static int CalculateSumOfPrimes(int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++)
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
        int start = 1;
        int end = 100;
        
        int sumOfPrimes = CalculateSumOfPrimes(start, end);

        Console.WriteLine($"Sum of all prime numbers in the range {start} to {end} is: {sumOfPrimes}");
    }
}
