
using System;

class Program
{
    static void Main()
    {
        int startRange, endRange;
        Console.Write("Enter the start of the range: ");
        startRange = int.Parse(Console.ReadLine());

        Console.Write("Enter the end of the range: ");
        endRange = int.Parse(Console.ReadLine());

        int count = CountPrimesInRange(startRange, endRange);
        Console.WriteLine("Number of prime numbers in the range {0} to {1} is {2}", startRange, endRange, count);
    }

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
}
