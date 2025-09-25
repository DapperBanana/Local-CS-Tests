
using System;

public class Program
{
    public static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
