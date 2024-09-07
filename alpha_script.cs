
using System;

class Program
{
    static void Main()
    {
        int startRange = 2; // starting range
        int endRange = 50; // ending range
        
        int sumOfPrimes = CalculateSumOfPrimes(startRange, endRange);
        
        Console.WriteLine($"Sum of prime numbers between {startRange} and {endRange} is: {sumOfPrimes}");
    }
    
    static int CalculateSumOfPrimes(int start, int end)
    {
        int sum = 0;
        
        for(int i = start; i <= end; i++)
        {
            if(IsPrime(i))
            {
                sum += i;
            }
        }
        
        return sum;
    }
    
    static bool IsPrime(int number)
    {
        if(number < 2) return false;
        if(number == 2) return true;

        for(int i = 2; i <= Math.Sqrt(number); i++)
        {
            if(number % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }
}
