
using System;

class Program
{
    static void Main()
    {
        int limit;
        Console.Write("Enter the limit: ");
        limit = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine("The sum of all prime numbers up to {0} is: {1}", limit, sum);
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
