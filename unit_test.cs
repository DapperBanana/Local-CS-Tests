
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms in the Fibonacci sequence: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int first = 0, second = 1, next;

        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < n; i++)
        {
            if (i <= 1)
                next = i;
            else
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine(next);
        }
    }
}
