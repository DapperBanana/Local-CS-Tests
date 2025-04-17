
using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0) return false;
        }

        return true;
    }

    static int FindNextPrime(int n)
    {
        n++;
        while (!IsPrime(n))
        {
            n++;
        }

        return n;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int nextPrime = FindNextPrime(num);
        Console.WriteLine($"The smallest prime number greater than {num} is: {nextPrime}");
    }
}
