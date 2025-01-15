
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms in the Fibonacci sequence: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1;

        Console.Write("Fibonacci sequence up to " + n + " terms: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine();
    }
}
