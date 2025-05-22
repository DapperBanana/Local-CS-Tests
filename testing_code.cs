
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num == 1) return false;
        if (num == 2) return true;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter the range to count prime numbers:");
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }

        Console.WriteLine($"Number of prime numbers in the range {start} to {end}: {count}");
    }
}
