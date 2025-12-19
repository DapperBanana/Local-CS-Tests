using System;

class PrimeCounter
{
    static void Main()
    {
        Console.WriteLine("Enter the start of the range:");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end of the range:");
        int end = int.Parse(Console.ReadLine());

        int primeCount = 0;

        for (int number = start; number <= end; number++)
        {
            if (IsPrime(number))
            {
                primeCount++;
            }
        }

        Console.WriteLine($"Number of prime numbers between {start} and {end}: {primeCount}");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int sqrt = (int)Math.Sqrt(number);
        for (int i = 3; i <= sqrt; i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}