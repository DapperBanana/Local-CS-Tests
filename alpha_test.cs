
using System;

class Program
{
    public static bool IsPrime(int num)
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

    public static int SumOfPrimes(int start, int end)
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }
        return sum;
    }

    static void Main()
    {
        int start = 1;
        int end = 50;
        int sum = SumOfPrimes(start, end);
        Console.WriteLine($"Sum of prime numbers between {start} and {end} is: {sum}");
    }
}
