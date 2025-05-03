
using System;

class Program
{
    static void Main()
    {
        int limit = 4000000;
        int sum = 0;
        
        int a = 1;
        int b = 2;
        
        while (b <= limit)
        {
            if (b % 2 == 0)
            {
                sum += b;
            }
            
            int temp = a;
            a = b;
            b = temp + b;
        }
        
        Console.WriteLine("The sum of all even Fibonacci numbers up to {0} is: {1}", limit, sum);
    }
}
