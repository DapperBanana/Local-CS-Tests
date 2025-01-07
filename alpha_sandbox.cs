
using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("Enter a positive integer: ");
        n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        
        Console.WriteLine("The sum of the first {0} natural numbers is: {1}", n, sum);
    }
}
