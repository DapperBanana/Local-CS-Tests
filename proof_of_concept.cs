
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to find its square root: ");
        double num = Convert.ToDouble(Console.ReadLine());
        
        double squareRoot = Math.Sqrt(num);
        
        Console.WriteLine("The square root of " + num + " is " + squareRoot);
    }
}
