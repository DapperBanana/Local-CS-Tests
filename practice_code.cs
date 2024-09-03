
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lower bound of the range: ");
        int lowerBound = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the upper bound of the range: ");
        int upperBound = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine($"The sum of all prime numbers in the range {lowerBound}-{upperBound} is: {sum}");
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
