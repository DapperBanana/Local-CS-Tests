
using System;

class Program
{
    static void Main()
    {
        int n;
        int sum = 0;

        Console.Write("Enter a positive integer n: ");
        n = int.Parse(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("The sum of the first " + n + " natural numbers is: " + sum);
        }
    }
}
