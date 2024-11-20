
using System;

class Program
{
    static bool IsPerfectDigitalInvariant(int num)
    {
        string numStr = num.ToString();
        int sum = 0;
        
        foreach(char c in numStr)
        {
            int digit = c - '0';
            sum += digit;
        }
        
        if(num % sum == 0)
        {
            return true;
        }
        
        return false;
    }
    
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        if(IsPerfectDigitalInvariant(number))
        {
            Console.WriteLine($"{number} is a perfect digital invariant.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect digital invariant.");
        }
    }
}
