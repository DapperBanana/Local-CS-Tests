
using System;

class Program
{
    static void Main()
    {
        int start, end, count = 0;
        
        Console.WriteLine("Enter the starting number: ");
        start = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the ending number: ");
        end = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Prime numbers in the range " + start + " to " + end + ": ");
        
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
                count++;
            }
        }
        
        Console.WriteLine("Total prime numbers: " + count);
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
