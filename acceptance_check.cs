
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the starting number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int end = int.Parse(Console.ReadLine());

        int sum = SumOfPrimes(start, end);

        Console.WriteLine($"The sum of all prime numbers between {start} and {end} is: {sum}");
    }

    static int SumOfPrimes(int start, int end)
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

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
