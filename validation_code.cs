
using System;

class PrimeNumberCounter
{
    static void Main()
    {
        int startRange, endRange;
        int count = 0;

        Console.WriteLine("Enter the start of the range:");
        startRange = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end of the range:");
        endRange = int.Parse(Console.ReadLine());

        for (int i = startRange; i <= endRange; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }

        Console.WriteLine($"Number of prime numbers in the range [{startRange}, {endRange}]: {count}");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
