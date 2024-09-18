
using System;

class Program
{
    static void Main()
    {
        int limit = 4000000;
        int sum = 0;
        
        int prev = 1;
        int current = 1;
        
        while (current <= limit)
        {
            int temp = current;
            current = prev + current;
            prev = temp;
            
            if (current % 2 == 0)
            {
                sum += current;
            }
        }
        
        Console.WriteLine("The sum of all even Fibonacci numbers up to " + limit + " is: " + sum);
    }
}
