
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before swapping: a = {0}, b = {1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After swapping: a = {0}, b = {1}", a, b);
    }
}
