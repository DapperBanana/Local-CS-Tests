
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

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
        double sqrt = Math.Sqrt(num);
        return sqrt % 1 == 0;
    }
}
