
using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int startRange = 1;
        int endRange = 100;
        int sum = 0;

        Console.WriteLine($"Prime numbers in range {startRange} to {endRange}:");

        for (int i = startRange; i <= endRange; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
                sum += i;
            }
        }

        Console.WriteLine($"\n\nSum of prime numbers in range: {sum}");
    }
}
