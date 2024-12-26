
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the limit: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine("Sum of all prime numbers up to " + limit + " is: " + sum);
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
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
