
using System;

class Program
{
    public static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        
        return true;
    }
    
    public static int FindNextPrime(int num)
    {
        int next = num + 1;
        
        while (true)
        {
            if (IsPrime(next))
                return next;
            
            next++;
        }
    }
    
    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        
        int nextPrime = FindNextPrime(input);
        
        Console.WriteLine($"The smallest prime number greater than {input} is {nextPrime}");
    }
}
