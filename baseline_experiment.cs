
using System;

class Program
{
    static void Main()
    {
        int startRange = 1;
        int endRange = 100;
        int sum = 0;

        for (int num = startRange; num <= endRange; num++)
        {
            if (IsPrime(num))
            {
                sum += num;
            }
        }

        Console.WriteLine("The sum of all prime numbers between {0} and {1} is: {2}", startRange, endRange, sum);
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
