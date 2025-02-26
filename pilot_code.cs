
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
        int nextNumber = number + 1;

        while (true)
        {
            if (IsPrime(nextNumber))
                return nextNumber;

            nextNumber++;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());

        int smallestPrime = NextPrime(input);

        Console.WriteLine($"The smallest prime number greater than {input} is: {smallestPrime}");
    }
}
