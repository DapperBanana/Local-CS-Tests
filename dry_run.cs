
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool isPerfectSquare = CheckPerfectSquare(num);

        if (isPerfectSquare)
        {
            Console.WriteLine($"{num} is a perfect square.");
        }
        else
        {
            Console.WriteLine($"{num} is not a perfect square.");
        }
    }

    static bool CheckPerfectSquare(int num)
    {
        double sqrt = Math.Sqrt(num);
        return sqrt % 1 == 0;
    }
}
