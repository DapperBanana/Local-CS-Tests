
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        
        Console.WriteLine("The sum of the first " + n + " natural numbers is: " + sum);
    }
}
