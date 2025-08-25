
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is a perfect square:");
        int number = Int32.Parse(Console.ReadLine());

        if (IsPerfectSquare(number))
        {
            Console.WriteLine(number + " is a perfect square.");
        }
        else
        {
            Console.WriteLine(number + " is not a perfect square.");
        }
    }

    static bool IsPerfectSquare(int number)
    {
        double squareRoot = Math.Sqrt(number);
        return squareRoot % 1 == 0;
    }
}
