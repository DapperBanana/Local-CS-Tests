
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
        int n = int.Parse(Console.ReadLine());

        int first = 0, second = 1, next;

        Console.WriteLine("Fibonacci Sequence up to " + n + " terms:");

        for (int i = 0; i < n; i++)
        {
            if (i <= 1)
            {
                next = i;
            }
            else
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.Write(next + " ");
        }
    }
}
