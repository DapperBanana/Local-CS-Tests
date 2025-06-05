
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer n:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
        else
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
        }
    }
}
