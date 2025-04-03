
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;
        
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int startRange, endRange;
        Console.Write("Enter start range: ");
        startRange = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter end range: ");
        endRange = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = startRange; i <= endRange; i++)
        {
            if (IsPrime(i))
                sum += i;
        }

        Console.WriteLine("Sum of prime numbers in the given range is: " + sum);
    }
}
