
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static int FindNextPrime(int num)
    {
        while (true)
        {
            num++;
            if (IsPrime(num))
                return num;
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        int nextPrime = FindNextPrime(input);

        Console.WriteLine($"The smallest prime number greater than {input} is: {nextPrime}");
    }
}
