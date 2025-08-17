
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
        Console.Write("Enter the lower limit of the range: ");
        int lowerLimit = int.Parse(Console.ReadLine());

        Console.Write("Enter the upper limit of the range: ");
        int upperLimit = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = lowerLimit; i <= upperLimit; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }

        Console.WriteLine("The number of prime numbers in the given range is: {0}", count);
    }
}
