
using System;

class Program
{
    static void Main()
    {
        int start, end, count = 0;

        Console.WriteLine("Enter the start of the range: ");
        start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end of the range: ");
        end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }

        Console.WriteLine($"The number of prime numbers in the range {start} to {end} is: {count}");
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
}
