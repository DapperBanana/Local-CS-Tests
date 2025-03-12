
using System;

class PrimeNumberCounter
{
    static void Main()
    {
        Console.Write("Enter the starting number of the range: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number of the range: ");
        int end = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }

        Console.WriteLine("There are {0} prime numbers between {1} and {2}.", count, start, end);
    }

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
}
