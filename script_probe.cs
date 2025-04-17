
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPerfectSquare(number))
        {
            Console.WriteLine($"{number} is a perfect square.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect square.");
        }
    }

    static bool IsPerfectSquare(int number)
    {
        double squareRoot = Math.Sqrt(number);
        return squareRoot == Math.Floor(squareRoot);
    }
}
