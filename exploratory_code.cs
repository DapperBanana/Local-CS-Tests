
using System;

class Program
{
    static void Main()
    {
        int limit, sum = 0;
        
        Console.Write("Enter a limit: ");
        limit = int.Parse(Console.ReadLine());
        
        for (int num = 2; num <= limit; num++)
        {
            if (IsPrime(num))
            {
                sum += num;
            }
        }
        
        Console.WriteLine($"The sum of all prime numbers up to {limit} is: {sum}");
    }
    
    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }
}
