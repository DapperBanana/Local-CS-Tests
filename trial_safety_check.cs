
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static int SumOfPrimesInRange(int start, int end)
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                sum += i;
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Enter the range start: ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the range end: ");
        int end = int.Parse(Console.ReadLine());

        int sum = SumOfPrimesInRange(start, end);

        Console.WriteLine($"The sum of all prime numbers in the range {start}-{end} is: {sum}");
    }
}
