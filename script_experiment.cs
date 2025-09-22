
using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter the number of terms for Fibonacci sequence: ");
        int n = int.Parse(Console.ReadLine());

        int first = 0, second = 1, next;

        Console.WriteLine("Fibonacci sequence:");
        Console.Write($"{first} {second} ");

        for (int i = 2; i < n; i++)
        {
            next = first + second;
            Console.Write($"{next} ");
            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}
