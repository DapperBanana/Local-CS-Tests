
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Int32.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);

        if (isPrime)
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        if (number == 2 || number == 3)
            return true;

        if (number % 2 == 0)
            return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
