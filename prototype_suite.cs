
using System;

class Program
{
    static void Main()
    {
        int start, end;
        int count = 0;

        Console.WriteLine("Enter the starting number of the range: ");
        start = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the ending number of the range: ");
        end = Convert.ToInt32(Console.ReadLine());

        for (int num = start; num <= end; num++)
        {
            if (IsPrime(num))
            {
                count++;
            }
        }

        Console.WriteLine($"Number of prime numbers in the range {start} to {end} is: {count}");
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
            {
                return false;
            }
        }

        return true;
    }
}
