using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (IsPerfectSquare(number))
                Console.WriteLine($"{number} is a perfect square.");
            else
                Console.WriteLine($"{number} is not a perfect square.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }

    static bool IsPerfectSquare(int num)
    {
        if (num < 0)
            return false;

        int sqrt = (int)Math.Sqrt(num);
        return sqrt * sqrt == num;
    }
}