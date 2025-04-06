
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2 || number == 3) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static int FindNextPrime(int number)
    {
        int next = number + 1;

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
        Console.WriteLine("Enter a number:");
        int input = Convert.ToInt32(Console.ReadLine());

        int nextPrime = FindNextPrime(input);

        Console.WriteLine($"The smallest prime number greater than {input} is: {nextPrime}");
    }
}
