
using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter the number of terms for Fibonacci sequence: ");
        int numTerms = int.Parse(Console.ReadLine());

        int first = 0, second = 1, next;

        Console.Write("Fibonacci Sequence up to " + numTerms + " terms: ");
        for (int i = 0; i < numTerms; i++)
        {
            if (i <= 1)
                next = i;
            else
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.Write(next + " ");
        }
        Console.WriteLine();
    }
}
