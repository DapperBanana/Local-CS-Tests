
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
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
        int sqrt = (int)Math.Sqrt(number);
        return number == sqrt * sqrt;
    }
}
