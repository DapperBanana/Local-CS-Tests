
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }
    
    static int FindNextPrime(int number)
    {
        int nextPrime = number + 1;
        
        while (true)
        {
            if (IsPrime(nextPrime))
            {
                return nextPrime;
            }
            
            nextPrime++;
        }
    }
    
    static void Main()
    {
        Console.Write("Enter a number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        
        int nextPrime = FindNextPrime(inputNumber);
        Console.WriteLine($"The smallest prime number greater than {inputNumber} is: {nextPrime}");
    }
}
