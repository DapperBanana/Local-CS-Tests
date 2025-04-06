
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("The sum of the first {0} natural numbers is: {1}", n, sum);
    }
}
