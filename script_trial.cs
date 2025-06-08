
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the lower limit of the range: ");
        int lowerLimit = int.Parse(Console.ReadLine());

        Console.Write("Enter the upper limit of the range: ");
        int upperLimit = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = lowerLimit; i <= upperLimit; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine($"The sum of all prime numbers between {lowerLimit} and {upperLimit} is: {sum}");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
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
