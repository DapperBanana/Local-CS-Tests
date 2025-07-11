
using System;

class Program
{
    static bool IsPrime(int num)
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

    static int NextPrime(int num)
    {
        int next = num + 1;

        while (true)
        {
            if (IsPrime(next))
            {
                return next;
            }

            next++;
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int prime = NextPrime(number);

        Console.WriteLine($"The smallest prime number greater than {number} is: {prime}");
    }
}
