
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
        number++;

        while (!IsPrime(number))
        {
            number++;
        }

        return number;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int nextPrime = NextPrime(num);

        Console.WriteLine($"The smallest prime number greater than {num} is: {nextPrime}");
    }
}
