
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the starting number of the range: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number of the range: ");
        int end = int.Parse(Console.ReadLine());

        int count = CountPrimesInRange(start, end);

        Console.WriteLine($"There are {count} prime numbers in the range [{start}, {end}].");
    }
    
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static int CountPrimesInRange(int start, int end)
    {
        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                count++;
        }

        return count;
    }
}
