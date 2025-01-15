
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static int FindNextPrime(int num)
    {
        num++;

        while (true)
        {
            if (IsPrime(num))
                return num;
            num++;
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int nextPrime = FindNextPrime(number);

        Console.WriteLine($"The smallest prime number greater than {number} is: {nextPrime}");
    }
}
