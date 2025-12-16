using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            int nextPrime = FindNextPrime(number);
            Console.WriteLine("The smallest prime greater than {0} is {1}.", number, nextPrime);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static int FindNextPrime(int num)
    {
        int candidate = num + 1;
        while (true)
        {
            if (IsPrime(candidate))
                return candidate;
            candidate++;
        }
    }

    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;
        if (n == 2 || n == 3)
            return true;
        if (n % 2 == 0)
            return false;
        int sqrt = (int)Math.Sqrt(n);
        for (int i = 3; i <= sqrt; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}