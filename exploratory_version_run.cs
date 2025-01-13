
using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;

        Console.WriteLine("Before swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        // Swapping values without using a temporary variable
        a = a + b; // a = 30
        b = a - b; // b = 10
        a = a - b; // a = 20

        Console.WriteLine("\nAfter swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
