
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static int NextPrime(int number)
    {
        int prime = number + 1;

        while (true)
        {
            if (IsPrime(prime))
                return prime;
            prime++;
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int nextPrime = NextPrime(number);

        Console.WriteLine($"The smallest prime number greater than {number} is {nextPrime}");
    }
}
