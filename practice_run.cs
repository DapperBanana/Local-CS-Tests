
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsPerfectSquare(num))
        {
            Console.WriteLine($"{num} is a perfect square.");
        }
        else
        {
            Console.WriteLine($"{num} is not a perfect square.");
        }
    }

    static bool IsPerfectSquare(int num)
    {
        int sqrt = (int)Math.Sqrt(num);
        return (sqrt * sqrt == num);
    }
}
