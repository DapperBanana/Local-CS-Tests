
using System;

class Program
{
    static void Main()
    {
        int startRange, endRange;
        Console.WriteLine("Enter the start of the range:");
        startRange = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the end of the range:");
        endRange = Convert.ToInt32(Console.ReadLine());

        long sum = 0;
        for (int i = startRange; i <= endRange; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine("The sum of all prime numbers in the range {0} to {1} is: {2}", startRange, endRange, sum);
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
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
