
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms for Fibonacci sequence: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        int first = 0, second = 1, next;

        Console.Write("Fibonacci sequence up to " + terms + " terms: ");
        for (int i = 0; i < terms; i++)
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
