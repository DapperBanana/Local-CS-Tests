
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to find its square root: ");
        double num = double.Parse(Console.ReadLine());

        double sqrt = Math.Sqrt(num);

        Console.WriteLine($"The square root of {num} is {sqrt}");
    }
}
