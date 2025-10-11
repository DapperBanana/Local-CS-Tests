
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the starting number of the range: ");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the ending number of the range: ");
        int end = int.Parse(Console.ReadLine());

        int count = CountPrimesInRange(start, end);

        Console.WriteLine($"Number of prime numbers in the range [{start}, {end}]: {count}");
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
