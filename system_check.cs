
using System;

class Program
{
    static void Main()
    {
        int startRange = 1;
        int endRange = 100;
        
        int sum = CalculateSumOfPrimes(startRange, endRange);
        
        Console.WriteLine($"The sum of all prime numbers between {startRange} and {endRange} is: {sum}");
    }
    
    static bool IsPrime(int number)
    {
        if (number <= 1) 
            return false;
        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        
        return true;
    }
    
    static int CalculateSumOfPrimes(int startRange, int endRange)
    {
        int sum = 0;
        
        for (int i = startRange; i <= endRange; i++)
        {
            if (IsPrime(i))
                sum += i;
        }
        
        return sum;
    }
}
