
using System;

class PrimeNumberCounter
{
    static void Main()
    {
        Console.Write("Enter the starting number of the range: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number of the range: ");
        int end = int.Parse(Console.ReadLine());

        int count = CountPrimeNumbersInRange(start, end);

        Console.WriteLine($"Number of prime numbers in the range [{start}, {end}]: {count}");
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        if (num == 2)
            return true;
        if (num % 2 == 0)
            return false;

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static int CountPrimeNumbersInRange(int start, int end)
    {
        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                count++;
        }

        return count;
    }
}
