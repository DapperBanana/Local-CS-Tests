
using System;

class Program
{
    static void Main()
    {
        int startRange, endRange;
        
        Console.Write("Enter the start of the range: ");
        startRange = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the end of the range: ");
        endRange = int.Parse(Console.ReadLine());
        
        int sum = 0;
        
        for (int num = startRange; num <= endRange; num++)
        {
            if (IsPrime(num))
            {
                sum += num;
            }
        }
        
        Console.WriteLine($"The sum of all prime numbers in the range {startRange} to {endRange} is: {sum}");
    }
    
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        
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
