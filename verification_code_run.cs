
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;
        
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        
        return true;
    }

    static void Main()
    {
        int num;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        if (IsPrime(num))
            Console.WriteLine($"{num} is a prime number.");
        else
            Console.WriteLine($"{num} is not a prime number.");
    }
}
