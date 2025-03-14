
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the starting number of the range: ");
        int start = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the ending number of the range: ");
        int end = int.Parse(Console.ReadLine());

        int primeCount = CountPrimesInRange(start, end);
        
        Console.WriteLine($"There are {primeCount} prime numbers in the range from {start} to {end}.");
    }

    static int CountPrimesInRange(int start, int end)
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
