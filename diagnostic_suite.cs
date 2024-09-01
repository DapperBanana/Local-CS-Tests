
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
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
