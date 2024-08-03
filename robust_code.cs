
using System;

class Program
{
    static void Main()
    {
        int startRange, endRange;
        
        Console.Write("Enter start of range: ");
        startRange = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter end of range: ");
        endRange = Convert.ToInt32(Console.ReadLine());
        
        int count = CountPrimes(startRange, endRange);
        Console.WriteLine($"Number of prime numbers in the range {startRange} to {endRange}: {count}");
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

    static int CountPrimes(int start, int end)
    {
        int count = 0;
        
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }
        
        return count;
    }
}
