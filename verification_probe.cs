
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double num = Convert.ToDouble(Console.ReadLine());

        double sqrt = Math.Sqrt(num);

        Console.WriteLine($"Square root of {num} is: {sqrt}");
    }
}
