
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the starting number of the range:");
        int start = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the ending number of the range:");
        int end = int.Parse(Console.ReadLine());
        
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }
        
        Console.WriteLine("Number of prime numbers in the range: " + count);
    }
    
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        if (number == 2 || number == 3)
        {
            return true;
        }
        if (number % 2 == 0)
        {
            return false;
        }
        
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
