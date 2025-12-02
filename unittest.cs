using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        // Swap without temporary variable using arithmetic operations
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"a: {a}, b: {b}");
    }
}