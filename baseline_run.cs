
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

        int sum = CalculatePrimeSum(startRange, endRange);

        Console.WriteLine("The sum of all prime numbers in the range {0} to {1} is {2}", startRange, endRange, sum);
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

    static int CalculatePrimeSum(int start, int end)
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
}
