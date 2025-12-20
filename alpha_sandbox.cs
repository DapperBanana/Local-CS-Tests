using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            int nextPrime = FindNextPrime(number);
            Console.WriteLine($"The smallest prime number greater than {number} is {nextPrime}.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static int FindNextPrime(int start)
    {
        int candidate = start + 1;
        while (true)
        {
            if (IsPrime(candidate))
                return candidate;
            candidate++;
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        if (num == 2)
            return true;

        if (num % 2 == 0)
            return false;

        int sqrt = (int)Math.Sqrt(num);
        for (int i = 3; i <= sqrt; i += 2)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}