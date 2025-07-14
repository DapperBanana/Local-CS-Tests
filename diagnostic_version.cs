
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfectSquare(number))
        {
            Console.WriteLine($"{number} is a perfect square.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect square.");
        }
    }

    static bool IsPerfectSquare(int num)
    {
        double squareRoot = Math.Sqrt(num);

        return squareRoot % 1 == 0;
    }
}
