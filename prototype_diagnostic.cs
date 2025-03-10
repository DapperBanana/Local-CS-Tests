
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int nextPrime = number + 1;

        while (true)
        {
            if (IsPrime(nextPrime))
            {
                Console.WriteLine($"The smallest prime number greater than {number} is {nextPrime}");
                break;
            }
            nextPrime++;
        }
    }
}
