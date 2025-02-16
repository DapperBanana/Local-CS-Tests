
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the limit:");
        int limit = int.Parse(Console.ReadLine());
        
        long sum = 0;
        
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }
        
        Console.WriteLine($"The sum of all prime numbers up to {limit} is: {sum}");
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
