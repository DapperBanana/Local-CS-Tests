
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lower bound of the range:");
        int lowerBound = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the upper bound of the range:");
        int upperBound = int.Parse(Console.ReadLine());

        int count = CountPrimesInRange(lowerBound, upperBound);
        Console.WriteLine($"Number of prime numbers in the range [{lowerBound}, {upperBound}]: {count}");
    }

    static int CountPrimesInRange(int lowerBound, int upperBound)
    {
        int count = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }

        return count;
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
